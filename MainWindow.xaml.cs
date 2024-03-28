using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Joshua_Gonzales___IST331___Dog_Adoption
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> dogList = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            InitalizeDogs();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you Sure?", "Do you want to Exit?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void InitalizeDogs()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("DogInformation.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    dogList.Add(line);
                    line = sr.ReadLine();
                }
                cbxDogSelection.ItemsSource = (dogList);
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing final Stock.");
            }
        }
        private void btnAdopt_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void cbxDogSelection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbxDogSelection_GotFocus(object sender, RoutedEventArgs e)
        {
            InitalizeDogs();
        }
    }
}