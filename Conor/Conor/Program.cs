using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conor
{
    class Program
    {

        private static string[] question = new string[60]; //global array storing questions WE have created
        private static string[] answer = new string[60]; //global array storing user answers
        // answer[i]: 0-9 => Method1(Conor), 10-19 => Method2(Kristen), 20-29 => Method3(Kristen), 30-39 => Method4(Jack), 
        //40-49 =>  Questions(Johny), 50-59 => Method0(Francisco),60-69 => Main(Francisco);
        private static Random rand = new Random();

        public static void genreConor()
        {
            ///////////////Questions
            question[0] = "What is it about movies that you like?";
            question[1] = "Do you like War movies?";
            question[2] = "Do you like Drama movies?";
            question[3] = "Do you like SciFi movies?";
            question[4] = "Do you like Horror movies?";
            question[5] = "Do you like Family movies?";
            question[6] = "Do you like Action movies?";
            question[7] = "Do you love me?";
            question[8] = "So, out of these genres \"\", which one do you like the most? ";
            string options = null; //Auxiliary string
            /////////////////////////////////////////

            Console.WriteLine(question[0]);
            answer[0] = Console.ReadLine();

            for (int i = 1; i < 7; i++)
            {
                //Question 1 - 6
                Console.WriteLine("\n" + question[i]);
                answer[i] = Console.ReadLine();
                if (answer[i].Contains('y'))
                {
                    switch (i)
                    {
                        case 1: answer[i] = "War"; break;
                        case 2: answer[i] = "Drama"; break;
                        case 3: answer[i] = "SciFi"; break;
                        case 4: answer[i] = "Horror"; break;
                        case 5: answer[i] = "Family"; break;
                        case 6: answer[i] = "Action"; break;
                    }
                }
                else answer[i] = null;
            }
            // Question 7
            Console.WriteLine("\n" + question[7]);
            answer[7] = Console.ReadLine();
            if (answer[7].Contains('y')) Console.WriteLine("\nI also love you <3\n");
            else Console.WriteLine("\nYou broke my heart... T-T\n");

            //Concatenates genres liked
            for (int i = 1; i < 7; i++)
            {
                if (answer[i] != null)
                    options = options + " " + answer[i] + " ";
            }

            // Question 8
            Console.WriteLine(question[8].Insert(25, options.Trim()));
            answer[8] = Console.ReadLine();
            //////////////////////////////////////////////////
        }

        static void Main(string[] args)
        {

            genreConor();

            Console.ReadLine();
        }
    }
}
