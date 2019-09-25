using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KristenActors
{
    class Program
    {
        private static string[] question = new string[60]; //global array storing questions WE have created
        private static string[] answer = new string[60]; //global array storing user answers
        // answer[i]: 0-9 => Method1(Conor), 10-19 => Method2(Kristen), 20-29 => Method3(Kristen), 30-39 => Method4(Jack), 
        //40-49 =>  Questions(Johny), 50-59 => Method0(Francisco),60-69 => Main(Francisco);
        private static Random rand = new Random();
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
        Console.Write("Please Type five actors that you know or like\n");

            for (int i = 13; i <18; i++)
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
                    counter --;
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
                    indexK=Convert.ToInt32(Console.ReadLine());
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
            for (int i = 13; i < 18; i++)
            {
                Console.Write("  " + answer[i] + "  ");
            }
            Console.Write("\nAnswer: ");
            answer[18] = Console.ReadLine();



        Console.WriteLine();
        }
        static void Main()
        {

            MaleActors();

            Console.ReadLine();
        }
    }
}
