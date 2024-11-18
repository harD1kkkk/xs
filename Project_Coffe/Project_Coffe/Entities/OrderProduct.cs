using System.ComponentModel.DataAnnotations;

namespace Project_Coffe.Entities
{
    public class OrderProduct
    {
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int OrderId { get; set; }
        public Order? Order { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int? Quantity { get; set; }

    }
}
