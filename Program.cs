// See https://aka.ms/new-console-template for more information
using Leettest;

Console.WriteLine("Hello, World!");


Solution solution = new Solution();

//bool result = solution.hasDuplicate([1, 2, 3, 3]);

//var resultIsAnagram = solution.IsAnagram("racecar", "ds");

var resultGroupAnagram = solution.GroupAnagramsHash(["act", "pots", "tops", "cat", "stop", "hat"]);
Console.WriteLine($"has duplicate{resultGroupAnagram}");