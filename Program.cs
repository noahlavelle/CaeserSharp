using System;

namespace CaesarShift
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                Console.Write("Encode or decode? (e/d): ");
                var response = Console.ReadLine()?[0].ToString().ToLower();
                switch (response)
                {
                    case "e":
                    {
                        var encode = new Encode(alphabet);
                        break;
                    }
                    case "d":
                    {
                        var decode = new Decode(alphabet);
                        break;
                    }
                    default:
                        continue;
                }

                break;
            }
        }
    }
}