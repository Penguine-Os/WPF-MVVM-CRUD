
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace models;

[Table("PolitiekePartijenNiveau")]
public class PolitiekePartijNiveau
{
    [Key]
    public int Id { get; set; }


    //NavigationProp
    public int PolitiekePartijID { get; set; }
    public virtual PolitiekePartij PolitiekePartij { get; set; }

    public int NiveauID { get; set; }
    public virtual Niveau Niveau { get; set; }



   public ICollection<Politicus> Politici { get; set; }

    public override string? ToString()
    {
        string message="Niveaus niet beschikbaar";

        if (Niveau is not null)
            message = Niveau.Omschrijving;

        return message;
    }
}