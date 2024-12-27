using System;
using System.Collections;
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
            var Item = SortCb.SelectedItem;
            if (Item != null)
            {
                if (SortCb.SelectedIndex == 0)
                {
                    users =     users.OrderBy(x => x.NikName);
                }
                else if (SortCb.SelectedIndex == 1)
                {
                    users = users.OrderByDescending(x => x.NikName);
                }
                else
                {
                    users = users.OrderBy(x => x.NikName);
                }
            }

            if (SearchTb.Text != null)
            {
                users = users.Where(x => x.NikName.ToLower().Contains
                (SearchTb.Text.ToLower()) || x.NikName.ToLower().Contains(SearchTb.Text.ToLower()));
            }
            MyList.ItemsSource = users.ToList();
           
            
        }
        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }
        private void SortCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void AddTournaments_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NextPage(new Registration());
        }
    }
}
