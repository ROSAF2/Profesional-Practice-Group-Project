using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        private static string[] question = new string[70]; //global array storing questions WE have created
        private static string[] answer = new string[70]; //global array storing user answers
        // answer[i]: 0-9 => Method1(Conor), 10-19 => Method2(Kristen), 20-29 => Method3(Kristen), 30-39 => Method4(Jack), 
        //40-49 =>  Questions(Johny), 50-59 => Method0(Francisco),60-69 => Main(Francisco);
        private static Random rand = new Random();

        private static int counterMethod0=0;
        private static bool startingOver = false;


        public static void Method0()
        {
            //////////////////////////////////////////////////////////////////////////////////////
            question[50] = "What is your name?"; // close-ended question
            question[51] = "Hi , nice to meet you"; // Response
            question[52] = "Ah, yeah..., I was just making sure you are you"; // Consistency response
            question[53] = "I thought your name was , are you someone else?"; // Inconsistency response
            question[54] = "Ok I will call you ";
            question[55] = "Are you the same  from last time?";
            question[56] = "Of course!, you are the one who likes ";
            question[57] = "Ok, nice to meet you  ";
            question[58] = "Do you want to continue choosing instead of ?";
            //answer[59] auxiliary variable to store the previous name
            ///////////////////////////////////////////////////////////////////////////////////////
            int number;

            //Question 50
            Console.WriteLine("\n" + question[50]);
                answer[50] = Console.ReadLine();

                if (answer[59] == null)
                {
                    //Question 51
                    Console.WriteLine(question[51].Insert(3, answer[50]));
                    answer[59] = answer[50];
                }
                else if (answer[59] == answer[50])
                {   //Question 52
                    counterMethod0++;
                    if (counterMethod0 == 1) Console.WriteLine(question[52]);
                    else
                    {   //Question 55
                        Console.WriteLine(question[55].Insert(17, answer[50]));
                        answer[55] = Console.ReadLine();
                        answer[55] = answer[55].ToLower();

                        if (answer[55].Contains('y'))
                        {   //Question 56
                        number = rand.Next(2);
                        switch (number)
                        {
                            case 0:
                                Console.WriteLine(question[56] + answer[18]);
                                break;
                            case 1:
                                Console.WriteLine(question[56] + answer[28]);
                                break;
                        }
                            Console.WriteLine("Let's continue\n");
                        }
                        else
                        {   //Question 57
                            answer[50] = "\""+answer[50].ToUpper()+ " NUMBER 2\"";
                            Console.WriteLine(question[57].Insert(21, answer[50]));
                            Console.WriteLine(question[58].Insert(question[58].LastIndexOf(' ') + 1, answer[59]));
                        answer[59] = answer[50];
                            answer[53] = Console.ReadLine();
                            answer[53] = answer[53].ToLower();
                            if (answer[53].Contains('y')) Console.WriteLine("\nOk, Let's continue\n");
                            else Console.WriteLine("\nOk, Let's start over\n"); startingOver = true;
                    }
                    }
                }
                else
                {   //Question 53
                    Console.WriteLine(question[53].Insert(24, answer[59]));
                    answer[53] = Console.ReadLine();
                    answer[53] = answer[53].ToLower();

                    if (answer[53].Contains('y'))
                    {
                        Console.WriteLine(question[51].Insert(3, answer[50]));
                        Console.WriteLine(question[58].Insert(question[58].LastIndexOf(' ')+1,answer[59]));
                        answer[59] = answer[50];
                        answer[53] = Console.ReadLine();
                        answer[53] = answer[53].ToLower();
                    if (answer[53].Contains('y')) Console.WriteLine("\nOk, Let's continue\n");
                    else Console.WriteLine("\nOk, Let's start over\n"); startingOver = true;
                    }
                    else
                    {   //Question 54
                        Console.WriteLine(question[54] + answer[50]);
                        answer[59] = answer[50];
                    }
                }
            }
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
            question[8] = "So..., out of these genre(s) \"\", which one do you like the most? ";
            string options = null; //Auxiliary string
            /////////////////////////////////////////
            Console.WriteLine();
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
            Console.WriteLine(question[8].Insert(30, options.Trim()));
            answer[8] = Console.ReadLine();
            //////////////////////////////////////////////////
        }

        public static void MaleActors()
        {
            string[] actors = {"Richard Burton","Clint Eastwood","Jamie Foxx","Jake Gyllenhaal","Marlon Brando","Harrison Ford","Robert Duvall"
                                 ,"Tom Hanks","Kirk Douglas","Mel Gibson","Vincent D'Onofrio","R. Lee Ermey","Adam Baldwin","Johnny Depp","Charlie Sheen","Willem Dafoe"
                                 ,"Gerard Butler","Michael Fassbender","Ralph Fiennes","Jeremy Renner","Cary Grant","Bruce Willis","Haley Joel Osment","Leonardo DiCaprio","Joseph Gordon-Levitt",
                                    "Anthony Perkins","Matt Damon","Jack Nicholson","Mark Wahlberg","Morgan Freeman", "Brad Pitt", "Kevin Spacey",
                                    "Gabriel Byrne", "Chazz Palminteri", "Stephen Baldwin","Anthony Hopkins","Jason Statham", "Benicio Del Toro",
                                    "Harvey Keitel","Tim Roth","Michael Madsen","Chris Penn","Russell Crowe"," Guy Pearce","Jason Flemyng",
                                    "Dexter Fletcher","Nick Moran","Jason Statham","Tom Hardy","George Clooney","Mark Hamill","Adam Driver", "John Boyega", "Adam Driver", "Harrison Ford",
                                    "Tom Skerritt","Harrison Ford","Alec Guinness","Chris Pine", "Zachary Quinto", "Leonard Nimoy", "Karl Urban","Arnold Schwarzenegger",
                                    "Kevin McCarthy", "Dana Wynter", "Matt Damon","Jeff Daniels","Ryan Gosling","Sam Neill","Jeff Goldblum","Keir Dullea", "Gary Lockwood",
                                    "William Sylvester", "Daniel Richter", "Rutger Hauer","Edward James Olmos","Sam Worthington","Keanu Reeves", "Laurence Fishburne", "Joe Pantoliano",
                                    "Malcolm McDowell", "Patrick Magee","Aubrey Morris","Kevin Bacon", "Cillian Murphy", "Johnny Depp", "Anthony Hopkins", "Simon Pegg", "Nick Frost", "Chris Hemsworth", "Bill Skarsgard", "James McAvoy"
                                    ,"Ian McKellen","Viggo Mortensen", "Orlando Bloom","Macaulay Culkin","Daniel Radcliffe", "Rupert Grint","Cary Elwes","Mandy Patinkin","Dan Stevens",
                                    "Luke Evans", "Ben Stiller","Max Records","Forest Whitaker", "Pepita Emmerichs","Johnny Depp", "Jim Carrey", "Jude Law", "Liam Aiken","Daniel Craig",
                                    "Johnny Depp","Tommy Lee Jones", "Will Smith","Quentin Tarantino","Arnold Schwarzenegger","Edward Furlong","Keanu Reeves","Hugo Weaving","Laurence Fishburne","Bruce Willis","Alan Rickman","Harrison Ford",
                                     "Christian Bale","Michael Caine","Heath Ledger","Gary Oldman","Bill Paxton","Matt Damon","Robert Downey Jr.","Chris Evans","Mark Ruffalo","Chris Hemsworth",
                                        "Will Smith","Jeff Goldblum","Mel Gibson","Liam Neeson","Anthony Hopkins","Tom Hiddleston","Hugo Weaving","Samuel L. Jackson","Chris Pratt","Vin Diesel",
                                        "Bradley Cooper","Paul Rudd","Michael Douglas","Corey Stoll","Benedict Cumberbatch","Chiwetel Ejiofor", "Tom Holland","Michael Keaton","Chadwick Boseman",
                                        "Jude Law"};

            //Auxiliary searching variable
            bool searchResult;
            int perhaps = 1, counter = 1, verifier = 0, matchingIndex = 1;
            string[] matchingActors = new string[actors.Length];
            string[] userActor = new string[30];
            int indexK;

            //Question 13 -17
            Console.Write("\nPlease Type four actors that you know or like\n");

            for (int i = 13; i < 17; i++)
            {
                //Asks for an actor
                Console.Write("\nActor {0}: ", counter);
                counter++;
                userActor[i] = Console.ReadLine();
                string[] userActorSplit = userActor[i].Split(' ');
                userActorSplit[0] = userActorSplit[0].ToLower();

                //Searchs inside the array for any instance of the string answer[i] lowercased and stores it
                for (int j = 0; j < actors.Length; j++)
                {
                    searchResult = actors[j].ToLower().Contains(userActorSplit[0]);
                    if (searchResult)
                    {
                        //Console.WriteLine("The word is contained in slot {0}", j);
                        matchingActors[matchingIndex] = actors[j];
                        //Console.WriteLine(matchingActors[matchingIndex]);
                        matchingIndex++;
                        verifier++;
                    }
                }
                //Verifies if the actor is not in the database
                if (verifier == 0)
                {
                    Console.WriteLine("Sorry. This actor is not in my database");
                    counter--;
                    i--;
                }
                else
                {
                    Console.WriteLine("Perhaps you meant?: (Enter number)");
                    //Shows Found candidates for answer[i]
                    for (int k = 0; k < matchingActors.Length; k++)
                    {
                        if (matchingActors[k] != null)
                        {
                            Console.WriteLine($"{perhaps}.- {matchingActors[k]}");
                            perhaps++;
                        }
                    }
                    Console.Write("Number: ");
                    indexK = Convert.ToInt32(Console.ReadLine());
                    answer[i] = matchingActors[indexK];

                }
                perhaps = 1;
                matchingIndex = 1;
                verifier = 0;
                //Deleting all entries
                for (int l = 0; l < matchingActors.Length; l++)
                {
                    matchingActors[l] = null;
                }
            }
            //Question 18
            Console.WriteLine("\nFrom your selections, who is your favourite actor?");
            for (int i = 13; i < 17; i++)
            {
                Console.Write("  " + answer[i] + "  ");
            }
            Console.Write("\nAnswer: ");
            answer[18] = Console.ReadLine();
            Console.WriteLine();
        }

        public static void Actresses()
        {
            string[] actresses = {"Lena Headey", "Evangeline Lilly","Grace Kelly", "Toni Collette", "Janet Leigh", "Jodie Foster", "Kim Basinger","Charlize Theron"
                                  ,"Drew Barrymore","Sandra Bullock","Carrie Fisher","Daisy Ridley","Sigourney Weaver", "Linda Hamilton","Jessica Chastain"
                                  ,"Kristen Wiig","Laura Dern","Sean Young","Zoe Saldana","Carrie-Anne Moss","Adrienne Corri","Janet Leigh", "Linda Blair", "Sissy Spacek"
                                  , "Jamie Lee Curtis", "Jodi Foster", "Naomi Watts", "Natalie Portman", "Kristen Connolly", "Cate Blanchett","Liv Tyler","Emma Watson"
                                  ,"Robin Wright","Angelina Jolie", "Elle Fanning","Carla Gugino","Catherine O'Hara","Helena Bonham Carter"
                                  ,"Mia Wasikowska","Anne Hathaway","Meryl Streep","Nicole Kidman","Dakota Blue Richards","Kiera Knightly"
                                  ,"Brie Larson","Rachel McAdams","Evangeline Lilly","Zoe Saldana","Natalie Portman","Scarlett Johansson","Famke Janssen","Maggie Grace","Uma Thurman"
                                  ,"Lucy Liu","Linda Hamilton","Carrie-Anne Moss","Sigourney Weaver","Julia Stiles","Gwyneth Paltrow","Milla Jovovich"};



            //Auxiliary searching variable
            bool searchResult;
            int perhaps = 1, counter = 1, verifier = 0, matchingIndex = 1;
            string[] matchingActresses = new string[actresses.Length];
            string[] userActresses = new string[30];
            int indexK;

            //Question 23 -27
            Console.Write("\nPlease Type four actresses that you know or like\n");

            for (int i = 23; i < 27; i++)
            {
                //Asks for an actor
                Console.Write("\nActress {0}: ", counter);
                counter++;
                userActresses[i] = Console.ReadLine();
                string[] userActressesSplit = userActresses[i].Split(' ');
                userActressesSplit[0] = userActressesSplit[0].ToLower();

                //Searchs inside the array for any instance of the string answer[i] lowercased and stores it
                for (int j = 0; j < actresses.Length; j++)
                {
                    searchResult = actresses[j].ToLower().Contains(userActressesSplit[0]);
                    if (searchResult)
                    {
                        //Console.WriteLine("The word is contained in slot {0}", j);
                        matchingActresses[matchingIndex] = actresses[j];
                        //Console.WriteLine(matchingActors[matchingIndex]);
                        matchingIndex++;
                        verifier++;
                    }
                }
                //Verifies if the actor is not in the database
                if (verifier == 0)
                {
                    Console.WriteLine("Sorry. This actress is not in my database");
                    counter--;
                    i--;
                }
                else
                {
                    Console.WriteLine("Perhaps you meant?: (Enter number)");
                    //Shows Found candidates for answer[i]
                    for (int k = 0; k < matchingActresses.Length; k++)
                    {
                        if (matchingActresses[k] != null)
                        {
                            Console.WriteLine($"{perhaps}.- {matchingActresses[k]}");
                            perhaps++;
                        }
                    }
                    Console.Write("Number: ");
                    indexK = Convert.ToInt32(Console.ReadLine());
                    answer[i] = matchingActresses[indexK];

                }
                perhaps = 1;
                matchingIndex = 1;
                verifier = 0;
                //Deleting all entries
                for (int l = 0; l < matchingActresses.Length; l++)
                {
                    matchingActresses[l] = null;
                }
            }
            //Question 18
            Console.WriteLine("\nFrom your selections, who is your favourite actress?");
            for (int i = 23; i < 27; i++)
            {
                Console.Write("  " + answer[i] + "  ");
            }
            Console.Write("\nAnswer: ");
            answer[28] = Console.ReadLine();
            Console.WriteLine();
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
            //stores each director and their main associated genre
            string[] directorList = new string[5], splitDirectors = new string[2];
            //stores the users director choice and their genre
            string[] directorChoice = new string[2];
            bool retry = true;
            string temp, directorStyle, reccomendDirector = "", directorName;


            //loop to generate three questions and to generate 5 random directors to choose from for each
            for (int i = 30; i < 33; i++)
            {
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
                                directorList[count] = warDirectors[directorIndex] + ",War";
                                break;
                            //Chooses a director from the Drama genre
                            case 1:
                                directorIndex = rand.Next(dramaDirectors.Length);
                                directorList[count] = dramaDirectors[directorIndex] + ",Drama";
                                break;
                            //Chooses a director from the Sci-Fi genre
                            case 2:
                                directorIndex = rand.Next(scifiDirectors.Length);
                                directorList[count] = scifiDirectors[directorIndex] + ",Sci-Fi";
                                break;
                            //Chooses a director from the horror genre
                            case 3:
                                directorIndex = rand.Next(horrorDirectors.Length);
                                directorList[count] = horrorDirectors[directorIndex] + ",Horror";
                                break;
                            //Chooses a director from the family genre
                            case 4:
                                directorIndex = rand.Next(familyDirectors.Length);
                                directorList[count] = familyDirectors[directorIndex] + ",Family";
                                break;
                            //Chooses a director from the action genre
                            case 5:
                                directorIndex = rand.Next(actionDirectors.Length);
                                directorList[count] = actionDirectors[directorIndex] + ",Action";
                                break;
                        }
                        count++; //goes on to get next random director
                    }


                    Console.WriteLine("\nWhich of the following directors do you like?: \nEnter 'retry' to refresh the list.\n");
                    //Displaying randomly generated options
                    for (int j = 1; j < 6; j++)
                    {
                        Console.WriteLine($"{j}.{directorList[j - 1]}");
                    }
                    //Reading user number choice as string
                    Console.Write("Number: ");
                    temp = Console.ReadLine();
                    if (temp.Contains("retry"))
                    {
                        retry = false;
                    }
                    else
                    {
                        answer[i] = directorList[Convert.ToInt32(temp) - 1];
                        retry = true;
                    }
                    count = 0; //Condition to reset the while loop
                    Console.Clear();
                } while (retry == false);
            }

            // temp generate a random director from the chosen directors
            temp = answer[rand.Next(30, 33)];
            // splitDirectors splits the temp value up into two values, the director and the genre they are famous for
            splitDirectors = temp.Split(',');
            directorStyle = splitDirectors[1].ToLower();
            directorName = splitDirectors[0]; // saves the directors name into a unique variable

            //gets another director according to the genre the splitDirectors value is associated with
            switch (directorStyle)
            {
                case "war":
                    reccomendDirector = warDirectors[rand.Next(warDirectors.Length)];
                    break;
                case "drama":
                    reccomendDirector = dramaDirectors[rand.Next(dramaDirectors.Length)];
                    break;
                case "sci-fi":
                    reccomendDirector = scifiDirectors[rand.Next(scifiDirectors.Length)];
                    break;
                case "horror":
                    reccomendDirector = horrorDirectors[rand.Next(horrorDirectors.Length)];
                    break;
                case "family":
                    reccomendDirector = familyDirectors[rand.Next(familyDirectors.Length)];
                    break;
                case "action":
                    reccomendDirector = actionDirectors[rand.Next(actionDirectors.Length)];
                    break;
            }

            //refers the user to a similar director, and asks if they know them.
            Console.WriteLine($"You enjoy the work of {directorName}, famous {directorStyle} director. Are you familiar with {reccomendDirector}, another {directorStyle} director?");
            answer[34] = reccomendDirector + "," + Console.ReadLine();
            Console.Clear();

            for (int i = 30; i < 33; i++)
            {
                if (answer[i].Contains(reccomendDirector) && answer[34].Contains('n'))
                {
                    Console.WriteLine($"You claimed you were not familiar with {reccomendDirector}, but you chose them as a liked director in earlier questions, are you sure you didn't mean yes?");
                    string fixUp;
                    fixUp = Console.ReadLine();
                    Console.Clear();
                    if (fixUp.Contains('y'))
                    {
                        Console.WriteLine("Just as I thought!");
                    }
                    else
                    {
                        Console.WriteLine("Mistakes happen!");
                    }
                }
                else if (answer[i].Contains(reccomendDirector) && answer[35].Contains('y'))
                {
                    Console.WriteLine($"I know you are familiar with them, you picked {reccomendDirector} as a liked director");
                }
            }

            Console.WriteLine("\nWhich director do you like more then?");
            for (int i = 30; i < 33; i++)
            {
                Console.Write("  " + answer[i] + "  ");
            }
            Console.Write("\nFull name: ");
            answer[36] = Console.ReadLine();
        }

        public static void LastMethod()
        {
            string[] warMovieNames = { "Where Eagles Dare", "Jarhead", "Apocalypse Now", "Saving Private Ryan", "Paths of Glory",
                "Das Boot", "Gallipolli", "Tora! Tora! Tora!", "Black Hawk Down", "Full Metal Jacket", "Platoon", "300", "The Hurt Locker"};
            string[] dramaMovieNames = { "Rear Window", "North by Northwest", "The Sixth Sense", "Inception", "Psycho", "The Departed", "Se7en",
                "The Usual Suspects", "The Silence of the Lambs", "Snatch", "Reservoir Dogs" ,"L.A. Confidential", "Lock, Stock, and Two Smoking Barrels"};
            string[] scifiMovieNames = { "Mad Max: Fury Road", "E.T.", "Metropolis", "Gravity", "Star Wars: The Last Jedi", "Star Wars: Episode VII- The Force Awakens",
                "Alien", "Star Wars: Episode IV- A New Hope", "Star Trek", "The Terminator", "Star Wars: Episode V- The Empire Strikes Back", "Aliens",
                "Invasion of the Body Snatchers", "The Martian", "Blade Runner 2049", "Jurassic Park", "2001: A Space Odyssey", "Blade Runner", "Avatar", "The Matrix",
                "A Clockwork Orange", "Star Trek Into Darkness", "Star Trek Beyond" };
            string[] horrorMovieNames = {"Psycho", "The Exorcist", "Carrie", "Halloween", "Friday the 13th", "28 Days Later", "A Nightmare on Elm Street",
                "The Silence of the Lambs", "The Ring", "Black Swan", "Shaun of the Dead", "The Cabin in the Woods", "Halloween (2018)", "IT (2017)", "Split"};
            string[] familyMovieNames = {"The Lord of the Rings: The Return of the King", "Home Alone", "Harry Potter and the Philosopher's Stone", "The Princess Bride",
                "Beauty and the Beast", "Maleficent", "Night at the Musemum", "Where the Wild Things Are", "Charlie and the Chocolate Factory", "Alice in Wonderland",
            "Lemony Snicket's A Series of Unfortunate Events", "The Golden Compass", "Pirates of the Caribbean: The Curse of the Black Pearl", "Men in Black"};
            string[] actionMovieNames = {"Kill Bill: Vol 1", "Terminator 2: Judgement Day", "The Matrix", "Die Hard", "Indiana Jones and the Raiders of the Lost Ark",
                "The Dark Knight", "Aliens", "John Wick", "The Bourne Identity", "The Avengers", "Independence Day", "Iron Man", "Lethal Weapon", "The Fifth Element",
            "Taken", "Avengers: Infinity War", "Thor", "Captain America: The First Avenger", "Guardians of the Galaxy", "Ant-Man", "Doctor Strange", "Spider-Man: Homecoming",
                "Black Panther", "Captain Marvel" };
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            int number;

            Console.WriteLine("\nYou said that you like movies because of {0}", answer[0]);
            Console.WriteLine("And this is your profile information:");
            Console.WriteLine("You enjoy {0} movies", answer[8]);
            Console.WriteLine("Your favourite actor is: {0}", answer[18]);
            Console.WriteLine("Your favourite actress is: {0}", answer[28]);
            Console.WriteLine("And your prefered director is: {0}", answer[36]);

            for (int i = 1; i < 7; i++)
            {
                if (answer[i] != null)
                    switch (answer[i].ToLower())
                    {
                        case "war":
                            number = rand.Next(warMovieNames.Length);
                            answer[60] = warMovieNames[number];
                            number = rand.Next(warMovieNames.Length);
                            answer[66] = warMovieNames[number];
                            break;
                        case "drama":
                            number = rand.Next(dramaMovieNames.Length);
                            answer[61] = dramaMovieNames[number];
                            number = rand.Next(dramaMovieNames.Length);
                            answer[66] = dramaMovieNames[number];
                            break;
                        case "scifi":
                            number = rand.Next(scifiMovieNames.Length);
                            answer[62] = scifiMovieNames[number];
                            number = rand.Next(scifiMovieNames.Length);
                            answer[66] = scifiMovieNames[number];
                            break;
                        case "horror":
                            number = rand.Next(horrorMovieNames.Length);
                            answer[63] = horrorMovieNames[number];
                            number = rand.Next(horrorMovieNames.Length);
                            answer[66] = horrorMovieNames[number];
                            break;
                        case "family":
                            number = rand.Next(familyMovieNames.Length);
                            answer[64] = familyMovieNames[number];
                            number = rand.Next(familyMovieNames.Length);
                            answer[66] = familyMovieNames[number];
                            break;
                        case "action":
                            number = rand.Next(actionMovieNames.Length);
                            answer[65] = actionMovieNames[number];
                            number = rand.Next(actionMovieNames.Length);
                            answer[67] = actionMovieNames[number];
                            break;
                    }
            }

            Console.WriteLine("\nAccording to my top-notch algorithms, here are some films that you will probably enjoy:\n");
            for (int i = 60; i < 66; i++)
            {
                if (answer[i] == null) ;
                else Console.WriteLine("{0}", answer[i]);
            }

            if (answer[7] != null)
            {
                if (answer[7].Contains('y'))
                {
                    Console.WriteLine("\nAnd because you said that you love me here is another recommendation!");
                    Console.WriteLine("{0}", answer[66]);
                }
                else
                {
                    Console.WriteLine("\nI was going to recommend another movie but you don't love me... \n(TT-TT)");
                }
            }
        }

        static void Main()//////////////////////////////////////////////////////////////////////////////////////////
        {
            int one, two, three, four, randomNumber, randomMethod0, sum;
            bool innerCondition, outerCondition = true; //These variables control the loops

            //Program welcome and programmer credits
            Console.WriteLine("Welcome to the Movie Reccomendation AI");
            Console.WriteLine();
            Console.WriteLine("This program was written by Jack Kelliher, Francisco Rosas, Kristen Collins, Johny Zhu and Conor West");
            Console.Write("\nPress enter to start");
            Console.ReadLine();
            Console.Clear();
            //This runs once at program startup and clears when the user presses enter
            
            do
            {
                one = 1;
                two = 2;
                three = 3;
                four = 4;
                innerCondition = true;

                Method0();

                do
                {
                    sum = one + two + three + four;
                    randomNumber = rand.Next(1, 5);

                    switch (randomNumber)//This switch statement calls the methods.
                    {
                        case 1:
                            if (one == 1)
                            {
                                genreConor();
                                randomMethod0 = rand.Next(3);
                                if (randomMethod0 == 1)
                                {
                                    //Console.WriteLine("From Method 1");
                                    Method0();
                                }
                                one = 0;
                            }
                            break;
                        case 2:
                            if (two == 2)
                            {
                                MaleActors();
                                randomMethod0 = rand.Next(3);
                                if (randomMethod0 == 1)
                                {
                                    //Console.WriteLine("From Method 2");
                                  Method0();
                                }
                                two = 0;
                            }
                            break;
                        case 3:
                            if (three == 3)
                            {
                                Actresses();
                                randomMethod0 = rand.Next(3);
                                if (randomMethod0 == 1)
                                {
                                    //Console.WriteLine("From Method 3");
                                    Method0();
                                }
                                three = 0;
                            }
                            break;
                        case 4:
                            if (four == 4)
                            {
                                Method4();
                                randomMethod0 = rand.Next(3);
                                if (randomMethod0 == 1)
                                {
                                    //Console.WriteLine("From Method 4");
                                    Method0();
                                }
                                four = 0;
                            }
                            break;
                    }

                    if (startingOver == true)  //Resetting all variables to start the switch again
                    {
                        one = 1;
                        two = 2;
                        three = 3;
                        four = 4;
                        startingOver = false;
                    }

                    if (sum == 0) innerCondition = false; //If sum == 0 that means all methods have been executed once, so its time to exit the loop.

                } while (innerCondition);


                LastMethod();
                Console.WriteLine();


                Console.ReadLine();

            } while (outerCondition);
        }
    }
}
