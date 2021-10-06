namespace Entities.Factory
{
    public class Produto
    {
        public string Id { get; set; }
        public Embalagem Embalagem { get; set; } = new();
        public Chocolate Chocolate { get; set; } = new();

    }
}