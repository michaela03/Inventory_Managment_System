using System.ComponentModel.DataAnnotations;

namespace Inventories.Models
{
    public class Delivery
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string StockName { get; set; }
        [Required]
        public string UnitOfMeasurement { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Deliverer { get; set; }
        [Required]
        public DateTime DeliveryDate { get; set; }

        public Delivery()
        {

        }
    }
}
