using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectTesting.Config
{
    public class DynamicEmail
    {
        private static readonly Random _random = new Random();

        // Generate a random string of characters (letters and digits)
        public static string GenerateRandomChars(int length = 15)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            var sb = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                char randomChar = chars[_random.Next(chars.Length)];
                sb.Append(randomChar);
            }
            return sb.ToString();
        }

        // Generate a random string of letters (uppercase)
        public static string GenerateRandomName(int length = 15)
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var sb = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                char randomChar = letters[_random.Next(letters.Length)];
                sb.Append(randomChar);
            }
            return sb.ToString();
        }
    }
}
