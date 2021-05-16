using System;
using System.Diagnostics;
using System.Linq;

namespace CaesarShift
{
    public class Decode
    {
        public Decode(char[] alphabet)
        {
            Console.Write("Enter max scan count: ");
            var maxScanCount = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.Write("Enter ciphertext: ");
            var input = Console.ReadLine();

            for (var i = 0; i < maxScanCount; i++)
            {
                if (input == null) continue;
                Console.Write($"\n{i}: ");
                foreach (var c in input)
                {
                    var isUpperCase = Char.IsUpper(c);
                    if (alphabet.Contains(Char.ToLower(c)))
                    {
                        var shiftedCharacter = alphabet[(Array.IndexOf(alphabet, char.ToLower(c)) + i) % alphabet.Length];
                        if (isUpperCase) shiftedCharacter = char.ToUpper(shiftedCharacter);
                        Console.Write(shiftedCharacter);
                    }
                    else
                    {
                        Console.Write(c);
                    }
                }
            } 
        }
    }
}