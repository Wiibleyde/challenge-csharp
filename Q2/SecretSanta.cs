using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDiscovery.Quest02
{
    public class SecretSanta_Exercice
    {
        public static Dictionary<string, string> SecretSantaDraw(HashSet<string> people)
        {
            // if (people == null || people.Count < 2) {
            //     throw new ArgumentException("There should be at least two people for a Secret Santa draw.");
            // }

            List<string> peopleList = people.ToList();
            Dictionary<string, string> santaAssignments = new Dictionary<string, string>();
            Random random = new Random();

            List<string> shuffledPeople = peopleList.OrderBy(x => random.Next()).ToList();

            for (int i = 0; i < shuffledPeople.Count; i++) {
                string giver = shuffledPeople[i];
                string receiver = shuffledPeople[(i + 1) % shuffledPeople.Count];
                santaAssignments[giver] = receiver;
            }

            return santaAssignments;
        }
    }
}
