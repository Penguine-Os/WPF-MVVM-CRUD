using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace models;

[Table("Politici")]
public partial class Politicus
{
    [Key]
    public int Id { get; set; }
    public int JarenDienst { get; set; }
    public string Naam { get; set; }

    //NavigationProps
    public int PolitiekePartijNiveauID { get; set; }
    public virtual PolitiekePartijNiveau PolitiekePartijNiveau { get; set; }
}