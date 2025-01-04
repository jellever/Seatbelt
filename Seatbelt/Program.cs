using System;

namespace Seatbelt
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine($"Test");
            Console.WriteLine($"Remote change");
            try
            {
                using var sb = (new Seatbelt(args));
                sb.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unhandled terminating exception: {e}");
            }
        }
    }
}
