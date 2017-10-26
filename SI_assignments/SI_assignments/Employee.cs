using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_assignments
{
    class Employee : Person
    {
        private string profession;
        private int salary;
        private Room room;

        public Employee(string name, DateTime birthDate, int genderNr, int salary, string profession) : base(name, birthDate, genderNr)
        {
            this.salary = salary;
            this.profession = profession;
            this.info = ToString();
            this.room = new Room();
        }
        
        public override String ToString()
        {
            string oldText = base.ToString();
            return string.Format("{0} My salary is around {1} and my profession is {2}", oldText, this.salary, this.profession);
        }
    }
}
