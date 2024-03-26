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
            this.dogBirthday = DateTime.Now.Date;
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
             
        }


    }
}
