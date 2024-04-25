using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities
{
    [Table("Meniu_Item")]
    public class Meniu_Item
    {
        [Key]
        public int ID { get; set; }
        public decimal Pret { get; set; }
        public string Denumire_Produs { get; set; }
        public int Restaurant_ID { get; set; }
        public Restaurant Restaurant { get; set; }
    }