using System;
using System.Collections.Generic;

namespace _08___Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var friends = new List<string> { "Frank", "Joe", "Michelle", "Andy", "Maria", "Carlos", "Angelina" };
            var partyFriends = GetPartyFriends(friends, 4);

            foreach (var name in partyFriends)
                Console.WriteLine(name);

            Console.Read();
        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            var partyFriends = new List<string>();

            while (partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(list);
                partyFriends.Add(currentFriend);
                list.Remove(currentFriend);
            }
            return partyFriends;
        }

        private static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Length > shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;
        }
    }
}
