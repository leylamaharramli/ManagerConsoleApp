namespace ManagerConsoleApp.Models
{
    public class Product : BaseEntity
    {
        public string Name;
        public float Price;

        public Product(string name, float price)
        {
            Name = name;
            Price = price;

        }

        public override string ToString()
        {
            return $"{ID}. {Name}/{Price}";
        }
    }
}
