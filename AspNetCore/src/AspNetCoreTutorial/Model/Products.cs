namespace AspNetCoreTutorial.Model
{
    public class Products
    {
        public int ProductId { get; set; }
        public string DisplayName { get; set; }
        public int Quantity { get; set; }

        public bool Active { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}