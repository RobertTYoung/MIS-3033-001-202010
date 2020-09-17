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

namespace _P__Participations
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

        private void btnExecute_Click(object sender, RoutedEventArgs e)
        {
            lstbxEntryInfo.Items.Add($"{txtName.Text}, {txtAddress1.Text}, {txtZipCode.Text}");
            //    lstbxEntryInfo.Items.Add(txtAddress);
            //    lstbxEntryInfo.Items.Add(txtZipCode);

            txtName.Text = string.Empty;
            txtAddress1.Text = string.Empty;
            txtZipCode.Text = string.Empty;


        }
    }
}
