using System;
using System.Collections.Generic;
using System.IO;

namespace Module1_AssignmentB
{
    class Program
    {
        // private static readonly FileOutput OutFile = new FileOutput("animals.txt");
        // private static readonly FileInput InFile = new FileInput("animals.txt");
        //
        static void Main(string[] args)
        {
            List<ITalkable> zoo = new List<ITalkable>();

            AddAnimal addAnimal = new AddAnimal(zoo);
            addAnimal.AskUser();
            // zoo.Add(new Dog("Bean",true));
            // zoo.Add(new Cat("Charlie", 9));
            // zoo.Add(new Teacher("Stacy Read", 44));
            
            foreach(ITalkable thing in zoo){
                PrintOut(thing);
            }
            // OutFile.FileClose();
            // InFile.FileRead();
            // InFile.FileClose();

            FileInput inData = new FileInput("animals.txt");
            string line;
            while ((line = inData.FileReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        public static void PrintOut(ITalkable p)
        {
            Console.WriteLine(p.GetName() + " says=" + p.Talk());
            // OutFile.FileWrite(p.GetName() + " | " + p.Talk());
        }
    }
}