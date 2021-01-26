using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            while (userInput!="exit")
            {
                Console.Clear();
                MenuOutput();
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        FirstTask.Logic();
                        Console.ReadLine();
                        break;
                    case "2":
                        SecondTask.Logic();
                        Console.ReadLine();
                        break;
                    case "3":
                        ThirdTask.Logic();
                        Console.ReadLine();
                        break;
                    case "exit":
                        Console.WriteLine("Thanks for using this app");
                        break;
                    default:
                        Console.WriteLine("It's not a number of task. Press enter to continue and try again");
                        Console.ReadLine();
                        break;
                }
            }
           
        }

        private static void MenuOutput()
        {
            Console.WriteLine("Choose the Task");
            Console.WriteLine("1 - First Task");
            Console.WriteLine("2 - Second Task");
            Console.WriteLine("3 - Third Task");
            Console.WriteLine("If you want to exit enter 'exit' ");
        }
    }
}
