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
        List<string> dogNames = new List<string>();
        List<string> dogTypes = new List<string>();
        List<int> dogAge = new List<int>();
        List<int> dogWeight = new List<int>();
        List<DateOnly> dogBirthdays = new List<DateOnly>();
        List<string> dogDesc = new List<string>();
        List<BitmapSource> dogImgPath = new List<BitmapSource>();
        
        public MainWindow()
        {
            InitializeComponent();
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
                    dogNames.Add(line.Split(',')[0].Trim());
                    dogTypes.Add(line.Split(',')[1].Trim());
                    dogAge.Add(int.Parse(line.Split(',')[2].Trim()));
                    dogWeight.Add(int.Parse(line.Split(',')[3].Trim()));
                    dogBirthdays.Add(DateOnly.Parse(line.Split(',')[4].Trim()));
                    dogDesc.Add(line.Split(",")[5].Trim());

                    string imagePath = line.Split(",")[6].Trim();
                    BitmapImage imageSource = new BitmapImage();
                    imageSource.BeginInit();
                    imageSource.UriSource = new Uri(imagePath, UriKind.RelativeOrAbsolute);
                    imageSource.EndInit();
                    dogImgPath.Add(imageSource);




                    /*
                       for (int i = 0; i < 6; i++)
                       {
                       }
                       MessageBox.Show(dogInfo.ToString());
                    */

                    line = sr.ReadLine();

                }

                cbxDogSelection.ItemsSource = (dogNames);
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
            Window1 window1 = new Window1();
            window1.ShowDialog();


        }

        private void cbxDogSelection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indexed = cbxDogSelection.SelectedIndex;

            txtDogName.Text = dogNames[indexed];
            txtDogAge.Text = dogAge[indexed].ToString();
            txtDogWeight.Text = dogWeight[indexed].ToString();
            txtDogDesc.Text = dogDesc[indexed].ToString();
            txtDogType.Text = dogTypes[indexed].ToString();
            txtDogBirthday.Text = dogBirthdays[indexed].ToString();
            imgDogProfile.Source = dogImgPath[indexed];
        }

        private void cbxDogSelection_GotFocus(object sender, RoutedEventArgs e)
        {
            InitalizeDogs();

        }
    }
}