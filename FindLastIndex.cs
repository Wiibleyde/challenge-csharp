namespace CSharpDiscovery.Quest02
{
    public class FindLastIndex_Exercice
    {
        public static int? FindLastIndex(int[] tab, int a)
        {   
            if (tab == null) {
                return null
            }
            int result = System.Array.LastIndexOf(tab, a);
            if (result == -1) {
                return null;
            }
            return result;
        }
    }
}
