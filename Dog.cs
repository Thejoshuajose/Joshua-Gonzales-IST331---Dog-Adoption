using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joshua_Gonzales___IST331___Dog_Adoption
{
    class Dog
    {
        protected DateTime dogBirthday;
        protected string dogName;
        protected string dogType;
        protected string dogDescription;
        protected int dogAge;
        protected int dogWeight;
        public Dog() 
        {
            this.dogType = "A generic breed";
            this.dogDescription = "A generic Dog";
            this.dogAge = 1;
            this.dogWeight = 20;
            this.dogBirthday = DateTime.MaxValue;
            this.dogName = "Dog";
        }

        public Dog(DateTime dogBirthday,string dogName, string dogType, string dogDescription, int dogAge, int dogWeight)
        {
            this.dogType = dogType;
            this.dogDescription = dogDescription;
            this.dogAge = dogAge;
            this.dogWeight = dogWeight;
            this.dogBirthday = dogBirthday;
            this.dogName = dogName;
        }

        public Dog(DateTime dogBirthday, string dogName, string dogType,string dogDescription,int dogWeight)
        {
            this.dogBirthday = dogBirthday;
            this.dogName = dogName;
            this.dogDescription = dogDescription;
            this.dogType = dogType;
            this.dogWeight = dogWeight;
            this.dogAge =  (DateTime.Now - dogBirthday).Days/365 ;
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


    }
}
