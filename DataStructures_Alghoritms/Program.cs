using static System.Console;
using static System.Math;
using static System.Random;
static bool IsValid(string s)
{
    Dictionary<char, char> dic = new Dictionary<char, char>();
    dic.Add('(', ')');
    dic.Add('{', '}');
    dic.Add('[', ']');
    for (int i = 0; i < s.Length; i++)
    {
        if (dic.Keys.Contains(s[i]))
        {
            WriteLine(dic[s[i]]);
            if (!dic.Values.Contains(dic[s[i]]))
            {
                return false;
            }
        }
    }
    return true;
}
string x = "{]";
WriteLine(IsValid(x)?"duz":"sehv");

