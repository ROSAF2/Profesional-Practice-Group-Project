using System;

namespace Method_3_Actresses
{
    class Actresses
    {
        static void Main()
        {
            string[] answer = new string[50];
            //Auxiliary searching variable
            bool searchResult;
            string[] matchingActors = new string[50];

            string[] warActresses = { "Lena Headey", "Evangeline Lilly" };
            string[] dramaActresses = { "Grace Kelly", "Toni Collette", "Janet Leigh", "Jodie Foster", "Kim Basinger" };
            string[] scifiActresses = {"Charlize Theron","Drew Barrymore","Sandra Bullock","Carrie Fisher","Daisy Ridley","Sigourney Weaver", "Linda Hamilton","Jessica Chastain",
                                        "Kristen Wiig","Laura Dern","Sean Young","Zoe Saldana","Carrie-Anne Moss","Adrienne Corri"};
            string[] horrorActresses = { "Janet Leigh", "Linda Blair", "Sissy Spacek", "Jamie Lee Curtis", "Jodi Foster", "Naomi Watts", "Natalie Portman", "Kristen Connolly" };
            string[] familyActresses = {"Cate Blanchett","Liv Tyler","Emma Watson","Robin Wright","Angelina Jolie", "Elle Fanning","Carla Gugino","Catherine O'Hara","Helena Bonham Carter",
                                        "Mia Wasikowska","Anne Hathaway","Meryl Streep","Nicole Kidman","Dakota Blue Richards","Kiera Knightly",};
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
