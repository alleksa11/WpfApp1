using System.Collections.ObjectModel;
using System.Windows;

namespace ProductManagementApp
{
    public partial class MainWindow : Window
    {
        // Коллекция для хранения продуктов
        private ObservableCollection<Product> products = new ObservableCollection<Product>();

        public MainWindow()
        {
            InitializeComponent();

            // Привязка коллекции к элементу управления ListBox
            productListBox.ItemsSource = products;
        }

        // Обработчик события нажатия кнопки "Add Product"
        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            // Получение данных о продукте из текстовых полей
            string name = nameTextBox.Text;
            double price = double.Parse(priceTextBox.Text);
            int quantity = int.Parse(quantityTextBox.Text);

            // Создание нового экземпляра продукта
            Product product = new Product(name, price, quantity);

            // Добавление продукта в коллекцию
            products.Add(product);

            // Очистка текстовых полей после добавления продукта
            nameTextBox.Clear();
            priceTextBox.Clear();
            quantityTextBox.Clear();
        }
    }
}
