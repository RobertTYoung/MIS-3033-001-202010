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

namespace _P__WPF___Classes_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (txtManufacturer.Text != string.Empty && txtName.Text != string.Empty)
            {
                btnAddToListBox.IsEnabled = true;
            }
        }

        private void lstToys_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Toy selectedToy = (Toy)lstToys.SelectedItem;
        }

        private void btnAddToListBox_Click(object sender, RoutedEventArgs e)
        {
            new Toy = Toy();
            lstToys.Items.Add(Toy);

        }
    }
}
