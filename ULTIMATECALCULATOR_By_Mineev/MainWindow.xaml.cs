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

namespace ULTIMATECALCULATOR_By_Mineev
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            Ground.Text = string.Empty;
            UpperGround.Text = string.Empty;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Ground.Text += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Ground.Text += "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Ground.Text += "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Ground.Text += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            Ground.Text += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            Ground.Text += "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            Ground.Text += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            Ground.Text += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            Ground.Text += "9";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            Ground.Text += "0";
        }

        private void btnComma_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ground.Text))
            {
                return;
            }
            if (Ground.Text.Contains(','))
            {
                return;
            }
            Ground.Text += ",";
        }

       
        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            Ground.Text = string.Empty;
            UpperGround.Text = string.Empty;
        }

        //ACTIONS

        private void btnPercent_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ground.Text))
            {
                return;
            }
            if (!string.IsNullOrWhiteSpace(Ground.Text) && !string.IsNullOrWhiteSpace(UpperGround.Text))
            {
                string textUP = UpperGround.Text;
                int ind = textUP.Length - 3;
                textUP = textUP.Remove(ind);

                double up = Convert.ToDouble(textUP);
                double down = Convert.ToDouble(Ground.Text);
                double result = Calc.Percent(up, down);
                UpperGround.Text = string.Empty;
                Ground.Text = result.ToString();
            }
            UpperGround.Text = Ground.Text + " % ";
            Ground.Text = string.Empty;


        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ground.Text))
            {
                return;
            }
            if (!string.IsNullOrWhiteSpace(Ground.Text) && !string.IsNullOrWhiteSpace(UpperGround.Text))
            {
                string textUP = UpperGround.Text;
                int ind = textUP.Length - 3;
                textUP = textUP.Remove(ind);

                double up = Convert.ToDouble(textUP);
                double down = Convert.ToDouble(Ground.Text);
                double result = Calc.Div(up, down);
                UpperGround.Text = string.Empty;
                Ground.Text = result.ToString();
            }
            UpperGround.Text = Ground.Text + " / ";
            Ground.Text = string.Empty;
        }

        private void btnMulti_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ground.Text))
            {
                return;
            }
            if (!string.IsNullOrWhiteSpace(Ground.Text) && !string.IsNullOrWhiteSpace(UpperGround.Text))
            {
                string textUP = UpperGround.Text;
                int ind = textUP.Length - 3;
                textUP = textUP.Remove(ind);

                double up = Convert.ToDouble(textUP);
                double down = Convert.ToDouble(Ground.Text);
                double result = Calc.Mult(up, down);
                UpperGround.Text = string.Empty;
                Ground.Text = result.ToString();
            }
            UpperGround.Text = Ground.Text + " * ";
            Ground.Text = string.Empty;
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ground.Text))
            {
                return;
            }
            if (!string.IsNullOrWhiteSpace(Ground.Text) && !string.IsNullOrWhiteSpace(UpperGround.Text))
            {
                string textUP = UpperGround.Text;
                int ind = textUP.Length - 3;
                textUP = textUP.Remove(ind);

                double up = Convert.ToDouble(textUP);
                double down = Convert.ToDouble(Ground.Text);
                double result = Calc.Sub(up, down);
                UpperGround.Text = string.Empty;
                Ground.Text = result.ToString();
            }
            UpperGround.Text = Ground.Text + " - ";
            Ground.Text = string.Empty;
        }

        ///
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ground.Text))
            {
                return;
            }
            if(!string.IsNullOrWhiteSpace(Ground.Text) && !string.IsNullOrWhiteSpace(UpperGround.Text))
            {
                string textUP = UpperGround.Text;
                int ind = textUP.Length - 3;
                textUP = textUP.Remove(ind);

                double up = Convert.ToDouble(textUP);
                double down = Convert.ToDouble(Ground.Text);
                double result = Calc.Sum(up, down);
                UpperGround.Text = string.Empty;
                Ground.Text = result.ToString();
            }
           
            UpperGround.Text = Ground.Text + " + ";
            Ground.Text = string.Empty;
        }

        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            //вывод в ответ с верхней строки
            if (!string.IsNullOrWhiteSpace(UpperGround.Text) && string.IsNullOrWhiteSpace(Ground.Text))
            {
                string _textUP = UpperGround.Text;
                int _ind = _textUP.Length - 3;
                _textUP = _textUP.Remove(_ind);

                Ground.Text = _textUP;
                return;
            }
            if (string.IsNullOrWhiteSpace(Ground.Text))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(UpperGround.Text))
            {
                return;
            }
           

           

            // считывание текста
            string textUP = UpperGround.Text;
            //проверка на оператора 
            double shit = CountAll.Check(textUP);
            //обрезка символа опратора
            int ind = textUP.Length - 3;
            textUP = textUP.Remove(ind);
            //считывание переменных
            double up = Convert.ToDouble(textUP);
            double down = Convert.ToDouble(Ground.Text);

          
            //решение
            double res = CountAll.CAL(shit, up, down);
            //вывод
            UpperGround.Text = string.Empty;
            Ground.Text = res.ToString();

           

        }



        private void btnC1_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Ground.Text))
            {
                return;
            }

            string text = Ground.Text;
            int ind = text.Length - 1;
            text = text.Remove(ind);
            Ground.Text = text;
        }
    }
}
