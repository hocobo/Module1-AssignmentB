using System;
using System.Collections.Generic;

namespace Module1_AssignmentB
{
    public class AddAnimal
    {
        private List<ITalkable> _zoo;

        public AddAnimal(List<ITalkable> zoo)
        {
            _zoo = zoo;
        }

        public void AskUser()
        {
            Console.WriteLine("What type of animal do you want to add? (Dog/Cat)");
            string userInput = Console.ReadLine();

            if (userInput != null)
            {
                switch (userInput)
                {
                    case "dog":
                        Console.WriteLine("What's their name?");
                        string name = Console.ReadLine();
                        Console.WriteLine("Are they friendly?(yes/no)");
                        userInput = Console.ReadLine();
                        bool friendly = userInput != "no";
                        
                        _zoo.Add(new Dog(name, friendly));
                        //bool Friendly = Console.ReadLine()
                        break;
                }
            }
            
        }
    }
}