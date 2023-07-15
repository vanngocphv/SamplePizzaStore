using System.ComponentModel.DataAnnotations;

namespace SampleStoreWebApp.Models
{
    public class PizzaOrder
    {
        [Key]
        public int PizzaId { get; set; }
        [Required]
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 2;
    }
}
