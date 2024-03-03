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

namespace Lecture_Example___IComparble_JuanHernandez
{
    // Juan Hernandez
    // Lecture Example - IComparble
    // 02/23/24
    public partial class MainWindow : Window
    {

        List<Team> nfl = new List<Team>();
        List<Team> mlb = new List<Team>();

        public MainWindow()
        {
            InitializeComponent();
            PreloadNFL();
            DisplayTeams(nfl, lbTeams);

            rbAsc.IsChecked = true;

        }
        void PreloadNFL()
        {
            nfl.Add(new Team("Seahawks", "Seattle"));
            nfl.Add(new Team("Chiefs", "Kansas City"));
            nfl.Add(new Team("49ers", "San Francisco"));

        }

        public void DisplayTeams(List<Team> teamList, ListBox listBox)
        {
            listBox.Items.Clear();

            foreach (Team team in teamList)
            {
                listBox.Items.Add(team);
            }
        }

        private void btnCity_Click(object sender, RoutedEventArgs e)
        {
            nfl.Sort();
            DisplayNFL();
        }

        private void btnName_Click(object sender, RoutedEventArgs e)
        {
            Team_SortName.SortingOrder order = Team_SortName.SortingOrder.Ascending;

            if (!rbAsc.IsChecked.Value)
            {
                order = Team_SortName.SortingOrder.Descending;
            }

            Team_SortName sortName = new Team_SortName(order);
            nfl.Sort(sortName);
            DisplayNFL();
        }

        private void btnBudget_Click(object sender, RoutedEventArgs e)
        {
            Team_SortBudgeDsc budgetDsc = new Team_SortBudgeDsc();
            nfl.Sort(budgetDsc);
            DisplayNFL();
        }

        public void DisplayNFL()
        {
            DisplayTeams(nfl, lbTeams);
        }

        public void SortNFLExamples()
        {

            Team_SortBudgeDsc sortTeamDesc = new Team_SortBudgeDsc();

            Team_SortName sortedByName = new Team_SortName(Team_SortName.SortingOrder.Ascending);

            nfl.Sort(sortedByName);
        }

        public void DisplayMLB()
        {
            mlb.Add(new Team("Giants", "San Francisco"));
            mlb.Add(new Team("Mariners", "Seattle"));
            mlb.Add(new Team("Angels", "Los Angels"));
        }
    }
}