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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba5._2
{
    /// <summary>
    /// Логика взаимодействия для sotrudniki.xaml
    /// </summary>
    public partial class sotrudniki : Page
    {
        private FishingStoreEntities context = new FishingStoreEntities();

        public sotrudniki()
        {
            InitializeComponent();
            LoadEmployees(); 
            LoadRoles(); 
        }

        private void LoadEmployees()
        {
            RoleTbx.ItemsSource = context.Employees.ToList();
        }

        private void LoadRoles()
        {
            RoleDbx.ItemsSource = context.Roles.ToList();
        }

        // Добавление сотрудника
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Employees employee = new Employees();
            employee.First_Name = FirstNameDbx.Text;
            employee.Last_Name = LastNameDbx.Text;
            employee.Role_ID = (int)((RoleDbx.SelectedItem as Roles)?.Role_ID);
            employee.Position = "Рабочая должность"; 


            context.Employees.Add(employee);
            context.SaveChanges();
            LoadEmployees(); 

        }

        // Удаление сотрудника
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (RoleTbx.SelectedItem != null)
            {
                var employee = RoleTbx.SelectedItem as Employees;
                context.Employees.Remove(employee);
                context.SaveChanges();
                LoadEmployees(); 
            }
        }

        // Изменение сотрудника
        private void Button_Click_1(object sender, object e)
        {
            if (RoleTbx.SelectedItem != null && RoleDbx.SelectedItem != null)
            {
                var employee = RoleTbx.SelectedItem as Employees;
                employee.First_Name = FirstNameDbx.Text.Trim();
                employee.Last_Name = LastNameDbx.Text.Trim();
                employee.Role_ID = (int)((RoleDbx.SelectedItem as Roles)?.Role_ID);
                context.SaveChanges();
                LoadEmployees(); 
            }
        }
    }
}

