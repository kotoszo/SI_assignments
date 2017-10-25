using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Béla = new Person("Béla", new DateTime(1972,02,20), 0);
            Béla.toString();
            Person Mari = new Person("Mari", new DateTime(1980, 03, 17), 1);
            Mari.toString();
            

        }
    }
}
