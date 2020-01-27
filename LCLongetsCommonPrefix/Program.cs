using System;
using System.Linq;

namespace LCLongetsCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new string[] { };


            Console.WriteLine(LongestCommonPrefix(strs));

            string LongestCommonPrefix(string[] strs)
            {
                if (!strs.Any())
                {
                    return string.Empty;
                }
                    
                var longestSubstring = string.Empty;

                var shortestString = strs.OrderBy(x => x.Length).First();

                var index = 0;

                while (index < shortestString.Length)
                {
                    var letter = shortestString[index];

                    if (!strs.All(x => x[index].Equals(letter)))
                    {
                        return longestSubstring;
                    }
                    longestSubstring += letter;
                    index++;
                }

                return longestSubstring;
            }
        }
    }
}
