using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace models;

[Table("Niveaus")]
public class Niveau
{
    [Key]
    public int Id { get; set; }
    public string Omschrijving { get; set; }

    //Navigation
    public virtual ICollection<PolitiekePartijNiveau> PolitiekePartijNiveaus { get; set; }
  
}