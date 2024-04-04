using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Joshua_Gonzales___IST331___Dog_Adoption
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        List<Dog> dogList = new List<Dog>();
        List<string> dogNames = new List<string>();
        List<string> dogTypes = new List<string>();
        List<string> dogColor = new List<string>();
        List<string> dogHasShot = new List<string>();
        List<string> dogGender = new List<string>();
        List<string> dogMonthsInKennel = new List<string>();
        List<int> dogAge = new List<int>();
        List<int> dogWeight = new List<int>();
        List<DateTime> dogBirthdays = new List<DateTime>();
        List<string> dogDesc = new List<string>();
        List<string> mt = new List<string>();
        List<string> dogImgPath = new List<string>();
        Dog dogToBeAdopted = new Dog();

        public MainWindow()
        {
            InitializeComponent();
            dogToBeAdopted.DogAdopted = false;
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


       /* Method for Deleting dog after adoption... Unfinished 
        * 
        * public void AdoptedCheck()
        {
            if (dogToBeAdopted.DogAdopted == true)
            {

                dogNames.Remove(dogToBeAdopted.DogName);
                dogAge.Remove(dogToBeAdopted.DogAge);
                dogBirthdays.Remove(dogToBeAdopted.DogBirthday);
                dogDesc.Remove(dogToBeAdopted.DogDescription);
                dogTypes.Remove(dogToBeAdopted.DogType);
                dogWeight.Remove(dogToBeAdopted.DogWeight);
                RefreshDog(dogNames);
            }




        }
        public void RefreshDog(List<string> list)
        {
            cbxDogSelection.ItemsSource = null;

            cbxDogSelection.ItemsSource = list;
        }*/


        private void InitalizeDogs()
        {

            String line;
            try
            {
                StreamReader reader = new StreamReader("DogInformation.txt");
                line = reader.ReadLine();
                while (line != null)
                {
                    dogNames.Add(line.Split('~')[0].Trim());
                    dogTypes.Add(line.Split('~')[1].Trim());
                    dogAge.Add(int.Parse(line.Split('~')[2].Trim()));
                    dogWeight.Add(int.Parse(line.Split('~')[3].Trim()));
                    dogBirthdays.Add(DateTime.Parse(line.Split('~')[4].Trim()));
                    dogDesc.Add(line.Split('~')[5].Trim());
                    dogColor.Add(line.Split('~')[6].Trim());
                    dogGender.Add(line.Split('~')[7].Trim());
                    dogHasShot.Add(line.Split('~')[8].Trim());
                    dogMonthsInKennel.Add(line.Split('~')[9]);
                    string imagePath = line.Split('~')[10];
                    dogImgPath.Add(imagePath);


                    line = reader.ReadLine();

                }
                cbxDogSelection.ItemsSource = dogNames;

                reader.Close();
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
            int indexed = cbxDogSelection.SelectedIndex;
            dogToBeAdopted.DogBirthday = dogBirthdays[indexed];
            dogToBeAdopted.DogName = dogNames[indexed];
            dogToBeAdopted.DogDescription = dogDesc[indexed];
            dogToBeAdopted.DogWeight = dogWeight[indexed];
            dogToBeAdopted.DogAge = dogAge[indexed];
            dogToBeAdopted.DogType = dogTypes[indexed];
            dogToBeAdopted.DogColor = dogColor[indexed];
            dogToBeAdopted.DogHasShots = dogHasShot[indexed];
            dogToBeAdopted.DogGender = dogGender[indexed];
            dogToBeAdopted.DogMonthsInKennel = dogMonthsInKennel[indexed];
            dogToBeAdopted.DogImage = dogImgPath[indexed].ToString();

            dogToBeAdopted.DogAdopted = false;
            Window1 window1 = new Window1(dogToBeAdopted);
            window1.ShowDialog();



        }

        private void cbxDogSelection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indexed = cbxDogSelection.SelectedIndex;


            txtDogName.Text = dogNames[indexed];
            txtDogAge.Text = dogAge[indexed].ToString() + " Years Old";
            txtDogWeight.Text = dogWeight[indexed].ToString()+ "lbs";
            txtDogDesc.Text = dogDesc[indexed].ToString();
            txtDogType.Text = dogTypes[indexed].ToString();
            txtDogColor.Text = dogColor[indexed].ToString();
            txtDogBirthday.Text = dogBirthdays[indexed].ToString();
            txtDogHasShots.Text = dogHasShot[indexed].ToString();
            txtDogMonthsInKennel.Text = dogMonthsInKennel[indexed].ToString() + " Months";
            txtDogGender.Text = dogGender[indexed].ToString();
            dogToBeAdopted.DogBirthday = dogBirthdays[indexed];
            dogToBeAdopted.DogName = dogNames[indexed];
            dogToBeAdopted.DogDescription = dogDesc[indexed];
            dogToBeAdopted.DogWeight = dogWeight[indexed];
            dogToBeAdopted.DogAge = dogAge[indexed];
            dogToBeAdopted.DogType = dogTypes[indexed];
            dogToBeAdopted.DogHasShots = dogHasShot[indexed];
            dogToBeAdopted.DogColor = dogColor[indexed];
            dogToBeAdopted.DogGender = dogGender[indexed];
            dogToBeAdopted.DogMonthsInKennel = dogMonthsInKennel[indexed];
            dogToBeAdopted.DogImage = dogImgPath[indexed];

            //imgDogProfile.Source = new BitmapImage(new Uri(dogImgPath[indexed]));


        }

        private void cbxDogSelection_GotFocus(object sender, RoutedEventArgs e)
        {
            //AdoptedCheck(); //For the Adoption deletion method (Unused and Unfinished)

            cbxDogSelection.ItemsSource = dogNames;


        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}