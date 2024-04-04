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
        private Dog dogAdopted;
        public Window1(Dog dogToBeAdopted)
        {
            InitializeComponent();
            dogAdopted = dogToBeAdopted;
            UpdateDog();

        }

        private void btnExitAC_Click(object sender, RoutedEventArgs e)
        {
            wnAdoptionPage.Close();
            
        }

        private void UpdateDog()
        {
            txtDogDescAC.Text = dogAdopted.DogDescription;
            txtDogAgeAC.Text = dogAdopted.DogAge.ToString();
            txtDogBirthdayAC.Text = dogAdopted.DogBirthday.ToString();
            txtDogNameAC.Text = dogAdopted.DogName;
            txtDogTypeAC.Text = dogAdopted.DogType;
            txtDogWeightAC.Text = dogAdopted.DogWeight.ToString();
            txtDogHasShotsAC.Text = dogAdopted.DogHasShots.ToString();
            txtDogColorAC.Text = dogAdopted.DogColor.ToString();
            txtDogMonthsInKennelAC.Text = dogAdopted.DogMonthsInKennel.ToString();
            txtDogGenderAC.Text = dogAdopted.DogGender.ToString();
            //imgDogProfileAC.Source = new BitmapImage(new Uri(dogAdopted.DogImage));


        }

        private void btnAdopt_Click(object sender, RoutedEventArgs e)
        {
            dogAdopted.DogAdopted = true;
            
            MessageBox.Show(dogAdopted.DogName + " has been Adopted!");

            wnAdoptionPage.Close();
            
        }
    }
}
