public class Solution {
    public bool IsAnagram(string s, string t) {
        var sdict = s.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        var tdict = t.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        if (sdict.Count != tdict.Count)
            return false;
        foreach (var (character, count) in sdict)
        {
            if (!tdict.TryGetValue(character, out var tCount) || tCount != count)
                return false;
        }
        return true;
    }
}
