using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Entry> entries = new List<Entry>();
        List<string> prompts = new List<string>();
        //TODO: move this to jounal class
        //Doesn't work if I move it. Correct way to move?
        string choice = "0";
        while (choice != "5")
        {

            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit \nWhat would you like to do?");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                PromptGenerator prompt = new PromptGenerator();

                string prompt1 = prompt.GetRandomPrompt();
                Console.WriteLine(prompt1);
                Console.Write("> ");
                string entryText = Console.ReadLine();
                Entry entry = new Entry();
                Entry prompter = new Entry();
                entry._entryText = entryText;
                prompter._promptText = prompt1;
                prompts.Add(prompt1);
                entries.Add(entry);


                // TODO: Add date and prompt
                //how do I add the prompt to display?


            }
            else if (choice == "2")
            {
                foreach (Entry i in entries)
                {
                    i.Display();
                }

            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename? ");
                string fileNameLoad = Console.ReadLine();
                
                string[] lines = System.IO.File.ReadAllLines(fileNameLoad);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename? ");
                string fileNameSave = Console.ReadLine();
                
                using (StreamWriter outputFile = new StreamWriter(fileNameSave))
                {
                    foreach (Entry i in entries)
                    {
                        outputFile.WriteLine(i);
                    }
                }

            }
            else
            {
                Console.WriteLine("Goodbye!");
            }


        }
    }

}