using System;
using System.Collections.Generic;

namespace TGS.Challenge
{
    /*
          Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
          one another return true, else return false

          "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
          phrase to produce a new word or phrase, using all the original letters exactly once; for example
          orchestra can be rearranged into carthorse.

          areAnagrams("horse", "shore") should return true
          areAnagrams("horse", "short") should return false

          NOTE: Punctuation, including spaces should be ignored, e.g.

          horse!! shore = true
          horse  !! shore = true
            horse? heroes = true

          There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
       */
    public class Anagram
    {
        // get unique characters from the word, with counts of occurences
        private Dictionary<char, int> CreateWordCharCount(string word)
        {
            var chars = word.ToCharArray();
            var charCount = new Dictionary<char, int>();

            foreach (var c in chars)
            {
                if (char.IsLetter(c))
                {
                    if (charCount.ContainsKey(c))
                    {
                        ++charCount[c];
                    }
                    else
                    {
                        charCount[c] = 1;
                    }
                }
            }

            return charCount;
        }

        public bool AreAnagrams(string word1, string word2)
        {
            if (string.IsNullOrEmpty(word1))
            {
                throw new ArgumentException("word1 is missing.");
            }

            if (string.IsNullOrEmpty(word2))
            {
                throw new ArgumentException("word2 is missing.");
            }

            word1 = word1.ToLower();
            word2 = word2.ToLower();

            var word1CharCount = CreateWordCharCount(word1);
            var word2CharCount = CreateWordCharCount(word2);

            if (word1CharCount.Count != word2CharCount.Count)
            {
                return false;
            }

            foreach (var kvp in word1CharCount)
            {
                if (!word2CharCount.ContainsKey(kvp.Key) || word2CharCount[kvp.Key] != kvp.Value)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
