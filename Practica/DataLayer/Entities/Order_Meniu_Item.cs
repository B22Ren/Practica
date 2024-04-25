using System;

namespace DataLayer.Entities
{
    public class Order_Meniu_Item
    {
        [Key]
        public int Id { get; set; }
        public int Cantitate { get; set; }
        
        [ForeignKey("Meniu_Order")]
        public int MeniuOrderId { get; set; }
        public Meniu_Order Meniu_Order { get; set; }
    }
}