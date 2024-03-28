using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Laba5._2
{
    /// <summary>
    /// Логика взаимодействия для SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        private FishingStoreEntities context = new FishingStoreEntities();
        public SecondWindow()
        {
            InitializeComponent();
            TovarTbx.ItemsSource = context.Products.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Products prod = new Products();
            prod.Name = NameDbx.Text;
            int.TryParse(QuantityDbx.Text, out int quantiti);
            prod.Quantity_In_Stock = quantiti;
            decimal.TryParse(PriceDbx.Text, out decimal price);
            prod.Price = price;
            prod.Warehouse_ID = 1;
            prod.Category_ID = 2;
            prod.Manufacturer_ID = 1;

            context.Products.Add(prod);
            context.SaveChanges();
            TovarTbx.ItemsSource = context.Products.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var prod = TovarTbx.SelectedItem as Products;
            prod.Name = NameDbx.Text;
            int.TryParse(QuantityDbx.Text, out int quantiti);
            prod.Quantity_In_Stock = quantiti;
            decimal.TryParse(PriceDbx.Text, out decimal price);
            prod.Price = price;
            prod.Warehouse_ID = 1;
            prod.Category_ID = 2;
            prod.Manufacturer_ID = 1;


            context.SaveChanges();
            TovarTbx.ItemsSource = context.Products.ToList();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            context.Products.Remove(TovarTbx.SelectedItem as Products);
            context.SaveChanges();
            TovarTbx.ItemsSource = context.Products.ToList();
        }
    }
}
