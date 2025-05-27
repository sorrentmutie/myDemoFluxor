namespace DemoFluxor.Models
{
    public record Item(string Name, decimal Price)
    {
        public override string ToString() => $"{Name} - {Price:C}";
    }

}