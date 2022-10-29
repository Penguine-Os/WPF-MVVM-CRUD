using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace models;

[Table("PolitiekePartijen")]
public class PolitiekePartij
{
    [Key]
    public int Id { get; set; }
    public string PartijNaam { get; set; }
    public int AantalLeden { get; set; }

    //Navigation
    public virtual ICollection<PolitiekePartijNiveau> PolitiekePartijNiveaus { get; set; }

    public override string? ToString()
    {
        return $"{PartijNaam}";
    }
}