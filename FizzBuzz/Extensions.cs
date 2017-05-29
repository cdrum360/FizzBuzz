namespace FizzBuzz
{
    public static class Extensions
    {
        public static bool IsDivisibleByThree(this int i) => i % 3 == 0;
    
        public static bool IsDivisibleByFive(this int i) => i % 5 == 0;
        
    }
}
