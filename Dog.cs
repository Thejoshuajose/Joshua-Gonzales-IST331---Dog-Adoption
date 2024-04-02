using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Joshua_Gonzales___IST331___Dog_Adoption
{
    public class Dog
    {
        protected DateTime dogBirthday;
        protected string dogName;
        protected string dogType;
        protected string dogDescription;
        protected string dogColor;
        protected int dogAge;
        protected string dogGender;
        protected string dogMonthsInKennel;
        protected int dogWeight;
        protected bool dogAdopted = false;
        protected string dogHasShots;
        protected string dogImage;


        public Dog() 
        {
            this.dogType = "A generic breed";
            this.dogDescription = "A generic Dog";
            this.dogAge = 1;
            this.dogWeight = 20;
            this.dogBirthday = DateTime.MaxValue;
            this.dogName = "Dog";
            this.dogColor = "Black";
            this.dogGender = "Male";
            this.dogMonthsInKennel = "Three";
            this.dogImage = "/DogPictures/FidoGermanShephard";
        }

        public Dog(DateTime dogBirthday,string dogName, string dogType, string dogDescription, int dogAge, int dogWeight, string dogColor,string dogGender, string dogMonthsInKennel, string dogImage)
        {
            this.dogType = dogType;
            this.dogDescription = dogDescription;
            this.dogAge = dogAge;
            this.dogWeight = dogWeight;
            this.dogBirthday = dogBirthday;
            this.dogName = dogName;
            this.dogColor = dogColor;
            this.dogGender = dogGender;
            this.dogMonthsInKennel = dogMonthsInKennel;
            this.dogImage = dogImage;
        }

        
        public DateTime DogBirthday
        {
            get { return dogBirthday; }
            set { dogBirthday = value; }
        }

        public string DogName
        {
            get { return dogName; }
            set { dogName = value; }
        }

        public string DogType
        {
            get { return dogType; }
            set { dogType = value; }
        }

        public string DogDescription
        {
            get { return dogDescription; }
            set { dogDescription = value; }
        }

        public int DogAge
        {
            get { return dogAge; }
            set { dogAge = value; }
        }

        public int DogWeight
        {
            get { return dogWeight; }
            set { dogWeight = value; }
        }
        public bool DogAdopted
        {
            get { return dogAdopted; }
            set { dogAdopted = value; }
        }
        public string DogColor
        {
            get { return dogColor; }
            set { dogColor = value; }
        }
        public string DogHasShots
        {
            get { return dogHasShots; }
            set { dogHasShots = value; }
        }
        public string DogGender
        {
            get { return dogGender; }
            set { dogGender = value; }
        }

        public string DogMonthsInKennel
        {
            get { return dogMonthsInKennel; }
            set { dogMonthsInKennel = value; }
        }
        public string DogImage
        {
            get { return dogImage; }
            set { dogImage = value; }
        }
    }
}
