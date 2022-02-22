using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("product")]

public class Product
{
    [Key]
    [StringLength(10)]
    public string Id { get; set; }

    [StringLength(50)]
    public string name { get; set; }

    [Column(TypeName="ntext")]
    public string description { get; set; }

    public int cost { get; set; }

    public int inventory { get; set; }

    public bool stopped { get; set; }
}