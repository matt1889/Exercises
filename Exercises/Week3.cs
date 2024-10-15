using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Week3 //class
    {
        public static void Exercise1() //method
        {
            Console.WriteLine("Matt Colley"); //WriteLine() prints text in console
        }
        public static void Exercise3() //method
        {
            Console.WriteLine("Matt" + "Colley"); //the use of a + combines two variables (strings)
        }

        public static void Exercise4() //method
        {
            Console.Write("Enter your full name: "); //this comand displays text in the console
            Console.WriteLine(Console.ReadLine()); //this types out the text inputted from the user
        }
        public static void Exercise6()
        {
            Console.WriteLine("Write the name of your dog: ");

            string name = Console.ReadLine(); //using a string declares the text inputted by the user as a variable in this case "name"
            Console.WriteLine("the name of your dog is : "); Console.WriteLine(name);
        }

        public static void Exercise7()
        {
            Console.WriteLine("write your first name : ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Write your second name : ");
            string lastName = Console.ReadLine();

            Console.WriteLine(firstName + " " + lastName); //using a + combines both strings while " " creates a space between them
        }

        public static void Exercise8()
        {
            Console.WriteLine("Input a temperature in celcius: ");
            int C = Convert.ToInt32(Console.ReadLine());//this assigns the input to a variable in this case int

            double fahrenheit; //a double is a data type that stores fractional numbers

            double celsius = C;
            Console.WriteLine("Celsius: " + celsius);

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);

            Console.ReadLine();
        }

        public static void Exercise9()
        {
            Console.WriteLine("Input a temperature in celcius: ");
            int C = Convert.ToInt32(Console.ReadLine());//this assigns the input to a variable in this case int

            while (C < -100) 
            {
                double fahrenheit;

                double celsius = C;
                Console.WriteLine("Celsius: " + celsius);

                fahrenheit = (celsius * 9) / 5 + 32;
                Console.WriteLine("Fahrenheit: " + fahrenheit);

                Console.ReadLine();
            }
            if (C < -100)
            {
                Console.Write("Input is out of range!");
            }
        }
        public static void Exercise10()
        {

        }
    }
}


