namespace CSharpDiscovery.Quest01
{
    public class GetStringSize_Exercice
    {
        public static int GetStringSize(string str)
        {
            int toReturn = 0;
            foreach (char c in str) {
                toReturn++;
            }
            return toReturn;
        }
    }
}