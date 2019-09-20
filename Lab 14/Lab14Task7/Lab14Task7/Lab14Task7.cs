using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14Task7
{
    class Lab14Task7
    {
        static void Main()
        {
            string phrase = "The quick brown fox jumps over the lazy dog  ";

            //Copying the sentence
            string newPhrase = string.Copy(phrase);

            //Adding the word hairy before brown
            newPhrase = phrase.Insert(phrase.IndexOf("brown"), "hairy ");

            //Replacing the word dog with chicken
            newPhrase = newPhrase.Replace("dog", "chicken");

            //Trimming the two spaces at the end
            newPhrase = newPhrase.TrimEnd();

            //Displaying sentences
            Console.WriteLine("Original sentence:".PadRight(25) + phrase);
            Console.WriteLine("New sentence:".PadRight(25) + newPhrase);

            //Converting to lower and upper
            Console.WriteLine("\n{0}", newPhrase.ToLower());
            Console.WriteLine("{0}", newPhrase.ToUpper());

            Console.WriteLine();

            // TASK 7

            //Spliting the sentence
            string[] dividedNewPhrase = newPhrase.Split(' ');
            //Declaring an accumulation variable
            string finalPhrase = "";


            for (int i = 0; i < dividedNewPhrase.Length; i++)
            {
                //Substracting the first letter by stating the index "0" and the amount of charcaters "1" and converting them to upper.
                //dividedNewPhrase[i].Substring(0,1).ToUpper();

                //Substracting all the letters after the first one
                //dividedNewPhrase[i].Substring(1);

                //Concatenating
                finalPhrase = finalPhrase + dividedNewPhrase[i].Substring(0, 1).ToUpper() + dividedNewPhrase[i].Substring(1) + " ";

            }

            //Printing result and trimming the last space
            Console.Write(finalPhrase.TrimEnd());

            Console.ReadLine();
        }
    }
}
