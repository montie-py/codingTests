// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;

class Program {

    static void Main() {
        Utils utils = new Utils();
        int here = utils.FirstUniqueCharacter("loveleetcode");
        Console.WriteLine(here);
    }
}

public sealed class Utils
{
    public int FirstUniqueCharacter(string str) {
        if (String.IsNullOrEmpty(str)) {
            return -1;
        }

        Dictionary<char, int> words = new();

        foreach(char letter in str.ToCharArray()) {
            words[letter] = words.ContainsKey(letter) ? words[letter]+1 : 1;
            // int count = words.Contains(letter) ? ((int)words[letter]!)+1 : 0;
        }

        SortedSet<int> set = new();

        foreach(KeyValuePair<char, int> kvp in words) {
            if (kvp.Value == 1) {
                set.Add(str.IndexOf(kvp.Key));
            }
        }

        if (set.Count > 0) {
            return set.FirstOrDefault();
        }

        return -1;
    }
}
