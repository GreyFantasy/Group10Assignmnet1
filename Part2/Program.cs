using System.IO;
using System;
public class Program
{

    public static void Main()
    {
        string textPath = "Assignment1TestText.txt";
        if (!File.Exists(textPath))
        {
            Console.WriteLine("File does not exist/was not found");
            return;
        }

        foreach (string line in File.ReadLines(textPath))
        {
            Console.WriteLine($"Input:\"{line}\"");
            Console.WriteLine("Output");
            Console.WriteLine(GetFrequency(line));
        }

    }

// gets the frequency of alphabets
static string GetFrequency(string line)
{
    int[] freq = new int[26];

    foreach (char c in line)
    {
        if (c >= 'a' && c <= 'z')
            freq[c - 'a']++;
    }

    string result = " ";
    bool first = true;

    for (int i = 0; i < 26; i++)
    {
        if (freq[i] >= 0)
        {
        if (!first) result += ",";
            result += $"{(char)('a' + i)}: {freq[i]}";
            first = false;
        }
    }
    return result;

}

}