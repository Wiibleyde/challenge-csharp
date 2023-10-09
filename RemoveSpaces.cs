namespace CSharpDiscovery.Quest01
{
    public class RemoveSpaces_Exercice
    {
        public static string RemoveSpaces(string str)
        {
            string toReturn = "";
            int i = 0;
            while (i < str.Length && str[i] == ' ') {
                i++;
            }
            int j = str.Length - 1;
            while (j >= 0 && str[j] == ' ') {
                j--;
            }
            while (i <= j) {
                toReturn += str[i];
                i++;
            }
            return toReturn;
        }
    }
}
