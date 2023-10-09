namespace CSharpDiscovery.Quest01
{
    public class ConcatEverything_Exercice
    {
        public static string ConcatEverything(params string[] str)
        {
            string result = "";
            foreach (string s in str) {
                result += s;
            }
            return result;
        }
    }
}