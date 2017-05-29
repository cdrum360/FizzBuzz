using System;

namespace FizzBuzz
{
    public class FizzBuzz : IGiveResponse
    {
        public string Response { get; set; }

        public void FormulateResponse(int input)
        {
            Response = FizzBuzzAlgorithm(input);
        }

        public void OutputResponse()
        {
            Console.WriteLine(Response);
        }

        public static string FizzBuzzAlgorithm(int turn)
        {
            var output = string.Empty;

            if (turn.IsDivisibleByThree()) output = "Fizz";
            if (turn.IsDivisibleByFive()) output += "Buzz";
            if (output == string.Empty) output = turn.ToString();

            return output;
        }

    }
}
