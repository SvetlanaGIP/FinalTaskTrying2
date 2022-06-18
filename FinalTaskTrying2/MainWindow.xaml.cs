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

namespace FinalTaskTrying2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            txtBox.Text += b.Content.ToString();
        }

        private void Result_click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception exc)
            {
                txtBox.Text = "Error!";
            }
        }

        private void result()
        {
            String op;
            int iOp = 0;
            if (txtBox.Text.Contains("+"))
            {
                iOp = txtBox.Text.IndexOf("+");
            }
            else if (txtBox.Text.Contains("-"))
            {
                iOp = txtBox.Text.IndexOf("-");
            }
            else if (txtBox.Text.Contains("*"))
            {
                iOp = txtBox.Text.IndexOf("*");
            }
            else if (txtBox.Text.Contains("/"))
            {
                iOp = txtBox.Text.IndexOf("/");
            }
            else
            {
                //error    
            }

            op = txtBox.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(txtBox.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(txtBox.Text.Substring(iOp + 1, txtBox.Text.Length - iOp - 1));

            if (op == "+")
            {
                txtBox.Text += "=" + (op1 + op2);
            }
            else if (op == "-")
            {
                txtBox.Text += "=" + (op1 - op2);
            }
            else if (op == "*")
            {
                txtBox.Text += "=" + (op1 * op2);
            }
            else
            {
                txtBox.Text += "=" + (op1 / op2);
            }
        }
        private void Off_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = "";
        }

        private void bcsps_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 1);
            }
        }

        private void Pow_Click(object sender, RoutedEventArgs e)
        {
            float b;
            b = float.Parse(txtBox.Text)*float.Parse(txtBox.Text); //XD
            txtBox.Text = b.ToString();
        }

        private void Fract_Click(object sender, RoutedEventArgs e)
        {
            float b;
            b = 1 / float.Parse(txtBox.Text); 
            txtBox.Text = b.ToString();
        }

        
    }

}
