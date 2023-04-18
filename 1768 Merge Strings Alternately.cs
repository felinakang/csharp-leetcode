using System;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int len = word1.Length + word2.Length;
        int j = 0;
        char[] word3 = new char[len];
        for (int i = 0; i < len; i++)
        {
            if (j < word1.Length && j < word2.Length)
            {
                word3[i] = word1[j];
                word3[i + 1] = word2[j];
                i += 1;
                j += 1;
            }
            else if (j < word1.Length && j >= word2.Length)
            {
                word3[i] = word1[j];
                j += 1;
            }
            else if (j >= word1.Length && j < word2.Length)
            {
                word3[i] = word2[j];
                j += 1;
            }
        }
        return new string(word3);
    }
}
