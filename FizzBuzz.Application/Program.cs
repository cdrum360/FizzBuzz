using System;
using System.Linq;

namespace FizzBuzz.Application
{
    public class Program
    {
        private static void Main()
        {
            PlayFizzBuzz(100);
        }

        private static void PlayFizzBuzz(int limit)
        {
            foreach (var i in Enumerable.Range(1, limit))
            {
                var fb = new FizzBuzz();
                fb.FormulateResponse(i);
                fb.OutputResponse();
            }

            Console.ReadLine();
        }
    }
}
