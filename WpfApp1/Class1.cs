namespace ProductManagementApp
{
    public class Product
    {
        // Свойства
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        // Конструктор
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // Метод для получения описания продукта
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}";
        }
    }
}
