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
using System.Windows.Shapes;

namespace Joshua_Gonzales___IST331___Dog_Adoption
{
    /// <summary>
    /// Interaction logic for AdoptionConf.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnExitAC_Click(object sender, RoutedEventArgs e)
        {
            wnAdoptionPage.Close();
            
        }

        private void btnAdopt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("has been Adopted!");
            wnAdoptionPage.Close();

        }
    }
}
