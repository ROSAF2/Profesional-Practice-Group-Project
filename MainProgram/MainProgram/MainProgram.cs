using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram
{
    class MainProgram
    {
        private static Random rand = new Random();//This is a system to run the methods randomly
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
            //databases for all directors and what genres they are most famous for
            string[] warDirectors = {"Brian G.Hutton", "Sam Mendes", "Francis Ford Coppola", "Peter Weir",
                "Oliver Stone", "Zack Snyder", "Kathryn Bigelow"};
            string[] dramaDirectors = { "M.Night Shyamalan", "Christopher Nolan", "Martin Scorsese", "David Fincher" };
            string[] scifiDirectors = {"Steven Spielberg", "George Miller", "Alfonso Cuaron", "J.J Abrams",
                "James Cameron", "Ridley Scott", "Dennis Villeneuve", "Lilly Wachowski", "Lana Wachowski", "Justin Lin"};
            string[] horrorDirectors = { "Jonathan Demme", "Wes Craven", "Darren Aronofsky", "Drew Goddard" };
            string[] familyDirectors = {"Peter Jackson", "Chris Columbus", "Bill Condon", "Robert Stromberg",
                "Tim Burton", "Brad Silberling", "Chris Weitz", "Gore Verbinski"};
            string[] actionDirectors = {"Chad Stahelski", "David Leitch", "Doug Liman", "Joss Whedon", "Jon Favreau",
                "Richard Donner", "Luc Besson", "Anthony Russo", "Joe Russo", "Kenneth Branagh", "Joe Johnston", "James Gunn", "Peyton Reed"};

            //genreIndex holds a random value for which genre the director will be picked from, directorIndex randomly gets an index of a director in genreIndex
            int genreIndex, directorIndex, count = 0;
            string[] directorList = new string[5];

            while (count < 5) {
                genreIndex = rand.Next(6);
                //Switch fills the array with the director names + the genre they are famous for. Use a .split(',') to split the slot into the director and genre
                switch (genreIndex)
                {
                    case 0:
                        directorIndex = rand.Next(warDirectors.Length);
                        directorList[count] = warDirectors[directorIndex] + ", War";
                        break;
                    case 1:
                        directorIndex = rand.Next(dramaDirectors.Length);
                        directorList[count] = dramaDirectors[directorIndex] + ", Drama";
                        break;
                    case 2:
                        directorIndex = rand.Next(scifiDirectors.Length);
                        directorList[count] = scifiDirectors[directorIndex] + ", Sci-Fi";
                        break;
                    case 3:
                        directorIndex = rand.Next(horrorDirectors.Length);
                        directorList[count] = horrorDirectors[directorIndex] + ", Horror";
                        break;
                    case 4:
                        directorIndex = rand.Next(familyDirectors.Length);
                        directorList[count] = familyDirectors[directorIndex] + ", Family";
                        break;
                    case 5:
                        directorIndex = rand.Next(actionDirectors.Length);
                        directorList[count] = actionDirectors[directorIndex] + ", Action";
                        break;
                }
                count++;
            }
            foreach (string i in directorList)
            {
                Console.WriteLine(i);
            }
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
