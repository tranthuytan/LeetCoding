using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCoding
{
    public class SolutionForNo5
    {
        public static (int, string) GetLongestPalindromicSubString(string s)
        {
            if (s.Length==1)
                return (1, s);
            (int, string) result = (0, "");
            bool hasPalindromicSubString = false;
            bool toReverseCompareString = false;
            for (int noOfPalindromicCharacter = 1; noOfPalindromicCharacter < s.Length / 2 + 1; noOfPalindromicCharacter++)
            {
                //for palindromic next to each other
                for (int startIndex = 0; startIndex < s.Length; startIndex++)
                {
                    try
                    {
                        string toBeCompared = s.Substring(startIndex, noOfPalindromicCharacter);
                        string palindromicNextToEachOtherToCompare = s.Substring(startIndex + noOfPalindromicCharacter, noOfPalindromicCharacter);
                        if (toReverseCompareString)
                        {
                            char[] toBeComparedCharArray = toBeCompared.ToCharArray();
                            Array.Reverse(toBeComparedCharArray);
                            toBeCompared = new string(toBeComparedCharArray);
                        }
                        if (palindromicNextToEachOtherToCompare == toBeCompared)
                        {
                            hasPalindromicSubString = true;

                            if (toBeCompared.Length + palindromicNextToEachOtherToCompare.Length > result.Item1)
                            {
                                result.Item2 = toBeCompared + palindromicNextToEachOtherToCompare;
                                result.Item1 = result.Item2.Length;

                            }
                        }
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        break;
                    }
                }
                //for palindromic with a separator
                for (int startIndex = 0; startIndex < s.Length; startIndex++)
                {
                    try
                    {
                        string toBeCompared = s.Substring(startIndex, noOfPalindromicCharacter);
                        string separator = s.Substring(startIndex + noOfPalindromicCharacter, 1);
                        string palindromicWithACharacterInBetweenToCompare = s.Substring(startIndex + noOfPalindromicCharacter+1, noOfPalindromicCharacter);

                        char[] charArray = toBeCompared.ToCharArray();
                        Array.Reverse(charArray);
                        var toBeComparedAfterReverse = new string(charArray);
                        if (palindromicWithACharacterInBetweenToCompare == toBeComparedAfterReverse)
                        {
                            hasPalindromicSubString = true;
                            if (toBeCompared.Length + separator.Length + palindromicWithACharacterInBetweenToCompare.Length > result.Item1)
                            {
                                result.Item2 = toBeCompared + separator + palindromicWithACharacterInBetweenToCompare;
                                result.Item1 = result.Item2.Length;
                            }
                        }
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        break;
                    }
                }
                toReverseCompareString = true;
            }
            if (!hasPalindromicSubString)
            {
                result.Item1 = 0;
                result.Item2 = "";
            }
            
            return result;
        }
    }
}
