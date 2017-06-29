using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Frank";
            //int lengthOfName = firstName.Length;
            //Console.WriteLine(firstName);
            //Console.WriteLine(lengthOfName);

            //string myFaveQuote = "\"Life's a box of chocolates\" - Forrest Gump";
            //    Console.WriteLine(myFaveQuote);

            //string escapeString = "I want a tab after this line \t I want a new line without WriteLine \nHi";
            //string escapeSting2 = "I want to show a backslash here \\ Hey what's that noise? \a";
            //Console.WriteLine(escapeString);
            //Console.WriteLine(escapeSting2);

            //Console.WriteLine("User one, please type something");
            //string userOneInput = Console.ReadLine();
            //Console.WriteLine("User two, please type something");
            //string userTwoInput = Console.ReadLine();

            //if (userOneInput.Equals(userTwoInput))
            //{
            //    Console.WriteLine("User 2 is a copy cat!");
            //}
            //else
            //{
            //    Console.WriteLine("Way to be original!");
            //}   

            //string startOfSentence = "My best friend's name is ";
            //string endOfSentence = "Arsom.";
            //string fullSentence = startOfSentence + endOfSentence;

            //Console.WriteLine(fullSentence);

            //Console.WriteLine("My friend " + endOfSentence + " has a cute kid.");
            //Console.WriteLine("My friend {0} has a cute kid.", endOfSentence);

            //Console.WriteLine("This is a tab. \t \nThis is a backspace \\. \nAnd this is a bell sound \a.");

            ////in class house hopper example

            ////LENGTH OF FIRST NAME
            //string firstName = "Frank";
            //int lengthOfName = firstName.Length;
            //Console.WriteLine(firstName);
            //Console.WriteLine(lengthOfName);
            ////LENGTH OF LAST NAME
            //string lastName = "Nasseri";
            //int lengthOfLastName = lastName.Length;
            //Console.WriteLine(lastName);
            //Console.WriteLine(lengthOfLastName);
            ////COMPARING LENGTHS OF FIRST AND LAST
            //if (lengthOfName > lengthOfLastName)
            //{
            //    Console.WriteLine("First is longer");
            //}
            //else if (lengthOfName == lengthOfLastName)
            //{
            //    Console.WriteLine("Samsies");
            //}
            //else
            //{
            //    Console.WriteLine("Last must be longer");
            //}

            //COMPARING STRINGS FOR EQUALITY
            //create variables
            string firstName1 = "Steve";
            string firstName2 = "Dominic";
            
            if (firstName1.Equals(firstName2))
                {
                Console.WriteLine("The Names Are The Same");
                }
            else
            {
                Console.WriteLine("The Names Are Not The Same");
            }


        }
    }
}
