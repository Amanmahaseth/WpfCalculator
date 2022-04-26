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

namespace Wpfcalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String operationPerformed = "";
        Double Calculatedvalue = 0;
        Double memory=0;
        //TO store operation clicked 
        bool isOperationPerformed = false;
        public MainWindow()
        {
            
        }

       

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Clear the initial zero 
            if ((Result.Text == "0") || (isOperationPerformed))
                Result.Text = String.Empty;

            //operation of numbers 
            
            Button button = (Button)sender;
            Result.Text = Result.Text + button.Content;
            isOperationPerformed=false;
            
           
        }

        

        private void button_operation(object sender, RoutedEventArgs e)
        {
            if(operationPerformed !="") button_equaltooperation(null,null);

            Button button = (Button)sender;
            //entered button content stored 
            operationPerformed = (String)button.Content;
            //calculated value stored
            Calculatedvalue = Double.Parse(Result.Text);
            isOperationPerformed = true;
        }

        private void button_equaltooperation(object sender, RoutedEventArgs e)
        {

          

            switch (operationPerformed)
            {
                case "+":
                    
                    Result.Text = (Calculatedvalue + Double.Parse(Result.Text)).ToString();
                    break;

                case "-":
                    Result.Text = (Calculatedvalue - Double.Parse(Result.Text)).ToString();
                    break;
                case "×":
                    Result.Text = (Calculatedvalue * Double.Parse(Result.Text)).ToString();
                    break;
                case "÷":
                    Result.Text = (Calculatedvalue / Double.Parse(Result.Text)).ToString();
                    break;
                
                case "=":
                    Result.Text = (Calculatedvalue = Double.Parse(Result.Text)).ToString();
                    break;
                
                default:
                    break;



            }
        }
        //for clear entries
        private void button_clearentries_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = "0";
        }
        //For clear
        private void button_clear_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = "0";
            Calculatedvalue=0;
            operationPerformed = "";
        }
        //For clearing one entries
        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            
            if (Result.Text.Length>1)
            {
                Result.Text = Result.Text.Substring(0,Result.Text.Length-1);
            }else
            {
                Result.Text = "0";
            }


        }
        //For 1/x
        private void button_divisionbyX_Click(object sender, RoutedEventArgs e)
        {
            
            Result.Text = Convert.ToDouble(1.0/Convert.ToDouble(Result.Text)).ToString();

            
        }
        //For percentage
        private void button_percentage_Click(object sender, RoutedEventArgs e)
        {
           
            Double a;
            a = Convert.ToDouble(Result.Text) / Convert.ToDouble(100);
            Result.Text = System.Convert.ToString(a);
        }
        //FOr square
        private void button_squareofx_Click(object sender, RoutedEventArgs e)
        {
            Double a;
            a = Convert.ToDouble(Result.Text) * Convert.ToDouble(Result.Text);
            Result.Text = System.Convert.ToString(a);
        }

        private void button_sqrtofx_Click(object sender, RoutedEventArgs e)
        {
            Double a;
            a = Convert.ToDouble(Result.Text);
            a = Math.Sqrt(a);
            Result.Text = System.Convert.ToString(a);
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.Modifiers == ModifierKeys.Shift && e.Key == Key.D5)
            {
                button_percentage_Click(button_percentage, null);
                e.Handled = true;
            }

            if (e.Key == Key.Escape)
            {
                button_clear_Click(null, null);
                e.Handled = true;
            }
            else if (e.Key == Key.Enter)
            {
                button_equaltooperation(null, null);
                e.Handled = true;
            }
            else if (e.Key == Key.Q)
            {
                button_squareofx_Click(null, null);
                e.Handled = true;
            }
            else if (e.Key == Key.R)
            {
                button_divisionbyX_Click(null, null);
                e.Handled = true;
            }
            else if (e.Key == Key.OemPlus)
            {
                button_operation(null, null);
                e.Handled = true;
            }
            //Numpad
            else if ((e.Key == Key.NumPad0) || (e.Key == Key.D0))
            {
                button_Click(button0, null);
                e.Handled = true;
            }
            else if ((e.Key == Key.NumPad1) || (e.Key == Key.D1))
            {
                button_Click(button1, null);
                e.Handled = true;
            }
            else if ((e.Key == Key.NumPad2) || (e.Key == Key.D2))
            {
                button_Click(button2, null);
                e.Handled = true;
            }
            else if ((e.Key == Key.NumPad3) || (e.Key == Key.D3))
            {
                button_Click(button3, null);
                e.Handled = true;
            }
            else if ((e.Key == Key.NumPad4) || (e.Key == Key.D4))
            {
                button_Click(button4, null);
                e.Handled = true;
            }
            else if ((e.Key == Key.NumPad5) || (e.Key == Key.D5))
            {
                button_Click(button5, null);
                e.Handled = true;
            }
            else if ((e.Key == Key.NumPad6) || (e.Key == Key.D6))
            {
                button_Click(button6, null);
                e.Handled = true;
            }
            else if ((e.Key == Key.NumPad7) || (e.Key == Key.D7))
            {
                button_Click(button7, null);
                e.Handled = true;
            }
            else if ((e.Key == Key.NumPad8) || (e.Key == Key.D8))
            {
                button_Click(button8, null);
                e.Handled = true;
            }
            else if ((e.Key == Key.NumPad9) || (e.Key == Key.D9))
            {
                button_Click(button9, null);
                e.Handled = true;
            }
            // Arithmetic operations
            else if (e.Key == Key.Add)
            {
                button_operation(button_addition, null);
                e.Handled = true;
            }
            else if (e.Key == Key.Subtract)
            {
                button_operation(button_subtract, null);
                e.Handled = true;
            }
            else if (e.Key == Key.Multiply)
            {
                button_operation(button_multiply, null);
                e.Handled = true;
            }
            else if (e.Key == Key.Divide)
            {
                button_operation(button_divide, null);
                e.Handled = true;
            }
            else if (e.Key == Key.Decimal)
            {
                button_operation(button_decimal, null);
                e.Handled = true;
            }
           
            else if (e.Key == Key.Back)
            {
                button_back_Click(button_back, null);
                e.Handled = true;
            }
            else if (e.Key == Key.X)
            {
                button_sqrtofx_Click(button_sqrtofx, null);
                e.Handled = true;
            }





        }
        
        //Memory Store
        private void button_ms_Click(object sender, RoutedEventArgs e)
        {
            memory = Double.Parse(Result.Text);
            isOperationPerformed = true;
            button_mc.IsEnabled = true;
            button_mr.IsEnabled = true;


        }
        //Memory clear
        private void button_mc_Click(object sender, RoutedEventArgs e)
        {
            memory = 0;
            button_mr.IsEnabled=false;
            button_mc.IsEnabled=false;
    
        }
        //Memory recall
        private void button_mr_Click(object sender, RoutedEventArgs e)
        {
            Result.Text= memory.ToString();
            isOperationPerformed = true;


        }
        //Memory +
        private void button_mplus_Click(object sender, RoutedEventArgs e)
        {
            memory+= Double.Parse(Result.Text);
            isOperationPerformed = true;
        }
        //Memory -
        private void button_mminus_Click(object sender, RoutedEventArgs e)
        {
            memory-= Double.Parse(Result.Text);
            isOperationPerformed = true;
        }
 

        private void button_mdropdown_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_plusminusoperation(object sender, RoutedEventArgs e)
        {
            Result.Text = (-Double.Parse(Result.Text)).ToString();
        }
        
    }
}
