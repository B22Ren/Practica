using System;

namespace DataLayer.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Tax { get; set; }
        public int RestaurantRating { get; set; }
        public int DriverRating { get; set; }
        public TimeSpan DeliveryTime { get; set; }
        
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        
        public int AdresaDestId { get; set; }
        public virtual Adresa_Client AdresaDest { get; set; }
        
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        
        public int SoferId { get; set; }
        public virtual Sofer_Comanda Sofer { get; set; }
        
        public int OrderStatusId { get; set; }
        public virtual Order_Status OrderStatus { get; set; }
    }
}