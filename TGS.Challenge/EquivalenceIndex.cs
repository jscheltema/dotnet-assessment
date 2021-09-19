using System;

namespace TGS.Challenge
{
    /*
         Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
         are equal to the sum of all the items to the right of the index.

         Constraints: 0 <= N <= 100 000

         Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
         Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

         If no index exists then output -1

         There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
       */

    public class EquivalenceIndex
    {
        public int Find(int[] numbers)
        {
            if (numbers.Length == 0 || numbers.Length > 100000)
            {
                throw new ArgumentException("Array length invald.");
            }

            int total = 0;
            foreach (int n in numbers)
            {
                total += n;
            }

            int index = 1;
            int left = numbers[0];
            int right = total - (left + numbers[index]);
            while (index < numbers.Length - 1)
            {
                if (left == right)
                {
                    return index;
                }

                left += numbers[index];
                right = total - (left + numbers[index + 1]);

                ++index;
            }

            return -1;

        }
    }
}
