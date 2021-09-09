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

namespace LoginPage
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

        private void okayButton_Click(object sender, RoutedEventArgs e)
        {
            string usernm = this.nameTextBox.Text;
            string passwd = this.passwordTextBox.Password;
            if (usernm != "" && passwd != "")
                MessageBox.Show("Thank you for providing the input, which will be veerified.");
            else
                MessageBox.Show("Please fill in all the slots");
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

