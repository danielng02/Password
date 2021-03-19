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
using System.ComponentModel;

namespace Password
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        bool validPassword = false;
        private void Window_Closing_1(object sender, CancelEventArgs e)
        {
            if(!validPassword)
                e.Cancel = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Heslo.Text.Length >= 6 && Heslo.Text.Any(char.IsDigit))
            {
                validPassword = true;
                MessageBox.Show("Congratulations .Now you can close this application.");
            }

            else if (Heslo.Text.Length < 6 && Heslo.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Password is too short. Must contain at least 6 characters.");
                validPassword = false;
            }

            else if (Heslo.Text.Length >= 6 && !Heslo.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Password must contain at least one number.");
                validPassword = false;
            }
            else
            {
                MessageBox.Show("Password must contain at least 6 characters and one of them must be a number");
                validPassword = false;
            }    
        }

    }
}
