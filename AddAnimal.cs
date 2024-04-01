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
            string userInput = "y";

            while (userInput != "n")
            {
                Console.WriteLine("What type of animal do you want to add? (Dog/Cat)");
                userInput = Console.ReadLine();
                if (userInput != null)
                {
                    InputAnimal(userInput);
                }
                Console.WriteLine("Would you like to add an animal? (y/n)");
                userInput = Console.ReadLine().ToLower();
            }
            
            
        }

        public void InputAnimal(string userInput)
        {
            string name;
            switch (userInput.ToLower())
            {
                case "dog":
                    Console.WriteLine("What's their name?");
                    name = Console.ReadLine();
                    Console.WriteLine("Are they friendly?(yes/no)");
                    userInput = Console.ReadLine().ToLower();
                    bool friendly = userInput != "no";
                    _zoo.Add(new Dog(name, friendly));
                    //bool Friendly = Console.ReadLine()
                    break;
                case "cat": 
                    Console.WriteLine("What's their name?");
                    name = Console.ReadLine();
                    Console.WriteLine("How many mouses have they killed?");
                    userInput = Console.ReadLine();
                    int mousesKilled;
                    if (Int32.TryParse(userInput, out mousesKilled))
                    {
                        mousesKilled = Int32.Parse(userInput);
                        _zoo.Add(new Cat(name, mousesKilled));
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}