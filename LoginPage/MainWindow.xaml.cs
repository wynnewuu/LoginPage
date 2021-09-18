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
using System.Text.RegularExpressions;


namespace LoginPage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void okayButton_Click(object sender, RoutedEventArgs e)
        {
            string usernm = this.nameTextBox.Text;
            string passwd = this.passwordTextBox.Password;

            {
                if (usernm == "" || passwd == "")
                {
                    MessageBox.Show("Please fill in all the slots");
                }
                //Making sure password contain both letter and number and minimal 6 character
                //Make sure Password does not start with a number "char.IsDigit(Firstindex)"
                //Password can not contain special characters
                //Password cant not start with numeral value
                var input = this.passwordTextBox.Password;
                var hasChar = new Regex(@"^[a-zA-Z](?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$");


                if (!hasChar.IsMatch(input) || ((passwd.Contains("@") || passwd.Contains("#")
                            || passwd.Contains("!") || passwd.Contains("~")
                            || passwd.Contains("$") || passwd.Contains("%")
                            || passwd.Contains("^") || passwd.Contains("&")
                            || passwd.Contains("*") || passwd.Contains("(")
                            || passwd.Contains(")") || passwd.Contains("-")
                            || passwd.Contains("+") || passwd.Contains("/")
                            || passwd.Contains(":") || passwd.Contains(".")
                            || passwd.Contains(", ") || passwd.Contains("<")
                            || passwd.Contains(">") || passwd.Contains("?")
                            || passwd.Contains("|"))))
                {
                    MessageBox.Show("A valid password needs to have at least six characters with both letters and numbers.");
                }
                else
                {
                    if (usernm != "" && passwd != "")
                        MessageBox.Show("Thank you for providing the input, which will be verified.");
                }
            }
        }


        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}