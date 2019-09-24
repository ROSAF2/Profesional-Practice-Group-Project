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
            
            string[] warActors = {"Richard Burton","Clint Eastwood"
                                 ,"Jamie Foxx","Jake Gyllenhaal"
                                 ,"Marlon Brando","Harrison Ford","Robert Duvall"
                                 ,"Tom Hanks"
                                 ,"Kirk Douglas"
                                 ,"Mel Gibson"
                                 ,"Vincent D'Onofrio","R. Lee Ermey","Adam Baldwin"
                                 ,"Johnny Depp","Charlie Sheen","Willem Dafoe"
                                 ,"Gerard Butler","Michael Fassbender","Lena Headey"
                                 ,"Evangeline Lilly","Ralph Fiennes","Jeremy Renner"
                                 ,"Richard Two"};

            string[] dramaActors = {"Richard Burton","Clint Eastwood"
                                 ,"Jamie Foxx","Jake Gyllenhaal"
                                 ,"Marlon Brando","Harrison Ford","Robert Duvall"
                                 ,"Tom Hanks"
                                 ,"Kirk Douglas"
                                 ,"Mel Gibson"
                                 ,"Vincent D'Onofrio","R. Lee Ermey","Adam Baldwin"
                                 ,"Johnny Depp","Charlie Sheen","Willem Dafoe"
                                 ,"Gerard Butler","Michael Fassbender","Lena Headey"
                                 ,"Evangeline Lilly","Ralph Fiennes","Jeremy Renner"
                                 ,"Richard Two"};

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
