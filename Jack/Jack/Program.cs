    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Jack
    {
        class Program
        {
            private static string[] question = new string[60]; //global array storing questions WE have created
            private static string[] answer = new string[60]; //global array storing user answers
            // answer[i]: 0-9 => Method1(Conor), 10-19 => Method2(Kristen), 20-29 => Method3(Kristen), 30-39 => Method4(Jack), 
            //40-49 =>  Questions(Johny), 50-59 => Method0(Francisco),60-69 => Main(Francisco);
            private static Random rand = new Random();

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
                string temp, directorStyle, reccomendDirector="", directorName;


                //loop to generate three questions and to generate 5 random directors to choose from for each
                for(int i=30;i<33;i++)
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
                        Console.WriteLine($"{j}.{directorList[j-1]}");
                    }
                    //Reading user number choice as string
                    Console.Write("Number: ");
                    temp = Console.ReadLine();
                    if (temp.Contains("retry"))
                    {
                        retry = false;
                    } else
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

            for (int i = 30; i < 33; i++)
            {
                if (answer[i].Contains(reccomendDirector) && answer[34].Contains('n'))
                {
                    Console.WriteLine($"You claimed you were not familiar with {reccomendDirector}, but you chose them as a liked director in earlier questions, are you sure you didn't mean yes?");
                    string fixUp;
                    fixUp = Console.ReadLine();
                    if (fixUp.Contains('y'))
                    {
                        Console.WriteLine("Just as I thought!");
                    } else
                    {
                        Console.WriteLine("Mistakes happen!");
                    }
                } else if (answer[i].Contains(reccomendDirector) && answer[35].Contains('y'))
                {
                    Console.WriteLine($"I know you are familiar with them, you picked {reccomendDirector} as a liked director");
                }
            }

            }
            static void Main(string[] args)
            {
                Method4();

                Console.ReadLine();
            }
        }
    }
