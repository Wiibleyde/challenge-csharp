namespace CSharpDiscovery.Quest01
{
    public class RemoveSpaces_Exercice
    {
        public static string RemoveSpaces(string str)
        {
            string toReturn = "";
            foreach (char ch in str) {
                if (ch != ' ') {
                    toReturn = toReturn + ch;
                }
            }
            return toReturn;
        }
    }
}
