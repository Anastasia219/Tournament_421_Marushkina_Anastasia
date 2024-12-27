using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Tournament_421_Marushkina_Anastasia.Components
{
    public static class Navigation
    {
        public static MainWindow MainWindow { get; set; }
        public static void NextPage(Page page)
        {
            MainWindow.MyFrame.Navigate(page);
        }

        public static void GoBack()
        {
            if (MainWindow.MyFrame.CanGoBack)
                MainWindow.MyFrame.GoBack();
        }
    }
}
