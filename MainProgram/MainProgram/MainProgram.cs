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


            public static void Main(String[] args)
        {

        }
        /**private static string[] warMovieNames = { "Where Eagles Dare", "Jarhead", "Apocalypse Now", "Saving Private Ryan", "Paths of Glory",
                "Das Boot", "Gallipolli", "Tora! Tora! Tora!", "Black Hawk Down", "Full Metal Jacket", "Platoon", "300", "The Hurt Locker"};
        private static string[] dramaMovieNames = { "Rear Window", "North by Northwest", "The Sixth Sense", "Inception", "Psycho", "The Departed", "Se7en",
                "The Usual Suspects", "The Silence of the Lambs", "Snatch", "Reservoir Dogs" ,"L.A. Confidential", "Lock, Stock, and Two Smoking Barrels"};
        private static string[] scifiMovieNames = { "Mad Max: Fury Road", "E.T.", "Metropolis", "Gravity", "Star Wars: The Last Jedi", "Star Wars: Episode VII- The Force Awakens",
                "Alien", "Star Wars: Episode IV- A New Hope", "Star Trek", "The Terminator", "Star Wars: Episode V- The Empire Strikes Back", "Aliens",
                "Invasion of the Body Snatchers", "The Martian", "Blade Runner 2049", "Jurassic Park", "2001: A Space Odyssey", "Blade Runner", "Avatar", "The Matrix",
                "A Clockwork Orange", "Star Trek Into Darkness", "Star Trek Beyond" };

        private static string[] hororMovieNames = {"Psycho", "The Exorcist", "Carrie", "Halloween", "Friday the 13th", "28 Days Later", "A Nightmare on Elm Street",
                "The Silence of the Lambs", "The Ring", "Black Swan", "Shaun of the Dead", "The Cabin in the Woods", "Halloween (2018)", "IT (2017)", "Split"};

        private static string[] familyMovieNames = {"The Lord of the Rings: The Return of the King", "Home Alone", "Harry Potter and the Philosopher's Stone", "The Princess Bride",
                "Beauty and the Beast", "Maleficent", "Night at the Musemum", "Where the Wild Things Are", "Charlie and the Chocolate Factory", "Alice in Wonderland",
            "Lemony Snicket's A Series of Unfortunate Events", "The Golden Compass", "Pirates of the Caribbean: The Curse of the Black Pearl", "Men in Black"};

        private static string[] actionMovieNames = {"Kill Bill: Vol 1", "Terminator 2: Judgement Day", "The Matrix", "Die Hard", "Indiana Jones and the Raiders of the Lost Ark",
                "The Dark Knight", "Aliens", "John Wick", "The Bourne Identity", "The Avengers", "Independence Day", "Iron Man", "Lethal Weapon", "The Fifth Element",
            "Taken", "Avengers: Infinity War", "Thor", "Captain America: The First Avenger", "Guardians of the Galaxy", "Ant-Man", "Doctor Strange", "Spider-Man: Homecoming",
                "Black Panther", "Captain Marvel" };

        public static void genreConor()
        {
            Console.WriteLine("genreConor");
            //variables
            string genreMainMenu, warMenu;

            string[] warMovieNames = { "Where Eagles Dare", "Jarhead", "Apocalypse Now", "Saving Private Ryan", "Paths of Glory",
                "Das Boot", "Gallipolli", "Tora! Tora! Tora!", "Black Hawk Down", "Full Metal Jacket", "Platoon", "300", "The Hurt Locker"};
            string[] dramaMovieNames = { "Rear Window", "North by Northwest", "The Sixth Sense", "Inception", "Psycho", "The Departed", "Se7en",
                "The Usual Suspects", "The Silence of the Lambs", "Snatch", "Reservoir Dogs" ,"L.A. Confidential", "Lock, Stock, and Two Smoking Barrels"};
            string[] scifiMovieNames = { "Mad Max: Fury Road", "E.T.", "Metropolis", "Gravity", "Star Wars: The Last Jedi", "Star Wars: Episode VII- The Force Awakens",
                "Alien", "Star Wars: Episode IV- A New Hope", "Star Trek", "The Terminator", "Star Wars: Episode V- The Empire Strikes Back", "Aliens",
                "Invasion of the Body Snatchers", "The Martian", "Blade Runner 2049", "Jurassic Park", "2001: A Space Odyssey", "Blade Runner", "Avatar", "The Matrix",
                "A Clockwork Orange", "Star Trek Into Darkness", "Star Trek Beyond" };
            string[] hororMovieNames = {"Psycho", "The Exorcist", "Carrie", "Halloween", "Friday the 13th", "28 Days Later", "A Nightmare on Elm Street",
                "The Silence of the Lambs", "The Ring", "Black Swan", "Shaun of the Dead", "The Cabin in the Woods", "Halloween (2018)", "IT (2017)", "Split"};
            string[] familyMovieNames = {"The Lord of the Rings: The Return of the King", "Home Alone", "Harry Potter and the Philosopher's Stone", "The Princess Bride",
                "Beauty and the Beast", "Maleficent", "Night at the Musemum", "Where the Wild Things Are", "Charlie and the Chocolate Factory", "Alice in Wonderland",
            "Lemony Snicket's A Series of Unfortunate Events", "The Golden Compass", "Pirates of the Caribbean: The Curse of the Black Pearl", "Men in Black"};
            string[] actionMovieNames = {"Kill Bill: Vol 1", "Terminator 2: Judgement Day", "The Matrix", "Die Hard", "Indiana Jones and the Raiders of the Lost Ark",
                "The Dark Knight", "Aliens", "John Wick", "The Bourne Identity", "The Avengers", "Independence Day", "Iron Man", "Lethal Weapon", "The Fifth Element",
            "Taken", "Avengers: Infinity War", "Thor", "Captain America: The First Avenger", "Guardians of the Galaxy", "Ant-Man", "Doctor Strange", "Spider-Man: Homecoming",
                "Black Panther", "Captain Marvel" };

            Console.WriteLine();
            Console.WriteLine("Please select your favourite genre");
            Console.WriteLine("Input the number selection and press ENTER");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("War");
            Console.WriteLine("Drama");
            Console.WriteLine("Science Fiction");
            Console.WriteLine("Horror");
            Console.WriteLine("Family");
            Console.WriteLine("Action");

            genreMainMenu = Console.ReadLine();

            switch (genreMainMenu)
            {
                case "War":
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("What is it about War movies that you like?");
                    Console.WriteLine();
                    Console.WriteLine("Is it the action, the storyline or the history?");
                    Console.WriteLine("Or is it something else entriely?");

                    switch (warMenu)
                    {
                        case ""

                    }


                    break;


                case '1':

                    break;

                case '2':

                    break;

                case '3':

                    break;

                case '4':

                    break;

                case '5':

                    break;

                default:
                    Console.WriteLine("I didn't undertand that!");
            }



        }
        public static void Method2()
        {
            Console.WriteLine("Method 2");



        }
        public static void Method3()
        {
            Console.WriteLine("Method 3");
        } */
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
            int genreIndex, directorIndex, count = 0, directorCount = 1;
            //stores each director and their main associated genre
            string[] directorList = new string[5];
            //stores the users director choice and their genre
            string[] directorChoice = new string[2];
            bool retry = true;
            string temp;
            do
            {
                while (count < 5)
                {
                    genreIndex = rand.Next(6);
                    //Switch fills the array with the director names + the genre they are famous for. Use a .split(',') to split the slot into the director and genre
                    switch (genreIndex)
                    {
                        //Chooses a director from the War genre
                        case 0:
                            directorIndex = rand.Next(warDirectors.Length);
                            directorList[count] = warDirectors[directorIndex] + ", War";
                            break;
                        //Chooses a director from the Drama genre
                        case 1:
                            directorIndex = rand.Next(dramaDirectors.Length);
                            directorList[count] = dramaDirectors[directorIndex] + ", Drama";
                            break;
                        //Chooses a director from the Sci-Fi genre
                        case 2:
                            directorIndex = rand.Next(scifiDirectors.Length);
                            directorList[count] = scifiDirectors[directorIndex] + ", Sci-Fi";
                            break;
                        //Chooses a director from the horror genre
                        case 3:
                            directorIndex = rand.Next(horrorDirectors.Length);
                            directorList[count] = horrorDirectors[directorIndex] + ", Horror";
                            break;
                        //Chooses a director from the family genre
                        case 4:
                            directorIndex = rand.Next(familyDirectors.Length);
                            directorList[count] = familyDirectors[directorIndex] + ", Family";
                            break;
                        //Chooses a director from the action genre
                        case 5:
                            directorIndex = rand.Next(actionDirectors.Length);
                            directorList[count] = actionDirectors[directorIndex] + ", Action";
                            break;
                    }
                    count++;
                }
                Console.WriteLine("Which of the following directors is your favourite: \nEnter 'retry' to refresh the list.");
                foreach (string i in directorList)
                {
                    Console.WriteLine($"{directorCount}.{i}");
                    directorCount++;
                }
                temp = Console.ReadLine();
                if (temp.ToLower() != "retry")
                {
                    retry = false;
                }
                directorCount = 1;
            } while (retry == true);
            Console.WriteLine("Method 4");
        }
    }
}



