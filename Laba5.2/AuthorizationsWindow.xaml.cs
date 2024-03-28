using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для AuthorizationsWindow.xaml
    /// </summary>
    public partial class AuthorizationsWindow : Page
    {
        private FishingStoreEntities context = new FishingStoreEntities(); 

        public AuthorizationsWindow()
        {
            InitializeComponent();
            RoleTbx.ItemsSource = context.Roles.ToList();
        }

        // Добавление роли
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Roles c = new Roles();
            c.Role_Name = RoleDbx.Text.Trim();
            context.Roles.Add(c);

            context.SaveChanges();
            RoleTbx.ItemsSource = context.Roles.ToList();
        }

        // Удаление роли
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (RoleTbx.SelectedItem != null)
            {
                context.Roles.Remove(RoleTbx.SelectedItem as Roles);

                context.SaveChanges();
                RoleTbx.ItemsSource = context.Roles.ToList();
            }
        }

        // Изменение роли
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (RoleTbx.SelectedItem != null)
            {
                var selected = RoleTbx.SelectedItem as Roles;
                selected.Role_Name = RoleDbx.Text.Trim();

                context.SaveChanges();
                RoleTbx.ItemsSource = context.Roles.ToList();
            }
        }


    }
}