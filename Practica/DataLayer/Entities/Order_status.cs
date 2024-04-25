using System;

namespace DataLayer.Entities
{
    public class Order_status
    { [Key]
        public int Id { get; set; }
        public string StatusValue { get; set; }
    }
}