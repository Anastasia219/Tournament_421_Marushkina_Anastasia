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
    /// Логика взаимодействия для ListPAge.xaml
    /// </summary>
    public partial class ListPAge : Page
    {
        public ListPAge()
        {
            InitializeComponent();
            App.exitBtn.Visibility = Visibility.Visible;
            if (App.currentUser != null && App.currentUser.RoleID == 1)
                App.playerBtn.Visibility = Visibility.Visible;
            if (App.currentUser != null && App.currentUser.RoleID == 1)
                App.applicationBtn.Visibility = Visibility.Visible;

            App.rateBtn.Visibility = Visibility.Visible;
            App.tyrnirBtn.Visibility = Visibility.Visible;
            if (App.currentUser == null || App.currentUser.RoleID == 2)
                AddTournaments.Visibility = Visibility.Collapsed;
            Refresh();
        }

        public void Refresh()
        {
            IEnumerable<Tournament> tournaments = App.db.Tournament;
            MyList.ItemsSource = tournaments.ToList();
            
        }

        private void AddTournaments_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NextPage(new AddTournaments());
        }
    }
}
