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
            Béla.ShowInfo();
            Person Mari = new Person("Mari", new DateTime(1980, 03, 17), 1);
            Mari.ShowInfo();

            Console.Write(Environment.NewLine);

            Employee Worker1 = new Employee("Melós Józsi", new DateTime(1966, 08, 22), 0, 1200, "musician");
            Worker1.ShowInfo();
            Employee Worker2 = new Employee("Dolgos Gizi", new DateTime(1924, 09, 11), 1, 1100, "grandma");
            Worker2.ShowInfo();

        }
    }
}
