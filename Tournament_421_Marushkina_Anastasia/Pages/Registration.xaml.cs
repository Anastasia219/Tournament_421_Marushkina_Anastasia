using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public static List<Role> roles;
        public static List<Teams> teams;
        public Registration()
        {
            InitializeComponent();
            Refresh();
            App.exitBtn.Visibility = Visibility.Hidden;
            

           

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigation.GoBack();
        }

        public void Refresh()
        {
            if (ApplicationCb.SelectedItem != null)
            {
                
                string selectedOption = (ApplicationCb.SelectedItem as ComboBoxItem).Content.ToString();

                if (selectedOption == "Команда")
                {
                    TeamSp.Visibility = Visibility.Visible;
                    RoleSp.Visibility = Visibility.Visible;
                }
                else
                {
                    TeamSp.Visibility = Visibility.Collapsed;
                    RoleSp.Visibility = Visibility.Collapsed;
                }
            }

        }
        private void ApplicationCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {    Users user = new Users();
            if (NikNameTb.Text == "")
            {
                MessageBox.Show("Вы неправильно ввели никнейм!");
                return;
            }
            
            var teams = TeamComboBox.SelectedItem as Teams;
            var role = RoleCb.SelectedItem as Role;
            if (LoginTb.Text == "" || ParolTb.Password == "" || NikNameTb.Text == "" || PhoneTb.Text == "" )
            {
                MessageBox.Show("Вы заполнили не все данные", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
              
                        user.Password = ParolTb.Password.Trim();
                user.NikName = NikNameTb.Text.Trim();
                        user.Phone = PhoneTb.Text.Trim();
                        user.Login = LoginTb.Text.Trim();
                   

                        App.db.Users.Add(user);
                        App.db.SaveChanges();
                        MessageBox.Show("Данные сохранены", "", MessageBoxButton.OK, MessageBoxImage.Information);
                        NavigationService.Navigate(new Autorization());
                    }
                }
              
                    
                }

      
    }

