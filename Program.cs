using System;

namespace Deliverable_4___Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            {//Prompt user to enter valid name for entry and see it printed
                Console.WriteLine("Please enter your first and last name without numbers");
                try
                {
                    //enter the user input into the field
                    string Name = Console.ReadLine();

                    if (System.Text.RegularExpressions.Regex.IsMatch(Name, "[a-zA-Z]" + " " + "[a-zA-Z]"))
                    {
                        NameEntry(ref Name);
                    }

                    else
                    {
                        // ask the user to enter a name without numbers
                        Console.WriteLine("Please enter a valid entry that has your first and last name seperated by a space.");
                    }
                }
                //End of try section
                catch
                {
                    //If an error occurs. Inform user to enter a different value. 
                    Console.WriteLine("Please enter a valid entry that has your first and last name seperated by a space.");
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
