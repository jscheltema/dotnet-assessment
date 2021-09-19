using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public int Count(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("value is missing.");
            }

            int nVowel = 0;
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            foreach (var c in value.ToLower().ToCharArray())
            {
                foreach (var v in vowels)
                {
                    if (v == c)
                    {
                        ++nVowel;
                        break;
                    }
                }
            }

            return nVowel;
        }
    }
}
