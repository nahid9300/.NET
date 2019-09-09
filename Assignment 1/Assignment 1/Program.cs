using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            int age;
            String address;
            int contact;
            Console.WriteLine("Enter Your Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your Age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Address");
            address = Console.ReadLine();
            Console.WriteLine("Enter Your Contact number");
            contact = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your given information-\n");
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Contact number: " + contact);

        }
    }
}
