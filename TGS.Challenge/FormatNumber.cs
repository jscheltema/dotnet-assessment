using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the
        decimal representation of that number grouped by commas after every 3 digits. 
        
        NOTES: You cannot use any built-in formatting functions to complete this task.

        Assume: 0 <= n < 1000000000

        1 -> "1"
        10 -> "10"
        100 -> "100"
        1000 -> "1,000"
        10000 -> "10,000"
        100000 -> "100,000"
        1000000 -> "1,000,000"
        35235235 -> "35,235,235"

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class FormatNumber
    {
        public string Format(int value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Negative numbers not supported.");
            }

            if (value > 1000000000)
            {
                throw new ArgumentOutOfRangeException("Number too large.");
            }

            if (value < 1000)
            {
                return value.ToString();
            }

            string resultString = string.Empty;

            string valueString = value.ToString();
            int firstCommaIndex = valueString.Length % 3;


            if (firstCommaIndex != 0)
            {
                resultString = valueString.Substring(0, firstCommaIndex) + ",";
            }

            for (int j = firstCommaIndex; j < valueString.Length; j += 3)
            {
                resultString += valueString.Substring(j, 3);

                if (j + 3 < valueString.Length)
                {
                    resultString += ",";
                }
            }
            
            return resultString;
        }
    }
}
