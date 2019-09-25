using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KristenActresses
{
    class Program
    {
        private static string[] question = new string[60]; //global array storing questions WE have created
        private static string[] answer = new string[60]; //global array storing user answers
        // answer[i]: 0-9 => Method1(Conor), 10-19 => Method2(Kristen), 20-29 => Method3(Kristen), 30-39 => Method4(Jack), 
        //40-49 =>  Questions(Johny), 50-59 => Method0(Francisco),60-69 => Main(Francisco);
        private static Random rand = new Random();
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
            Console.Write("Please Type five actors that you know or like\n");

            for (int i = 23; i < 28; i++)
            {
                //Asks for an actor
                Console.Write("\nActor {0}: ", counter);
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
                    Console.WriteLine("Sorry. This actor is not in my database");
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
            for (int i = 23; i < 28; i++)
            {
                Console.Write("  " + answer[i] + "  ");
            }
            Console.Write("\nAnswer: ");
            answer[28] = Console.ReadLine();



            Console.WriteLine();
        }
        static void Main()
        {

            Actresses();

            Console.ReadLine();
        }
    }
}
