using dal;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace wpf.Viewmodels
{
    public class MainViewmodel : BaseViewmodel
    {
       

        private string _foutmelding;

        public string Foutmelding
        {
            get { return _foutmelding; }
            set { _foutmelding = value; }
        }

        private PolitiekePartij _politiekePartij;
        private Politicus _geselecteerdepoliticus;

        public PolitiekePartij GeselecteerdePolitiekePartij
        {
            get { return _politiekePartij; }
            set { _politiekePartij = value;
                
                Foutmelding = string.Empty;

                PartijLedenOpvullen();
            }
        }

        public Politicus GeselecteerdePoliticus
        {
            get { return _geselecteerdepoliticus; }
            set
            {
                _geselecteerdepoliticus = value;

                Foutmelding = string.Empty;
            }
        }

     

        private ObservableCollection<PolitiekePartij> _partijen;
        private ObservableCollection<Politicus> _politici;

        public ObservableCollection<PolitiekePartij> Partijen
        {
            get { return _partijen; }
            set { _partijen = value; }
        }
        public ObservableCollection<Politicus> Politici
        {
            get { return _politici; }
            set { _politici = value; }
        }

        public MainViewmodel()
        {
            Partijen = new ObservableCollection<PolitiekePartij>(DatabaseOperations.HaalPartijenOp());
            

            
        }

        private void PartijLedenOpvullen()
        {
            if (GeselecteerdePolitiekePartij  is not null)
                Politici = new ObservableCollection<Politicus>(DatabaseOperations.HaalPoliticiOp(GeselecteerdePolitiekePartij.Id));
        }

        public void UpdateEntiteit()
        {
            if (GeselecteerdePoliticus is null)
            {
                Foutmelding = "Selecteer eerst een Politicus om vervolgens aanpassingen te bewaren.";
                return;
            }
            if (GeselecteerdePoliticus.IsGeldig())
            {
                GeselecteerdePoliticus.PolitiekePartijNiveau.Niveau.Id = GeselecteerdePoliticus.PolitiekePartijNiveau.NiveauID;
                int result = DatabaseOperations.BewaarPoliticus(GeselecteerdePoliticus);
                if (result > 0)
                {
                    PartijLedenOpvullen();
                    return;
                }
                
                Foutmelding = "Er is iets fout gelopen";

            }

            Foutmelding = GeselecteerdePoliticus.Error;


        }

        public override string this[string columnName] => string.Empty;

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
               case "Bewaren": UpdateEntiteit();
                    break;
            }
        }
    }
}