using System;
using System.Collections.Generic;

namespace dictionary
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
            wordsAndDefinitions.Add("Beautiful", "How C# looks now");
            wordsAndDefinitions.Add("Amazing", "The things you can do with C#");
            wordsAndDefinitions.Add("Brilliant", "The feeling of students when they master C#");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */

            string value1 = wordsAndDefinitions["Awesome"];
            Console.WriteLine(value1);
            string value2 = wordsAndDefinitions["Brilliant"];
            Console.WriteLine(value2);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
             */

            foreach (KeyValuePair<string, string> definitions in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {definitions.Key} is {definitions.Value}");
            }

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "active");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list

            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> happyWord = new Dictionary<string, string>()
            { { "word", "happy" }, { "definition", "having, showing, or characterized by a heightened state of joy" }, { "part of speech", "active" }, { "example sentence", "I am so happy to find a new job" }
            };

            dictionaryOfWords.Add(happyWord);

            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> i in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> wordData in i)
                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                };
            }

            //ANOTHER EXERCISE

            Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
            idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
            idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
            idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
            idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
            idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
            idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
            idioms.Add("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
            idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
            idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
            idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

            foreach (var item in idioms)
            {
                string key = item.Key;
                List<string> values = item.Value;

                Console.WriteLine(key + " : " + string.Join(" ", values) + "");
            }
        }
    }
}