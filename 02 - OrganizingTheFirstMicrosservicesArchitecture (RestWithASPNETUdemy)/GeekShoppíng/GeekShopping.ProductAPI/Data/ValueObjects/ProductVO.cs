using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeekShopping.ProductAPI.Data.ValueObjects
{
    public class ProductVO
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public required decimal Price { get; set; }
        public string? Description { get; set; }
        public required string CategoryName { get; set; }
        public string? ImageURL { get; set; }
    }
}
