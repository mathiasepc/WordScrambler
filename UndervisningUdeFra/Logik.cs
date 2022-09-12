using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using static System.Net.Mime.MediaTypeNames;

namespace UndervisningUdeFra
{
    internal class Logik
    {
        public int score = 0;

        public string[] answer1 = {"network", "computer", "system", "loop"};

        public string? temp;

        public bool check = false;


        /// <summary>
        /// laver en metode som placere bogstaverne på ordet random.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public string Scrambler(string word)
        {
            //laver en temp for at kunne samligne svar med det rigtige ord
            temp = word;
            //laver en liste char som er lige med ordets længde. Sådan så det passer
            char[] chars = new char[word.Length];
            Random rand = new Random();
            int index = 0;

            //laver while så den læser hele ordet.
            while (word.Length > 0)
            {
                int next = rand.Next(0, word.Length - 1); // Take the character from the random position 
                                                          // And add to our char array. 
                chars[index] = word[next];                // Remove the character from the word. 
                word = word.Substring(0, next) + word.Substring(next + 1);
                ++index;

            }
            //laver en chekker for at det er et random ord.
            if(temp != new string(chars))
            {
                check = true;
            }
            return new String(chars);
        }

        /// <summary>
        /// i er det ord vi er nået til. svar er det som man skriver.
        /// </summary>
        /// <param name="answer"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public string CompareAnswer(string answer, int i)
        {
            //hvis svar er det samme som i arrayet.
            if (answer == answer1[i])
            {
                score++;
                return "The answer is correct";
            }
            else
            {
                return "Uncorrect answer";
            }
        }
    }
}

