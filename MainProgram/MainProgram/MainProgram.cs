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
        

        private readonly static string[] warMovieNames = { "Where Eagles Dare", "Jarhead", "Apocalypse Now", "Saving Private Ryan", "Paths of Glory",
                "Das Boot", "Gallipolli", "Tora! Tora! Tora!", "Black Hawk Down", "Full Metal Jacket", "Platoon", "300", "The Hurt Locker"};
        private readonly static string[] dramaMovieNames = { "Rear Window", "North by Northwest", "The Sixth Sense", "Inception", "Psycho", "The Departed", "Se7en",
                "The Usual Suspects", "The Silence of the Lambs", "Snatch", "Reservoir Dogs" ,"L.A. Confidential", "Lock, Stock, and Two Smoking Barrels"};
        private readonly static string[] scifiMovieNames = { "Mad Max: Fury Road", "E.T.", "Metropolis", "Gravity", "Star Wars: The Last Jedi", "Star Wars: Episode VII- The Force Awakens",
                "Alien", "Star Wars: Episode IV- A New Hope", "Star Trek", "The Terminator", "Star Wars: Episode V- The Empire Strikes Back", "Aliens",
                "Invasion of the Body Snatchers", "The Martian", "Blade Runner 2049", "Jurassic Park", "2001: A Space Odyssey", "Blade Runner", "Avatar", "The Matrix",
                "A Clockwork Orange", "Star Trek Into Darkness", "Star Trek Beyond" };
        private readonly static string[] hororMovieNames = {"Psycho", "The Exorcist", "Carrie", "Halloween", "Friday the 13th", "28 Days Later", "A Nightmare on Elm Street",
                "The Silence of the Lambs", "The Ring", "Black Swan", "Shaun of the Dead", "The Cabin in the Woods", "Halloween (2018)", "IT (2017)", "Split"};
        private readonly static string[] familyMovieNames = {"The Lord of the Rings: The Return of the King", "Home Alone", "Harry Potter and the Philosopher's Stone", "The Princess Bride",
                "Beauty and the Beast", "Maleficent", "Night at the Musemum", "Where the Wild Things Are", "Charlie and the Chocolate Factory", "Alice in Wonderland",
            "Lemony Snicket's A Series of Unfortunate Events", "The Golden Compass", "Pirates of the Caribbean: The Curse of the Black Pearl", "Men in Black"};
        private readonly static string[] actionMovieNames = {"Kill Bill: Vol 1", "Terminator 2: Judgement Day", "The Matrix", "Die Hard", "Indiana Jones and the Raiders of the Lost Ark",
                "The Dark Knight", "Aliens", "John Wick", "The Bourne Identity", "The Avengers", "Independence Day", "Iron Man", "Lethal Weapon", "The Fifth Element",
            "Taken", "Avengers: Infinity War", "Thor", "Captain America: The First Avenger", "Guardians of the Galaxy", "Ant-Man", "Doctor Strange", "Spider-Man: Homecoming",
                "Black Panther", "Captain Marvel" };

        public static void genreConor()
        {
            Console.WriteLine("genreConor");

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
