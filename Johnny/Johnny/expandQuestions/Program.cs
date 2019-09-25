using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expandQuestions
{
    class Program
    {
        private static string[] question = new string[60]; //global array storing questions WE have created
        private static string[] answer = new string[60]; //global array storing user answers
        // answer[i]: 0-9 => Method1(Conor), 10-19 => Method2(Kristen), 20-29 => Method3(Kristen), 30-39 => Method4(Jack), 
        //40-49 =>  Questions(Johnny), 50-59 => Method0(Francisco),60-69 => Main(Francisco);
        private static Random rand = new Random();


        public static void johnny()
        {
            //Questions
            question[40] = "Why do you prefer this genre?";
            question[41] = "Do you like other genres?";
            question[42] = "Why do you prefer this movie/title";
            question[43] = "On a scale from 1-5 how did you like the movie?";
            question[44] = "Do you like other movies/titles?";
            question[45] = "Why do you like this actor/actress?";
            question[46] = "Do you like other actors/actresses?";
            question[47] = "Does the year when they come out affect if you would watch it?";
            question[48] = "Why do you prefer this director?";
            question[49] = "Do you like any other directors?";

            //answers to the question
            string[] preferGenreAnswers = { "Visual Effects", "Its my favorite genre", "Funny", "It makes me cry :(", "My favorite actor/actress plays in these types of genres", "Other" };
            string[] likeGenreAnswers = { "Yes", "No" };
            string[] preferMovieAnswers = { "My favorite actor/actress is in this movie", "I like these types of movies", "Funny", "Its Intense", "Other" };
            string[] scaleMovieAnswers = { "1", "2", "3", "4", "5" };
            string[] otherMovieAnswers = { "Yes", "No" };
            string[] likeActorAnswers = { "Reminds me of myself", "They are my favourite actor/actress", "They are funny", "I like their personality", "Other" };
            string[] otherActorAnswers = { "Yes", "No" };
            string[] yearAffectAnswers = { "Yes", "No" };
            string[] preferDirectorAnswers = {"They are my favorite director", "They direct my favorite movies", "Other"  };
            string[] likeDirectorAnswers = { "Yes", "No"};


               



            for (int i = 40; i < 50; i++)
            {
                //Question 40 - 49
                Console.WriteLine("\n" + question[i] +"\n");
                for (int j = 0; j < preferGenreAnswers.Length; j++)
                {
                    Console.WriteLine(preferGenreAnswers[j]);
                    
                }
                //This makes it so the answers show up under the right questions
                preferGenreAnswers = likeGenreAnswers;
                likeGenreAnswers = preferMovieAnswers;
                preferMovieAnswers = scaleMovieAnswers;
                scaleMovieAnswers = otherMovieAnswers;
                otherMovieAnswers = likeActorAnswers;
                likeActorAnswers = otherActorAnswers;
                otherActorAnswers = yearAffectAnswers;
                yearAffectAnswers = preferDirectorAnswers;
                preferDirectorAnswers = likeDirectorAnswers;



                Console.WriteLine();
                answer[i] = Console.ReadLine();
                Console.Clear();
                


            }
        }
        static void Main(string[] args)


        {
            johnny();




        }
    }
}
