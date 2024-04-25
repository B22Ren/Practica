using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities
{
    [Table("Restaurant")]
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }

        public string Denumire { get; set; }

        [ForeignKey("Adresa")]
        public int AdresaId { get; set; }

        public virtual Adresa Adresa { get; set; }
    }
}