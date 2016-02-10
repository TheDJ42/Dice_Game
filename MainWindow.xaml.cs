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
        Random rnd = new Random();
        int round = 1;
        int total_score = 0;
        int round_score = 0;
        int score1 = 0;       
        int score2 = 0;       
        int score3 = 0;       
        int score4 = 0;
        int rolls_left_num = 5;     
        public MainWindow()
        {
            
            InitializeComponent();
        }
        private void die1_Click(object sender, RoutedEventArgs e)
        {
            score1 = rnd.Next(1, 7);
            die1.Content = score1.ToString();
            rolls_left_num--;
            rolls_left.Text = "Rolls Left this round: " + rolls_left_num.ToString();
        }

        private void die2_Click(object sender, RoutedEventArgs e)
        {
            score2 = rnd.Next(1, 7);
            die2.Content = score2.ToString();
            rolls_left_num--;
            rolls_left.Text = "Rolls Left this round: " + rolls_left_num.ToString();

        }

        private void die3_Click(object sender, RoutedEventArgs e)
        {
            score3 = rnd.Next(1, 7);
            die3.Content = score3.ToString();
            rolls_left_num--;
            rolls_left.Text = "Rolls Left this round: " + rolls_left_num.ToString();
        }
        
      
        private void die0_Click(object sender, RoutedEventArgs e)
        {
            score4 = rnd.Next(1, 7);
            die0.Content = score4.ToString();
            rolls_left_num--;
            rolls_left.Text = "Rolls Left this round: " + rolls_left_num.ToString();
        }

        private void new_round_Click(object sender, RoutedEventArgs e)
        {
            // Update round value and end game after ten
            if (round >= 10)
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
                round_score = score1 + score2 + score3 + score4;
                round_score_text.Text = "Round Score: " + round_score.ToString();
                total_score = total_score + round_score;
                Score.Text = "Total Score: " + total_score.ToString();
            }

                    // Reroll all dice for next round
        }

        
    }      
}
