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
using Laba5._2.DataSet1TableAdapters;

namespace Laba5._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AuthorizationsTableAdapter adapter = new AuthorizationsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var allLogin = adapter.GetData().Rows;
            for (int i = 0; i < allLogin.Count; i++)
            {
                if (allLogin[i][2].ToString() == LoginTbx.Text && allLogin[i][3].ToString() == PasswordTbx.Password)
                {
                    int roleId = (int)allLogin[i][4];
                    switch (roleId)
                    {
                        case 1:
                            FirstWindow role = new FirstWindow();
                            role.Show(); break;
                        case 2:
                            SecondWindow second = new SecondWindow();
                            second.Show(); break;
                        case 4:
                            ChequeWindow chek = new ChequeWindow();
                            chek.Show(); break;
                    }
                }
            }

        }
    }
}



    

