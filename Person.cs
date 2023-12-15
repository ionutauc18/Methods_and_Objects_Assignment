using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        // Creating a class called Person, giving it two properties, each of data type string
        // One called FirstName and the other one called LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Giving the class a void method called SayName() that takes no parameters and simply writes
        // the person's full name to the console in the format of: "Name: [Full Name]"
        public void SayName()
        {
            Console.WriteLine("Name: " +  this.FirstName + " " + this.LastName);
        }
    }
}
