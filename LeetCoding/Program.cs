using LeetCoding;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Main() for 5: Longest palindromic substring
Dictionary<string, int> testcaseForNo5 = new Dictionary<string, int>();
//palindromic next to each other
testcaseForNo5.Add("aab", 2);
testcaseForNo5.Add("aaqwertyuiopsdfghjklzxcvbnm", 2);
testcaseForNo5.Add("abb", 2);
testcaseForNo5.Add("qwertyuiopasdfghjklzxcvbnmm", 2);
//palindromic with a character in center
testcaseForNo5.Add("aba", 3);
testcaseForNo5.Add("babad", 3);
testcaseForNo5.Add("abaqwertyuiopsdfghjklzxcvnm", 3);
testcaseForNo5.Add("qwertyuiopsdfghjklzxcvnmaba", 3);
testcaseForNo5.Add("abcba", 5);
testcaseForNo5.Add("abcbac", 5);
testcaseForNo5.Add("abcbacdefg", 5);
testcaseForNo5.Add("banana", 5);
//no palindromic
testcaseForNo5.Add("abcdba", 0);
testcaseForNo5.Add("qwertyuiopasdfghjklzxcvbnm", 0);
testcaseForNo5.Add("ac", 0);

int noOfTestCase = testcaseForNo5.Count;
int noOfCurrentTestCase = 1;
foreach (var test in testcaseForNo5)
{

    var result = SolutionForNo5.GetLongestPalindromicSubString(test.Key);
    if (result.Item1 != test.Value)
    {
        Console.WriteLine($"Test {noOfCurrentTestCase++}: Failed. Input: {test.Key} - expected: {test.Value} - actual: {result.Item1}");
    }
    else
    {
        Console.WriteLine($"Test {noOfCurrentTestCase++}: Passed. Input: {test.Key} - expected: {test.Value} - actual: {result.Item1}");
    }
}
#endregion
//Console.WriteLine("asdfhjkl".Substring(0,2)); // output: as