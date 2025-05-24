using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Reference Reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(Reference, "Trust in the Lord with all thy heart and lean not unto thine own understanding; in all they ways acknowledge him, and he shall direct thy paths.");
        Console.Write(Reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to continue, or type 'quit' to finish");
            string choice = Console.ReadLine();
            scripture.HideRandomWords(3);



        while (choice != "quit")
        {
            if (scripture.IsCompletelyHidden() == true)
            {
                Console.Write(Reference.GetDisplayText());
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Press Enter to continue, or type 'quit' to finish");
                choice = Console.ReadLine();
                scripture.HideRandomWords(3);

            }
            // or all words are != "___" How to code this?
            else if (scripture.IsCompletelyHidden() == false) 
            {
                Console.WriteLine("You have memorized the scripture!");
                break;
            }
        }
        Console.WriteLine("Goodbye!");

         
    }
}