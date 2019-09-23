

namespace Group_1_AI_Project
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Methods
    {
        class Program
        {
            
            public static void Task1()
            {

                Console.WriteLine("This is task 1 ");
                Console.ReadLine();
            }

            public static void Task2()
            {

                Console.WriteLine("This is task 2");
                Console.ReadLine();
            }

            public static void Task3()
            {

                Console.WriteLine("This is task 3");
                Console.ReadLine();
            }

            public static void Task4()
            {

                Console.WriteLine("This is task 4");
                Console.ReadLine();
            }

            public static void Main(string[] args)
            {
                //variables
                string uInput;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the skeleton menu system");
                    Console.WriteLine("Press 1 for option 1");
                    Console.WriteLine("Press 2 for option 2");
                    Console.WriteLine("Press 3 for option 3");
                    Console.WriteLine("Press 4 for option 4");
                    Console.WriteLine("Press 0 to quit");
                    Console.WriteLine();

                    uInput = Console.ReadLine();
                    Console.Clear();

                    switch (uInput)
                    {
                        case "1":
                            Task1();
                            break;

                        case "2":
                            Task2();
                            break;

                        case "3":
                            Task3();
                            break;

                        case "4":
                            Task4();
                            break;

                        case "0":
                            //empty case to quit the program
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Please input a valid character");
                            Console.ReadLine();
                            break;
                    }

                } while (uInput != "0");
            }
        }
    }
}

