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
using Tournament_421_Marushkina_Anastasia.Bases;
using Tournament_421_Marushkina_Anastasia.Components;

namespace Tournament_421_Marushkina_Anastasia.Pages
{
    /// <summary>
    /// Логика взаимодействия для PlayerPage.xaml
    /// </summary>
    public partial class PlayerPage : Page
    {
        public PlayerPage()
        {
            InitializeComponent();
            Refresh();
        }
        public void Refresh()
        {
            IEnumerable<Users> users = App.db.Users
       .Where(user => user.RoleID != 1 && user.RoleID != 3);
            MyList.ItemsSource = users.ToList();
        }

        private void AddTournaments_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NextPage(new Registration());
        }
    }
}
