using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main()
        {
            string[] answer = new string[50];
            //Auxiliary searching variable
            bool searchResult;
            string[] matchingActors = new string[50];

            //War

            string[] warActors = {"Richard Burton","Clint Eastwood","Jamie Foxx","Jake Gyllenhaal","Marlon Brando","Harrison Ford","Robert Duvall"
                                 ,"Tom Hanks","Kirk Douglas","Mel Gibson","Vincent D'Onofrio","R. Lee Ermey","Adam Baldwin","Johnny Depp","Charlie Sheen","Willem Dafoe"
                                 ,"Gerard Butler","Michael Fassbender","Ralph Fiennes","Jeremy Renner"};

            string[] warActresses = { "Lena Headey", "Evangeline Lilly" };

            string[] dramaActors = {"Cary Grant","Bruce Willis","Haley Joel Osment","Leonardo DiCaprio","Joseph Gordon-Levitt",
                                    "Anthony Perkins","Matt Damon","Jack Nicholson","Mark Wahlberg","Morgan Freeman", "Brad Pitt", "Kevin Spacey"
                                    "Gabriel Byrne", "Chazz Palminteri", "Stephen Baldwin","Anthony Hopkins","Jason Statham", "Benicio Del Toro",
                                    "Harvey Keitel","Tim Roth","Michael Madsen","Chris Penn","Russell Crowe"," Guy Pearce","Jason Flemyng",
                                    "Dexter Fletcher","Nick Moran","Jason Statham"};

            string[] dramaActresses = {"Grace Kelly","Toni Collette","Janet Leigh","Jodie Foster","Kim Basinger" };

            string[] scifiActors = {"Tom Hardy","George Clooney","Mark Hamill","Adam Driver", "John Boyega", "Adam Driver", "Harrison Ford",
                                    "Tom Skerritt","Harrison Ford","Alec Guinness","Chris Pine", "Zachary Quinto", "Leonard Nimoy", "Karl Urban","Arnold Schwarzenegger",
                                    "Kevin McCarthy", "Dana Wynter", "Matt Damon","Jeff Daniels","Ryan Gosling","Sam Neill","Jeff Goldblum","Keir Dullea", "Gary Lockwood",
                                    "William Sylvester", "Daniel Richter", "Rutger Hauer","Edward James Olmos","Sam Worthington","Keanu Reeves", "Laurence Fishburne", "Joe Pantoliano",
                                    "Malcolm McDowell", "Patrick Magee","Aubrey Morris"};

            string[] scifiActresses = {"Charlize Theron","Drew Barrymore","Sandra Bullock","Carrie Fisher","Daisy Ridley","Sigourney Weaver", "Linda Hamilton","Jessica Chastain",
                                        "Kristen Wiig","Laura Dern","Sean Young","Zoe Saldana","Carrie-Anne Moss","Adrienne Corri"};

            string[] horrorActors = {"Kevin Bacon", "Cillian Murphy", "Johnny Depp", "Anthony Hopkins", "Simon Pegg", "Nick Frost", "Chris Hemsworth", "Bill Skarsgard", "James McAvoy" };

            string[] horrorActresses = { "Janet Leigh", "Linda Blair", "Sissy Spacek", "Jamie Lee Curtis", "Jodi Foster", "Naomi Watts", "Natalie Portman", "Kristen Connolly" };

            string[] familyActors = {"Ian McKellen","Viggo Mortensen", "Orlando Bloom","Macaulay Culkin","Daniel Radcliffe", "Rupert Grint","Cary Elwes","Mandy Patinkin","Dan Stevens",
                                    "Luke Evans", "Ben Stiller","Max Records","Forest Whitaker", "Pepita Emmerichs","Johnny Depp", "Jim Carrey", "Jude Law", "Liam Aiken","Daniel Craig",
                                    "Johnny Depp","Tommy Lee Jones", "Will Smith"};

            string[] familyActresses = {"Cate Blanchett","Liv Tyler","Emma Watson","Robin Wright","Angelina Jolie", "Elle Fanning","Carla Gugino","Catherine O'Hara","Helena Bonham Carter",
                                        "Mia Wasikowska","Anne Hathaway","Meryl Streep","Nicole Kidman","Dakota Blue Richards","Kiera Knightly",};

            string[] actionActors = {"Quentin Tarantino","Arnold Schwarzenegger","Edward Furlong","Keanu Reeves","Hugo Weaving","Laurence Fishburne","Bruce Willis","Alan Rickman","Harrison Ford",
                                     "Christian Bale","Michael Caine","Heath Ledger","Gary Oldman","Bill Paxton","Matt Damon","Robert Downey Jr.","Chris Evans","Mark Ruffalo","Chris Hemsworth",
                                        "Will Smith","Jeff Goldblum","Mel Gibson","Liam Neeson","Anthony Hopkins","Tom Hiddleston","Hugo Weaving","Samuel L. Jackson","Chris Pratt","Vin Diesel",
                                        "Bradley Cooper","Paul Rudd","Michael Douglas","Corey Stoll","Benedict Cumberbatch","Chiwetel Ejiofor", "Tom Holland","Michael Keaton","Chadwick Boseman",
                                        "Jude Law"};

            string[] actionActresses = {"Brie Larson","Rachel McAdams","Evangeline Lilly","Zoe Saldana","Natalie Portman","Scarlett Johansson","Famke Janssen","Maggie Grace","Uma Thurman",
                                        "Lucy Liu","Linda Hamilton","Carrie-Anne Moss","Sigourney Weaver","Julia Stiles","Gwyneth Paltrow","Milla Jovovich"};


            Console.Write("Type Answer: ");
            answer[0] = Console.ReadLine();
            answer[0] = answer[0].ToLower();

            for (int i = 0; i < warActors.Length; i++)
            {
                //Searchs inside the array for any instance of the string answer[0] lowercased
                searchResult = warActors[i].ToLower().Contains(answer[0]);
                if (searchResult)
                {
                    Console.WriteLine("The word is contained in slot {0}", i);
                    matchingActors[i] = warActors[i];
                }
            }

            Console.WriteLine("Perhaps you meant ?");

            //Shows Found candidates for answer[0]
            for (int i = 0; i < matchingActors.Length; i++)
            {
                if (matchingActors[i] != null) Console.WriteLine(matchingActors[i]);
            }
            Console.WriteLine("Line");



            Console.WriteLine();

            foreach (var item in warActors)
            {
                Console.WriteLine(item);
            }
            
            /*
            int[] warDecade = {1950,1960,1970,1980,1990,2000,2010};

            answer[1] = Console.ReadLine();
            int answer1 = Convert.ToInt32(answer[1]);

            double year = (double)answer1/10;
            year = Math.Round(year)*10;

            Console.WriteLine("This is the closest year to the given year; {0}",year);
            */

            Console.ReadLine();
        }
    }
}
