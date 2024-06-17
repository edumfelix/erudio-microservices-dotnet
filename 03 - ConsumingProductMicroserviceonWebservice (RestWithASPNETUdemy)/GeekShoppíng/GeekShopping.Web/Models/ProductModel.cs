namespace GeekShopping.Web.Models
{
    public class ProductModel
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public required decimal Price { get; set; }
        public string? Description { get; set; }
        public required string CategoryName { get; set; }
        public string? ImageURL { get; set; }
    }
}
