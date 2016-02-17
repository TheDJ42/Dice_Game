﻿using System;
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
        int totalScore = 0;
        int roundScore = 0;
        int score1 = 0;       
        int score2 = 0;       
        int score3 = 0;       
        int score4 = 0;
        int rolls_left_num = 5;
        int die0Val = 0;
        int die1Val = 0;
        int die2Val = 0;
        int die3Val = 0;


        public MainWindow()
        {
            
            InitializeComponent();
            die0Val = rnd.Next(1, 7);
            die1Val = rnd.Next(1, 7);
            die2Val = rnd.Next(1, 7);
            die3Val = rnd.Next(1, 7);
            die0.Content = die0Val.ToString();
            die1.Content = die1Val.ToString();
            die2.Content = die2Val.ToString();
            die3.Content = die3Val.ToString();


        }
        private void die1_Click(object sender, RoutedEventArgs e)
        {
            if (rolls_left_num > 0)

            {
                score1 = rnd.Next(1, 7);
                die1.Content = score1.ToString();
                rolls_left_num--;
                rollsLeft.Text = "Rolls Left this round: " + rolls_left_num.ToString();
            }


        }

        private void die2_Click(object sender, RoutedEventArgs e)
        {
            if (rolls_left_num > 0)

            {
                score2 = rnd.Next(1, 7);
                die2.Content = score2.ToString();
                rolls_left_num--;
                rollsLeft.Text = "Rolls Left this round: " + rolls_left_num.ToString();
            }

        }

        private void die3_Click(object sender, RoutedEventArgs e)
        {
            if (rolls_left_num > 0)

            {
                score3 = rnd.Next(1, 7);
                die3.Content = score3.ToString();
                rolls_left_num--;
                rollsLeft.Text = "Rolls Left this round: " + rolls_left_num.ToString();
            }
        }
        
      
        private void die0_Click(object sender, RoutedEventArgs e)
        {
            if (rolls_left_num > 0)

            {
                score4 = rnd.Next(1, 7);
                die0.Content = score4.ToString();
                rolls_left_num--;
                rollsLeft.Text = "Rolls Left this round: " + rolls_left_num.ToString();
            }
        }

        private void new_round_Click(object sender, RoutedEventArgs e)
        {
            // Update round value and end game after ten
            if (round >= 10)
            {
                roundNumber.Text = "Game Over";
                die0.IsEnabled = false;
                die1.IsEnabled = false;
                die2.IsEnabled = false;
                die3.IsEnabled = false;
                newRound.IsEnabled = false;
                
            }
            else
            {
                rolls_left_num = 5;
                rollsLeft.Text = "Rolls Left this round: " + rolls_left_num.ToString();
                round = round + 1;
                roundNumber.Text = "Round " + Convert.ToString(round);

                // Bank score (Add dice together)
                roundScore = score1 + score2 + score3 + score4;
                roundScore_text.Text = "Round Score: " + roundScore.ToString();
                totalScore = totalScore + roundScore;
                score.Text = "Total Score: " + totalScore.ToString();

                // Reroll all dice for next round
                die0Val = rnd.Next(1, 7);
                die1Val = rnd.Next(1, 7);
                die2Val = rnd.Next(1, 7);
                die3Val = rnd.Next(1, 7);
                die0.Content = die0Val.ToString();
                die1.Content = die1Val.ToString();
                die2.Content = die2Val.ToString();
                die3.Content = die3Val.ToString();

            }


        }

        
    }      
}
