using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_assignments
{
    class Person
    {
        private string name;
        private DateTime birthDate;
        private enum enumGender { MALE, FEMALE };
        private enumGender gender;

        public Person(string name, DateTime birthDate, int genderNr)
        {
            this.name = name;
            this.birthDate = birthDate;
            switch (genderNr)
            {
                case 0:
                    Gender = enumGender.MALE;
                    break;
                case 1:
                    Gender = enumGender.FEMALE;
                    break;
            }
        }

        private enumGender Gender{
            set { this.gender = value; }
            get { return this.gender; }
        }

        public void toString()
        {
            Console.WriteLine(string.Format(
                "Good morning.\n My name is {0} and i was born in {1} and i'm a {2}", this.name, this.birthDate, this.gender));
        }
    }
}
