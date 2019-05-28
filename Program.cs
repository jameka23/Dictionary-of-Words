using System;
using System.Collections.Generic;

namespace dictionaryWords
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Create a dictionary with key value pairs to
            represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("success", "The matter of never giving up.");
            wordsAndDefinitions.Add("failure", "The act of giving up.");
            wordsAndDefinitions.Add("happy", "A state of true contentment.");
            wordsAndDefinitions.Add("love", "I don't know.");


            /*
                Use square bracket lookup to get the definition two
                words and output them to the console
            */
            Console.WriteLine(wordsAndDefinitions["happy"]);
            Console.WriteLine(wordsAndDefinitions["failure"]);


            /*
                Loop over dictionary to get the following output:
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }
            
        }
    }
}
