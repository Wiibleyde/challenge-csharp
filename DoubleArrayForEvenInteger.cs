using System.Linq.Expressions;

namespace CSharpDiscovery.Quest01
{
    public class DoubleArrayForEvenInteger_Exercice
    {
        public static int[] DoubleArrayForEvenInteger(int[] inputTab)
        {   
            List < int > toReturn = new List < int > ();
            foreach (var element in inputTab) {
                if (element % 2 != 0) {
                    int ele = element * 2;
                    toReturn.Add(ele);
                } else {
                    toReturn.Add(element);
                }
            }
            return toReturn.ToArray();
        }
    }
}