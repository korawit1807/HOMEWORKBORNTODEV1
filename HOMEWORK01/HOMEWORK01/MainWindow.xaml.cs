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

namespace HOMEWORK01
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

        private void BTN1_Click(object sender, RoutedEventArgs e)
        {
             if (txtCome.Text != " " && txtOut.Text != " " && txtNeed.Text != " ")
            {
                int come = int.Parse(txtCome.Text);
                int Out = int.Parse(txtOut.Text);
                int need = int.Parse(txtNeed.Text);
                int cal = (need / (come - Out));
                txtSav.Text = cal.ToString();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
