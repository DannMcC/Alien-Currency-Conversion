using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallenge
{
    class Program
    {
        public static void Main(string[] args)
        {
            var data = new[]
            {
                2, // K, number of sets
                2, /* D */ 2, /* N */
                2,
                2, 0,
                0, 5,
                3, 3,
                3, 5,
                1, 1, 1,
                3, 0, 0,
                1, 10, 0
            };

            var i = 0;

            foreach (var item in GetDataSets(data))
            {
                Console.WriteLine($"Data Set {++i}:");
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<int> GetDataSets(int[] data)
        {
            var queue = new Queue<int>(data);
            var count = queue.Dequeue();

            for (var i = 0; i < count; i++)
            {
                var denominationCount = queue.Dequeue();
                var priceCount = queue.Dequeue();
                var exchangeRates = new int[denominationCount - 1];

                for (var r = 0; r < exchangeRates.Length; r++)
                {
                    exchangeRates[r] = queue.Dequeue();
                }

                var prices = new int[priceCount];

                for (var p = 0; p < priceCount; p++)
                {
                    var price = 0;

                    for (var d = 0; d < denominationCount; d++)
                    {
                        var denomination = queue.Dequeue();

                        if (d < exchangeRates.Length)
                        {
                            price += denomination * exchangeRates[d];
                        }
                        else
                        {
                            price += denomination;
                        }
                    }

                    prices[p] = price;
                }

                yield return prices.Max() - prices.Min();
            }
        }
    }
}
