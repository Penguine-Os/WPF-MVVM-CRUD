using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models;
namespace models
{
    public partial class Politicus : BasisKlasse
    {
        public override string this[string columnName]
        {
            get
            {
                if (columnName == "Naam" && string.IsNullOrWhiteSpace(Naam))
                {
                    return "Naam is verplicht in te vullen";
                }
                if (columnName == "JarenDienst" && JarenDienst < 0 || JarenDienst > 45)
                {
                    return "Jaren in Dienst moet tussen 0 en 45 liggen";
                }
                return "";
            }
        }
      
    }
}
