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
using Tournament_421_Marushkina_Anastasia.Pages;

namespace Tournament_421_Marushkina_Anastasia
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Navigation.MainWindow = this;

            App.exitBtn = ExitBtn;
            App.tyrnirBtn = TyrnirBtn;
            App.rateBtn = RateBtn;
            App.playerBtn = PlayerBtn;
            App.applicationBtn = ApplicationBtn;
            MyFrame.Navigate(new Autorization());
        }
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Autorization());
            App.currentUser = null;
        }


        private void TyrnirBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new ListPAge());
        }

        private void RateBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new RatePage());
        }

        private void PlayerBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new PlayerPage());
        }

        private void ApplicationBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
