using System;
using System.Collections.Generic;

namespace _08___Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var friends = new List<string> { "Frank", "Joe", "Michelle", "Andy", "Maria", "Carlos", "Angelina" };
            // var friends = new List<string>();
            var partyFriends = GetPartyFriends(friends, 4);

            // foreach (var name in friends)
            //     Console.WriteLine(name);

            foreach (var name in partyFriends)
                Console.WriteLine(name);

            Console.Read();
        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            if (list == null)
                throw new ArgumentNullException("List", "The list is empty");

            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("count", "Count cannot be greater then elements in the list or lower then 0");

            var buffer = new List<string>(list);
            var partyFriends = new List<string>();

            while (partyFriends.Count < count)
            {
                // var currentFriend = GetPartyFriend(list);
                var currentFriend = GetPartyFriend(buffer);
                partyFriends.Add(currentFriend);
                // list.Remove(currentFriend);
                buffer.Remove(currentFriend);
            }
            return partyFriends;
        }

        /// <summary>
        /// This is the logic to figure out who is the partyFriend
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;
        }
    }
}
