public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var sdict = s.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        var tdict = t.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        
        foreach (var (character, count) in sdict)
        {
            if (!tdict.TryGetValue(character, out var tCount) || tCount != count)
                return false;
        }
        return true;
    }
}
