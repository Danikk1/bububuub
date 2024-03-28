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
using System.IO;

namespace Laba5._2
{
    /// <summary>
    /// Логика взаимодействия для ChequeWindow.xaml
    /// </summary>
    public partial class ChequeWindow : Window
    {
        private FishingStoreEntities context = new FishingStoreEntities();
        public ChequeWindow()
        {
            InitializeComponent();
            TovarTbx.ItemsSource = context.Products.ToList();


            var Magaz = context.Stores.Select(mag => mag.Name).ToList();
            MagazDbx.ItemsSource = Magaz;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Чек");
            sb.AppendLine("Дата покупки " + DateTime.Now);
            sb.AppendLine("--------------------------------------------------------------------------------");
            sb.AppendLine("Товары:");

            foreach (var i in ChekTbx.Items)
            {
                var pr = i as Products;
                sb.AppendLine($"{pr.Name} ------- {pr.Price}");
            }

            sb.AppendLine("---------------==========--------------");
            sb.AppendLine("Сумма: " + Priced.Items[0]);
            sb.AppendLine("Магазин: " + MagazDbx.SelectedItem);


            string pyt = "C:\\Users\\20065\\OneDrive\\Рабочий стол\\Golosha.txt";
            File.WriteAllText(pyt, sb.ToString());

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var salo = TovarTbx.SelectedItem as Products;
            ChekTbx.Items.Add(salo);

            BabyshkinCiiiska();
        }

        private void BabyshkinCiiiska()
        {
            decimal logovoBandita = 0;

            foreach (var i in ChekTbx.Items)
            {
                var pid = i as Products;
                logovoBandita += pid.Price;
            }

            Priced.Items.Clear();
            Priced.Items.Add(logovoBandita.ToString());
        }
    

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
