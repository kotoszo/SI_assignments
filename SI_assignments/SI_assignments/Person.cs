using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_assignments
{
    public enum EnumGender { MALE, FEMALE, MONKEY };

    public class Person
    {
        private string name;
        private DateTime birthDate;
        
        private EnumGender gender;
        protected string info;

        public Person(string name, DateTime birthDate, int genderNr)
        {
            ValidateName(name);
            this.name = name;
            this.birthDate = birthDate;
            Gender = GenderSelecter(genderNr);
            info = ToString();
        }

        private EnumGender GenderSelecter(int genderNr)
        {
            switch (genderNr)
            {
                case 0:
                    return EnumGender.MALE;
                case 1:
                    return EnumGender.FEMALE;
                default:
                    return EnumGender.MONKEY;
            }
        }

        public EnumGender Gender{
            set { this.gender = value; }
            get { return this.gender; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        
        public override String ToString()
        {
            return string.Format(
                "Good morning.\n My name is {0} and i was born in {1} and i'm a {2}", this.name, this.birthDate, this.gender);
        }

        private string Info
        {
            get { return this.info; }
            set { this.info = value; }
        }

        public void ShowInfo()
        {   
            Console.WriteLine(Info);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
      
        private void ValidateName(string name)
        {
            if (name == null)
            {
                throw new ArgumentException("Parameter is null", "name");
            }
            if (name.Equals(""))
            {
                throw new ArgumentException("Parameter is not valid", "name");
            }
        }

        private void ValidateGenderNr(int genderNr)
        {
            if (genderNr < 0 || genderNr > 1 || genderNr == null)
            {
                throw new ArgumentOutOfRangeException("Parameter is not valid", "genderNr");
            }
        }
    }
}
