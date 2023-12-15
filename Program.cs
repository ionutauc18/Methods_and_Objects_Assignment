using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instatiating and initializing an Employee object with 
            // the first name "Ionut" and last name "Catana"
            Employee sample = new Employee() { FirstName = "Ionut", LastName = "Catana" };
            // Calling the superclass method SayName() on the Employee object
            sample.SayName();
            Console.ReadLine();
        }
    }
}
