using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        private static string[] question = new string[30];
        private static string[] answer = new string[30];

        public static void Method1()
        {
            string[] genre1 = {"Action","SciFi" ,"Drama","Horror", "War","Family"};


            Console.WriteLine("Genre");

            Console.WriteLine("Which of the following genre do you prefer?");

            foreach (var item in genre1)
            {
                Console.WriteLine(item);
            }

            answer[0] = Console.ReadLine();

            if ()



        }
        public static void Method2()
        {
            Console.WriteLine("Method 2");
        }
        public static void Method3()
        {
            Console.WriteLine("Method 3");
        }
        public static void Method4()
        {
            Console.WriteLine("Method 4");
        }


        static void Main()
        {
            Random rand = new Random();
            int one, two, three, four, randomNumber,sum;
            bool innerCondition, outerCondition = true;

            do
            {
                one = 1;
                two = 2;
                three = 3;
                four = 4;
                innerCondition = true;

                do
                {
                    sum = one + two + three + four;
                    randomNumber = rand.Next(1, 5);

                    switch (randomNumber)
                    {
                        case 1:
                            if (one == 1) { Method1(); one = 0; }
                            break;
                        case 2:
                            if (two == 2) { Method2(); two = 0; }
                            break;
                        case 3:
                            if (three == 3) { Method3(); three = 0; }
                            break;
                        case 4:
                            if (four == 4) { Method4(); four = 0; }
                            break;
                    }

                    if (sum == 0) innerCondition = false;

                } while (innerCondition);

                Console.WriteLine("Method 6");
                Console.WriteLine();


                Console.ReadLine();

            } while (outerCondition);
        }
    }
}
