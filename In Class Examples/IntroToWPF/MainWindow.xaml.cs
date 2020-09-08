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

namespace IntroToWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtFavoriteColor.Text = string.Empty;
            txtName.Clear();
            btnClickMe.IsEnabled = false;

            //var x = txtFavoriteColor.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var response = MessageBox.Show("You clicked me!", "Enter title here", MessageBoxButton.YesNoCancel);
            string message = $"Hey {txtName.Text}, that's cool that your favorite color is {txtFavoriteColor.Text}.";
            MessageBox.Show(message, "Welcome to MIS 3033.");
        }

        private void txtFavoriteColor_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("You changed me!");
        }

        private bool ShouldWeEnableTheButton()
        {
            bool result = false;
            if (txtFavoriteColor.Text != string.Empty && txtName.Text != string.Empty)
            {
                result = true;
            }

            return result;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            btnClickMe.IsEnabled = ShouldWeEnableTheButton();
        }
    }
}
