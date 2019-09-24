using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {

        private static string[] question = new string[50]; //global array storing questions WE have created
        private static string[] answer = new string[50]; //global array sorting user answers
        // answer[i]: 0-9 => Method1, 10-19 => Method2, 20-29 => Method3, 30-39 => Method4, 40-49 => Method5

        public static void genreConor()
        {
            string[] genre1 = {"Action","SciFi" ,"Drama","Horror", "War","Family"}; //list of all available genres


            Console.WriteLine("Genre");

            Console.WriteLine("Which of the following genre do you prefer?");

            foreach (var item in genre1)//foreach which displays all the genres in the genre array
            {
                Console.WriteLine(item); //here the user decides on their genre preference
            }

            answer[0] = Console.ReadLine(); //answer0 is user's answer for genre preference


            if () ;



        }
        public static void actorsKristen()
        {
            Console.WriteLine("Method 2");
        }
        public static void actressesKristen()
        {
            Console.WriteLine("Method 3");
        }
        public static void directorsJack()
        {
            string[] warDirectors = {"Brian G.Hutton", "Sam Mendes", "Francis Ford Coppola", "Peter Weir",
                "Oliver Stone", "Zack Snyder", "Kathryn Bigelow"};
            string[] dramaDirectors = { "M.Night Shyamalan", "Christopher Nolan", "Martin Scorsese", "David Fincher" };
            string[] scifiDirectors = {"Steven Spielberg", "George Miller", "Alfonso Cuaron", "J.J Abrams",
                "James Cameron", "Ridley Scott", "Dennis Villeneuve", "Lilly Wachowski", "Lana Wachowski", "Justin Lin"};
            string[] horrorDirectors = { "Jonathan Demme", "Wes Craven", "Darren Aronofsky", "Drew Goddard" };
            string[] familyDirectors = {"Peter Jackson", "Chris Columbus", "Bill Condon", "Robert Stromberg",
                "Tim Burton", "Brad Silberling", "Chris Weitz", "Gore Verbinski"};
            string[] actionDirectors = {"Chad Stahelski", "David Leitch", "Doug Liman", "Joss Whedon", "Jon Favreau",
                "Richard Donner", "Luc Besson", "Anthony Russo", "Joe Russo", "Kenneth Branagh", "Joe Johnston", "James Gunn", "Peyton Reed"}
        }


        static void Main()
        {
            //Program welcome and programmer credits
            Console.WriteLine("Welcome to the Movie Recommendation AI");
            Console.WriteLine();
            Console.WriteLine("This program was written by Jack Kelliher, Francisco Fernando Rosas Chavez, Kristen Collins, Jonny Zhu and Conor West");
            Console.ReadLine();
            Console.Clear();
            //this runs once at program startup and clears when the user presses enter


            Random rand = new Random();//this is a system to create a list in a random order
            int one, two, three, four, randomNumber,sum;
            bool innerCondition, outerCondition = true; //these control loops

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

                    switch (randomNumber)//this switch statement displays the list elements
                    {
                        case 1:
                            if (one == 1) { genreConor(); one = 0; }//methods are called here
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
