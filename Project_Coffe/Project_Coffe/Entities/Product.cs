using System.ComponentModel.DataAnnotations;

namespace Project_Coffe.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive number.")]
        public double? Price { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        public byte[]? Img { get; set; }

        public byte[]? Music { get; set; }
    }
}
