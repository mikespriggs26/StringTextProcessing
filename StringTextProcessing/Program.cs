using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTextProcessing
{
    class Program
    {
        static void Main(string[] args)
        {

            /*//.length
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            int firstNameLength = firstName.Length;

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            int lastNameLength = lastName.Length;

            if (firstNameLength > lastNameLength)
            {
                Console.WriteLine("First is longer.");
            }
            else if (firstNameLength == lastNameLength)
            {
                Console.WriteLine("Samsis");
            }
            else
            {
                Console.WriteLine("Last must be longer.");
            }
            */
            /*//Escape characters

            Console.WriteLine("This is a tab \t. \nThis is a backspace\\ \nAnd this is a bell sound \a");

            */
            /*//Equality
            Console.WriteLine("Enter a name:");
            string name1 = Console.ReadLine();

            Console.WriteLine("Enter another name:");
            string name2 = Console.ReadLine();

            if (name1 == name2)
            {
                Console.WriteLine("The names are equal");
            }
            else
            {
                Console.WriteLine("The names are not equal");
            }

            if (string.Equals(name1, name2))
            {
                Console.WriteLine("The names are the same");
            }
            else
            {
                Console.WriteLine("The names are different");
            }
            */
            /*Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine(fullName);

            Console.WriteLine(string.Concat(firstName, lastName));
            */

            Console.WriteLine("Guess the type of pet(it's a cat):");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "cat")
            {
                Console.WriteLine("You guessed correctly");

            }
            else
            {
                Console.WriteLine("You guessed incorrectly");
            }









        }
    }
}
