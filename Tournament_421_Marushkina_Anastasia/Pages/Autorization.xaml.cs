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
using Tournament_421_Marushkina_Anastasia.Components;

namespace Tournament_421_Marushkina_Anastasia.Pages
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Page
    {
        public Autorization()
        {
            InitializeComponent();
            App.exitBtn.Visibility = Visibility.Hidden;
            App.playerBtn.Visibility = Visibility.Collapsed;
            App.applicationBtn.Visibility = Visibility.Collapsed;
            App.rateBtn.Visibility = Visibility.Hidden;
            App.tyrnirBtn.Visibility = Visibility.Hidden;
            
        }
        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text;
            if (PassTb.Password == "" || LoginTb.Text =="")
            {
                MessageBox.Show("Вы не ввели логин или пароль");
                return;
            }
            var loginUser = App.db.Users.FirstOrDefault(x => x.Login == login && x.Password == PassTb.Password);

            if (loginUser != null)
            {
               App.currentUser = loginUser;
               Navigation.NextPage(new ListPAge());
            }
            else
                MessageBox.Show("Пользователь не найден.");
        }
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Registration());
        }

        private void ZritelBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListPAge());
        }
    }
}
