using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            Console.Write("Enter your name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your lastname: ");
            string lastname = Console.ReadLine();
            string Full_name = myProgram.fullname(name, lastname);
            Console.WriteLine(Full_name);



            Console.ReadKey();

        }

       // Function:
        string fullname(string name, string lastname)
        {
            return "The fullname is " + name + " " + lastname;
        }

    }
}
