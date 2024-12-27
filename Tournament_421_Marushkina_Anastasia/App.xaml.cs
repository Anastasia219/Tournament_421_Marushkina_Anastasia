using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Tournament_421_Marushkina_Anastasia.Bases;

namespace Tournament_421_Marushkina_Anastasia
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static TournamentDB_421_Marushkina_AnastasiaEntities db = new TournamentDB_421_Marushkina_AnastasiaEntities();
        public static Users currentUser;
        public static Button exitBtn;

        public static Button tyrnirBtn;
        public static Button rateBtn;
        public static Button playerBtn;
        public static Button applicationBtn;

    }
}
