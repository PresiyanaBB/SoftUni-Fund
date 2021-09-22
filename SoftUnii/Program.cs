using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUnii
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = new List<string>();
            phones = Console.ReadLine().Split(", ").ToList();

            string[] command = Console.ReadLine().Split(" - ").ToArray();
            string[] oldPhone = command[1].Split(":").ToArray();
            while (command[0] != "End")
            {
                oldPhone = command[1].Split(":").ToArray();

                if (command[0] == "Add" && !phones.Contains(command[1]))
                {
                    phones.Add(command[1]);
                }
                else if (command[0] == "Remove" && phones.Contains(command[1]))
                {
                    phones.Remove(command[1]);
                }
                else if (command[0] == "Bonus phone" && phones.Contains(oldPhone[0]))
                {
                    phones.Insert(phones.IndexOf(oldPhone[0])+1,oldPhone[1]);
                }
                else if (command[0] == "Last" && phones.Contains(command[1]))
                {
                    phones.Remove(command[1]);
                    phones.Add(command[1]);
                }

                command = Console.ReadLine().Split(" - ").ToArray();
            }

            Console.WriteLine(string.Join(", ",phones));
        }
    }
}
