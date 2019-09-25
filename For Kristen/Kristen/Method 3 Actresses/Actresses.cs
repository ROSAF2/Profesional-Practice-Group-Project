using System;

namespace Method_3_Actresses
{
    class Actresses
    { 
    private static string[] question = new string[60]; //global array storing questions WE have created
    private static string[] answer = new string[60]; //global array storing user answers
                                                     // answer[i]: 0-9 => Method1(Conor), 10-19 => Method2(Kristen), 20-29 => Method3(Kristen), 30-39 => Method4(Jack), 
                                                     //40-49 =>  Questions(Johny), 50-59 => Method0(Francisco),60-69 => Main(Francisco);
    private static Random rand = new Random();
    

            public static void Method3()
        { 
            //databases of actresses and the genre of movie they star in
            string[] warActresses = { "Lena Headey", "Evangeline Lilly" };
            string[] dramaActresses = { "Grace Kelly", "Toni Collette", "Janet Leigh", "Jodie Foster", "Kim Basinger" };
            string[] scifiActresses = {"Charlize Theron","Drew Barrymore","Sandra Bullock","Carrie Fisher","Daisy Ridley","Sigourney Weaver", "Linda Hamilton","Jessica Chastain",
                                        "Kristen Wiig","Laura Dern","Sean Young","Zoe Saldana","Carrie-Anne Moss","Adrienne Corri"};
            string[] horrorActresses = { "Janet Leigh", "Linda Blair", "Sissy Spacek", "Jamie Lee Curtis", "Jodi Foster", "Naomi Watts", "Natalie Portman", "Kristen Connolly" };
            string[] familyActresses = {"Cate Blanchett","Liv Tyler","Emma Watson","Robin Wright","Angelina Jolie", "Elle Fanning","Carla Gugino","Catherine O'Hara","Helena Bonham Carter",
                                        "Mia Wasikowska","Anne Hathaway","Meryl Streep","Nicole Kidman","Dakota Blue Richards","Kiera Knightly",};
            string[] actionActresses = {"Brie Larson","Rachel McAdams","Evangeline Lilly","Zoe Saldana","Natalie Portman","Scarlett Johansson","Famke Janssen","Maggie Grace","Uma Thurman",
                                        "Lucy Liu","Linda Hamilton","Carrie-Anne Moss","Sigourney Weaver","Julia Stiles","Gwyneth Paltrow","Milla Jovovich"};

            //genreIndex holds a random value for which genre the actresses will be picked from, actressesIndex randomly gets an index of a actress in actressesIndex
            int genreIndex, actressesIndex, count = 0;
            //stores each actresses and their main associated genre
            string[] actressesList = new string[5], splitActresses = new string[2];
            //stores the users actresses choice and their genre
            string[] actressesChoice = new string[2];
            bool retry = true;
            string temp, actressesStyle, recommendActresses = "", actressesName;

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
                                actressesIndex = rand.Next(warActresses.Length);
                                actressesList[count] = warActresses[actressesIndex] + ",War";
                                break;
                            //Chooses a director from the Drama genre
                            case 1:
                                actressesIndex = rand.Next(dramaActresses.Length);
                                actressesList[count] = dramaActresses[actressesIndex] + ",Drama";
                                break;
                            //Chooses a director from the Sci-Fi genre
                            case 2:
                                actressesIndex = rand.Next(scifiActresses.Length);
                                actressesList[count] = scifiActresses[actressesIndex] + ",Sci-Fi";
                                break;
                            //Chooses a director from the horror genre
                            case 3:
                                actressesIndex = rand.Next(horrorActresses.Length);
                                actressesList[count] = horrorActresses[actressesIndex] + ",Horror";
                                break;
                            //Chooses a director from the family genre
                            case 4:
                                actressesIndex = rand.Next(familyActresses.Length);
                                actressesList[count] = familyActresses[actressesIndex] + ",Family";
                                break;
                            //Chooses a director from the action genre
                            case 5:
                                actressesIndex = rand.Next(actionActresses.Length);
                                actressesList[count] = actionActresses[actressesIndex] + ",Action";
                                break;
                        }
                        count++; //goes on to get next random director
                    }


                    Console.WriteLine("\nWhich of the following directors do you like?: \nEnter 'retry' to refresh the list.\n");
                    //Displaying randomly generated options
                    for (int j = 1; j < 6; j++)
                    {
                        Console.WriteLine($"{j}.{actressesList[j - 1]}");
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
                        answer[i] = actressesList[Convert.ToInt32(temp) - 1];
                        retry = true;
                    }
                    count = 0; //Condition to reset the while loop
                    Console.Clear();
                } while (retry == false);
            }

            // temp generate a random director from the chosen directors
            temp = answer[rand.Next(30, 33)];
            // splitDirectors splits the temp value up into two values, the director and the genre they are famous for
            splitActresses = temp.Split(',');
            actressesStyle = splitActresses[1].ToLower();
            actressesName = splitActresses[0]; // saves the directors name into a unique variable

            //gets another director according to the genre the splitDirectors value is associated with
            switch (actressesStyle)
            {
                case "war":
                    recommendActresses = warActresses[rand.Next(warActresses.Length)];
                    break;
                case "drama":
                    recommendActresses = dramaActresses[rand.Next(dramaActresses.Length)];
                    break;
                case "sci-fi":
                    recommendActresses = scifiActresses[rand.Next(scifiActresses.Length)];
                    break;
                case "horror":
                    recommendActresses = horrorActresses[rand.Next(horrorActresses.Length)];
                    break;
                case "family":
                    recommendActresses = familyActresses[rand.Next(familyActresses.Length)];
                    break;
                case "action":
                    recommendActresses = actionActresses[rand.Next(actionActresses.Length)];
                    break;
            }

            //refers the user to a similar actress, and asks if they know them.
            Console.WriteLine($"You enjoy the work of {actressesName}, famous {actressesStyle} actress. Are you familiar with {recommendActresses}, another {actressesStyle} actress?");
            answer[34] = recommendActresses + "," + Console.ReadLine();

            for (int i = 30; i < 33; i++)
            {
                if (answer[i].Contains(recommendActresses) && answer[34].Contains('n'))
                {
                    Console.WriteLine($"You claimed you were not familiar with {recommendActresses}, but you chose them as a liked actress in earlier questions, are you sure you didn't mean yes?");
                    string fixUp;
                    fixUp = Console.ReadLine();
                    if (fixUp.Contains('y'))
                    {
                        Console.WriteLine("Just as I thought!");
                    }
                    else
                    {
                        Console.WriteLine("Mistakes happen!");
                    }
                }
                else if (answer[i].Contains(recommendActresses) && answer[35].Contains('y'))
                {
                    Console.WriteLine($"I know you are familiar with them, you picked {recommendActresses} as a liked actress");
                }
            }

        }
        static void Main(string[] args)
        {
            Method3();

            Console.ReadLine();
        }
    }
}


//Console.Write("Type Answer: ");
//            answer[0] = Console.ReadLine();
//            answer[0] = answer[0].ToLower();

//            for (int i = 0; i < warActresses.Length; i++)
//            {
//                //Searchs inside the array for any instance of the string answer[0] lowercased
//                searchResult = warActresses[i].ToLower().Contains(answer[0]);
//                if (searchResult)
//                {
//                    Console.WriteLine("The word is contained in slot {0}", i);
//                    matchingActresses[i] = warActresses[i];
//                }
//            }

//            Console.WriteLine("Perhaps you meant ?");

//            //Shows Found candidates for answer[0]
//            for (int i = 0; i < matchingActresses.Length; i++)
//            {
//                if (matchingActresses[i] != null) Console.WriteLine(matchingActresses[i]);
//            }
//            Console.WriteLine("Line");



//            Console.WriteLine();

//            foreach (var item in warActresses)
//            {
//                Console.WriteLine(item);
//            }

//            /*
//            int[] warDecade = {1950,1960,1970,1980,1990,2000,2010};

//            answer[1] = Console.ReadLine();
//            int answer1 = Convert.ToInt32(answer[1]);

//            double year = (double)answer1/10;
//            year = Math.Round(year)*10;

//            Console.WriteLine("This is the closest year to the given year; {0}",year);
//            */
//            //string[] answer = new string[50];
//            ////Auxiliary searching variable
//            //bool searchResult;
//            //string[] matchingActresses = new string[50];
//                    static void Main()
//{
//    Console.ReadLine();
//        }
//    }
//}
