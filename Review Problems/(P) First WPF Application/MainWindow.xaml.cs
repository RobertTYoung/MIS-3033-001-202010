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

namespace _P__First_WPF_Application
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

        private void btnCalculateAge_Click(object sender, RoutedEventArgs e)
        {
            DateTime Today = DateTime.Now;
            DateTime Birthday = Convert.ToDateTime(DatePickerDOB.SelectedDate);

            var Age = Today.Year - Birthday.Year;  
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            btnCalculateAge.Background = Color.Red;
        }
    }
}
