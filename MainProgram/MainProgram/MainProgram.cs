using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram
{
    class MainProgram
    {
        private static string[] question = new string[50]; //global array storing questions WE have created
        private static string[] answer = new string[50]; //global array storing user answers
        // answer[i]: 0-9 => Method1, 10-19 => Method2, 20-29 => Method3, 30-39 => Method4, 40-49 => Method5

        public static void genreConor()
        {
            Console.WriteLine("genreConor");
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
            //Program welcome and programmer credits
            Console.WriteLine("Welcome to the Movie Reccomendation AI");
            Console.WriteLine();
            Console.WriteLine("This program was written by Jack Kelliher, Francisco Rosas, Kristen Collins, Johny Zhu and Conor West");
            Console.ReadLine();
            Console.Clear();
            //This runs once at program startup and clears when the user presses enter


            Random rand = new Random();//This is a system to run the methods randomly
            int one, two, three, four, randomNumber, sum;
            bool innerCondition, outerCondition = true; //These variables control the loops

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

                    switch (randomNumber)//This switch statement calls the methods.
                    {
                        case 1:
                            if (one == 1) { genreConor(); one = 0; }
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

                Console.WriteLine("Method 5");
                Console.WriteLine();


                Console.ReadLine();

            } while (outerCondition);
        }
    }
}
