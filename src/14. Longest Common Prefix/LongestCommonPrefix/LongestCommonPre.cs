namespace LeetCodeSolution
{
    public class LongestCommonPre
    {
        public static string CommonPrefix(string[] strs)
        {
            var commonString = string.Empty;
            for (var i = 1; i <= strs.First().Length; i++)
            {
                var sbstring = strs[0].Substring(0, i);
                if (strs.All(a => a.StartsWith(sbstring)))
                {
                    commonString = sbstring;
                }
                else
                {
                    break;
                }
            }

            return commonString;
        }
    }
    
}
