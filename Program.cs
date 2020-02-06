using System;

namespace Deliverable_4___Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            {//Prompt user to enter valid name for entry and see it printed
                Console.WriteLine("Please enter your name without numbers");
                try
                {
                    //creates variable for user name entry
                    string input = Console.ReadLine();
                    decimal numbername = decimal.Parse(input);
                    NameEntry(ref input);

                    //Not allowing entry of a number in the user's name.
                    if ((numbername >= 0) && (numbername <= 0))
                        Console.WriteLine("Please enter a valid entry");
                }
                //End of try section
                catch
                {
                    //If an error occurs. Inform user to enter a different value. 
                    Console.WriteLine("Please enter a valid entry.");
                }
                //end of catch section
            }
        }
        private static void NameEntry(ref string input)
        {
            //Display Hello (user name) !
            Console.WriteLine("Hello" + " " + input + "!");
        }
    }
}
