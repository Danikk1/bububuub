using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba5._2
{
    /// <summary>
    /// Логика взаимодействия для avtorizaciay.xaml
    /// </summary>
    public partial class avtorizaciay : Page
    {
        private FishingStoreEntities context = new FishingStoreEntities();

        public avtorizaciay()
        {
            InitializeComponent();
            LoadEmployees(); // Загрузка ролей в комбо-бокс
        }

        private void LoadEmployees()
        {
            throw new NotImplementedException();
        }

        private void LoadRoles()
        {
           
        }

        //Добавление
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Authorizations authorization = new Authorizations();
            authorization.Username = UsernameDbx.Text;
            authorization.Password = PasswordDbx.Password;
            authorization.Employee_ID = (int)((EmployeeDbx.SelectedItem as Employees)?.Role_ID);

         
            context.SaveChanges();
            LoadEmployees(); // Обновление списка авторизаций
        }
        //Изменение
        private void Button_Click_1(object sender, object e)
        {
            if (EmployeesTbx.SelectedItem != null && EmployeeDbx.SelectedItem != null)
            {
                var authorization = EmployeesTbx.SelectedItem as Authorizations;
                authorization.Username = UsernameDbx.Text.Trim();
                authorization.Password = PasswordDbx.Password.Trim();
                authorization.Employee_ID = (int)((EmployeeDbx.SelectedItem as Roles)?.Role_ID);
                context.SaveChanges();
                LoadEmployees(); // Обновление списка авторизаций
            }


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (EmployeesTbx.SelectedItem != null)
            {
                var authorization = EmployeesTbx.SelectedItem as Authorizations;
                
                context.SaveChanges();
                LoadEmployees(); // Обновление списка авторизаций
            }
        }

    }
}
