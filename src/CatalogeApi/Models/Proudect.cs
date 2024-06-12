namespace CatalogeApi.Models
{
    public class Proudct
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public List<string> Gategory { get; set; } = new();
        public string Discription { get; set; }=default!;

        public string ImageFile { get; set; } = default!;
        public decimal Price { get; set; }
    }
}
