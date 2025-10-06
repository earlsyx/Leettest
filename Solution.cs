using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leettest;
public class Solution
{
    // 

    public bool hasDuplicate(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    return true;
                }
            }
        }
        return false;
    }


    public bool IsAnagram(string s, string t)
    {
        //anagram 
        if (s.Length != t.Length)
        {
            return false;
        }

        var sSorted = new string(s.OrderBy(c => c).ToArray());
        var tSorted = new string(t.OrderBy(c => c).ToArray());

        if (sSorted == tSorted)
        {
            return true;
        }

        return false;


    }


    //Sorting o(m * n logn) O(m * n)
    public List<List<string>> GroupAnagram(string[] strs)
    {
        var res = new Dictionary<string, List<string>>();
        foreach (var s in strs)
        {
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);

            string sortedS = new string(charArray);
            if (!res.ContainsKey(sortedS))
            {
                res[sortedS] = new List<string>();
            }

            res[sortedS].Add(s);
        }

        return res.Values.ToList<List<string>>();
    } 

    public List<List<string>> GroupAnagramsHash(string[] strs)
    {
        var res = new Dictionary<string, List<string>>();
        foreach (var s in strs)
        {
            int[] count = new int[26];
            foreach (char c in s)
            {
                count[c - 'a']++;
            }

            string key = string.Join(",", count);
            if (!res.ContainsKey(key))
            {
                res[key] = new List<string>();
            }
            res[key].Add(s);
        }

        return res.Values.ToList<List<string>>();
        
    }



}
