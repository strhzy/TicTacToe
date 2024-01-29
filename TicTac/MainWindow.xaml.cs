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

namespace TicTac
{
    public partial class MainWindow : Window
    {
        string[] game = new string[9];
        public MainWindow()
        {
            InitializeComponent();
        }
        private void check_win()
        {
            if (game[0] == "x" && game[1] == "x" && game[2] == "x")
            {
                MessageBox.Show("Крестики победили");
                restart_();
            }
            else if(game[3] == "x" && game[4] == "x" && game[5] == "x")
            {
                MessageBox.Show("Крестики победили");
                restart_();
            }
            else if(game[6] == "x" && game[7] == "x" && game[8] == "x")
            {
                MessageBox.Show("Крестики победили");
                restart_();
            }
            else if(game[0] == "x" && game[4] == "x" && game[8] == "x")
            {
                MessageBox.Show("Крестики победили");
                restart_();
            }
            else if(game[6] == "x" && game[4] == "x" && game[2] == "x")
            {
                MessageBox.Show("Крестики победили");
                restart_();
            }
            else if(game[0] == "x" && game[3] == "x" && game[6] == "x")
            {
                MessageBox.Show("Крестики победили");
                restart_();
            }
            else if(game[1] == "x" && game[4] == "x" && game[7] == "x")
            {
                MessageBox.Show("Крестики победили");
                restart_();
            }
            else if(game[2] == "x" && game[5] == "x" && game[8] == "x")
            {
                MessageBox.Show("Крестики победили");
                restart_();
            }
            else if (game[0] == "o" && game[1] == "o" && game[2] == "o")
            {
                MessageBox.Show("Нолики победили");
                restart_();
            }
            else if (game[3] == "o" && game[4] == "o" && game[5] == "o")
            {
                MessageBox.Show("Нолики победили");
                restart_();
            }
            else if (game[6] == "o" && game[7] == "o" && game[8] == "o")
            {
                MessageBox.Show("Нолики победили");
                restart_();
            }
            else if (game[0] == "o" && game[4] == "o" && game[8] == "o")
            {
                MessageBox.Show("Нолики победили");
                restart_();
            }
            else if (game[6] == "o" && game[4] == "o" && game[2] == "o")
            {
                MessageBox.Show("Нолики победили");
                restart_();
            }
            else if (game[0] == "o" && game[3] == "o" && game[6] == "o")
            {
                MessageBox.Show("Нолики победили");
                restart_();
            }
            else if (game[1] == "o" && game[4] == "o" && game[7] == "o")
            {
                MessageBox.Show("Нолики победили");
                restart_();
            }
            else if (game[2] == "o" && game[5] == "o" && game[8] == "o")
            {
                MessageBox.Show("Нолики победили");
                restart_();
            }
            else
            {
                bot();
            }
        }
        private void bot()
        {
            bool chk = false;
            do
            {
                Random random = new Random();
                int x = random.Next(1, 9);
                if (x == 1 && btn1.IsEnabled == true)
                {
                    btn1.IsEnabled = false;
                    btn1.Content = "O";
                    game[0] = "o";
                    chk = true;
                }
                else if (x == 2 && btn2.IsEnabled == true)
                {
                    btn2.IsEnabled = false;
                    btn2.Content = "O";
                    game[1] = "o";
                    chk = true;
                }
                else if (x == 3 && btn3.IsEnabled == true)
                {
                    btn3.IsEnabled = false;
                    btn3.Content = "O";
                    game[3] = "o";
                    chk = true;
                }
                else if (x == 4 && btn4.IsEnabled == true)
                {
                    btn4.IsEnabled = false;
                    btn4.Content = "O";
                    game[4] = "o";
                    chk = true;
                }
                else if (x == 5 && btn5.IsEnabled == true)
                {
                    btn5.IsEnabled = false;
                    btn5.Content = "O";
                    game[5] = "o";
                    chk = true;
                }
                else if (x == 6 && btn6.IsEnabled == true)
                {
                    btn6.IsEnabled = false;
                    btn6.Content = "O";
                    game[6] = "o";
                    chk = true;
                }
                else if (x == 7 && btn7.IsEnabled == true)
                {
                    btn7.IsEnabled = false;
                    btn7.Content = "O";
                    game[7] = "o";
                    chk = true;
                }
                else if (x == 8 && btn8.IsEnabled == true)
                {
                    btn8.IsEnabled = false;
                    btn8.Content = "O";
                    game[8] = "o";
                    chk = true;
                }
                else if (x == 9 && btn9.IsEnabled == true)
                {
                    btn9.IsEnabled = false;
                    btn9.Content = "O";
                    game[9] = "o";
                    chk = true;
                }
            }
            while (chk == false);
        }
        private void btn_click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            switch((sender as Button).Name)
            {
                case "btn1":
                    game[0] = "x";
                    break;
                case "btn2":
                    game[1] = "x";
                    break;
                case "btn3":
                    game[2] = "x";
                    break;
                case "btn4":
                    game[3] = "x";
                    break;
                case "btn5":
                    game[4] = "x";
                    break;
                case "btn6":
                    game[5] = "x";
                    break;
                case "btn7":
                    game[6] = "x";
                    break;
                case "btn8":
                    game[7] = "x";
                    break;
                case "btn9":
                    game[8] = "x";
                    break;
            }
            check_win();
        }

        private void start_game(object sender, RoutedEventArgs e)
        {
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            btn9.IsEnabled = true;
            restart.IsEnabled = true;
            start.IsEnabled = false;
        }

        private void restart_game(object sender, RoutedEventArgs e)
        {
            restart_();
        }
        private void restart_()
        {
            btn1.IsEnabled = false;
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn5.IsEnabled = false;
            btn6.IsEnabled = false;
            btn7.IsEnabled = false;
            btn8.IsEnabled = false;
            btn9.IsEnabled = false;
            restart.IsEnabled = false;
            start.IsEnabled = true;
            btn1.Content = "";
            btn2.Content = "";
            btn3.Content = "";
            btn4.Content = "";
            btn5.Content = "";
            btn6.Content = "";
            btn7.Content = "";
            btn8.Content = "";
            btn9.Content = "";
            for(int i = 0; i < game.Length; i++)
            {
                game[i] = null;
            }
        }
    }
}