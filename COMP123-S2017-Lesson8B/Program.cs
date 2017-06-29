using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2017_Lesson8B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Person person = new Person("Tom", 25);
            person.Talks();

            Console.WriteLine("\n");

            Student student = new Student("Bobo", 20, "123456789A");
            student.Studies();
            student.Talks();

            Console.WriteLine("\n");

            DomesticStudent domestic = new DomesticStudent("Mary", 19, "123456788B");
            domestic.Talks();

            Console.WriteLine("\n");
        }
    }
}
