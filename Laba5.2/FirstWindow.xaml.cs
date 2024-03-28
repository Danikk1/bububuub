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
    /// Логика взаимодействия для FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        //Роли
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Admin.Content = new AuthorizationsWindow();
        }



        //Данные для авторизации
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Admin.Content = new avtorizaciay();
        }

        //Сотрудники
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Admin.Content = new sotrudniki();
        }
    }
}
