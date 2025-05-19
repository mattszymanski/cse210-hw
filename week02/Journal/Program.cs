using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {   string choice = "0";
        while (choice != "5")
        {

            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit \nWhat would you like to do?");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                
            }
            else if (choice == "2")
            {

            }
            else if (choice == "3")
            {

            }
            else if (choice == "4")
            {

            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
            
            
        }
    }
    
}