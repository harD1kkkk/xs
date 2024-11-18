using System.ComponentModel.DataAnnotations;

namespace Project_Coffe.Entities
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Total amount cannot be negative.")]
        public decimal TotalAmount { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
        public List<OrderProduct>? OrderProducts { get; set; }
    }
}
