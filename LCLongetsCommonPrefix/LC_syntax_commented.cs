using System.Linq;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {

        //catch if the string array has no elements. Any() check if there are any elements in the collection that match a condition.
        //leaving Any() conditionless will check if there are any elements that exist at all.
        if (!strs.Any())
        {
            return string.Empty;
        }

        //we will track the longest substring here and return this value at the end
        var longestSubstring = string.Empty;

        //using Linq to get the shortest string in the set since it's the maximum size for the substring.
        //we will order it by length in ascending order, and then take the first value in the list
        var shortestString = strs.OrderBy(x => x.Length).First();

        var index = 0;

        //iterating through the shortest string letter by letter
        while (index < shortestString.Length)
        {
            //we will take the letter at the current index and use it to compare to every other string in the set
            var letter = shortestString[index];

            //Linq All() is a boolean check to see if every member of the set meets a condition.
            //the lambda statement is checking if the letter at [index] of each string (x) matches the
            //letter we took earlier.
            //Lambda syntax is: collectionName.MethodName(<variable> => <do this to each variable>);
            if (!strs.All(x => x[index].Equals(letter)))
            {
                //if the letter didn't match we can stop checking the strings and return our result
                return longestSubstring;
            }

            //if the letter matched, add it to the substring and move on to the next letter
            longestSubstring += letter;
            index++;
        }

        return longestSubstring;
    }
}