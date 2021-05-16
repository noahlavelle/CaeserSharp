using System;
using System.Linq;

namespace CaesarShift
{
    public class Encode
    {
        public Encode(char[] alphabet)
        {
            Console.Write("Enter plaintext: ");
            var input = Console.ReadLine();
            foreach (var c in (input ?? string.Empty))
            {
                var shiftIndex = (Array.IndexOf(alphabet, char.ToLower(c)) + 13) % alphabet.Length;
                Console.Write(!alphabet.Contains(Char.ToLower(c)) ? c : alphabet[shiftIndex]);
            }
        }
    }
}