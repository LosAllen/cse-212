using System;
using System.Collections.Generic;

namespace prove_01
{
    public class ArrayUtilities
    {
        /// <summary>
        /// Generates a list of multiples of the given starting number.
        /// </summary>
        /// <param name="start">The starting number.</param>
        /// <param name="count">The number of multiples to generate.</param>
        /// <returns>A list of multiples of the starting number.</returns>
        public static List<double> MultiplesOf(double start, int count)
        {
            var result = new List<double>();
            for (int i = 1; i <= count; i++)
            {
                result.Add(start * i);
            }
            return result;
        }

        /// <summary>
        /// Rotates a list to the right by the given amount.
        /// </summary>
        /// <param name="data">The list to rotate.</param>
        /// <param name="amount">The number of positions to rotate to the right.</param>
        /// <returns>A new list that has been rotated to the right.</returns>
        public static List<int> RotateListRight(List<int> data, int amount)
        {
            // Handle edge cases
            if (data == null || data.Count == 0 || amount <= 0) return data;

            // Calculate the effective rotation
            int count = data.Count;
            amount = amount % count; // In case amount > count

            // Split the list into two parts and combine them
            var rotatedPart = data.GetRange(count - amount, amount);
            var remainingPart = data.GetRange(0, count - amount);

            var result = new List<int>();
            result.AddRange(rotatedPart);
            result.AddRange(remainingPart);

            return result;
        }
    }
}
