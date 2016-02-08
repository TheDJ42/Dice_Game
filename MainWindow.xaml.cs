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

namespace Dice_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random RNG =
        int round = 1;
        int score = 0;
        int round_score = 0;
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void new_round_Click(object sender, RoutedEventArgs e)
        {
            // Update round value and end game after ten
            if (round > 10)
            {
                round_number.Text = "Game Over";
                die0.IsEnabled = false;
                die1.IsEnabled = false;
                die2.IsEnabled = false;
                die3.IsEnabled = false;
                new_round.IsEnabled = false;

            }
            else
            {
                round = round + 1;
                round_number.Text = "Round " + Convert.ToString(round);
                
                // Bank score (Add dice together)
                //score = score = round_score;
            }





            // Reroll all dice for next round
        }
    }
}
