/*
 * 04.SoftUniParking
 */

using System;
using System.Collections.Generic;

namespace _04.SoftUniParking;

class Program
{
    static void Main()
    {
        //= debug =>
        //5 
        //register John CS1234JS
        //register George JAVA123S
        //register Andy AB4142CD
        //register Jesica VR1223EE
        //unregister Andy
        //= debug=//

        Dictionary<string, string> registeredPlates = new();

        int iterations = int.Parse(Console.ReadLine()!);
        for (; iterations > 0; iterations--)
        {
            string[] command = Console.ReadLine()!
                .Split();

            if (command[0].Equals("register"))
            {
                if (registeredPlates.TryAdd(command[1], command[2]))
                {
                    Console.WriteLine($"{command[1]} registered {command[2]} succssesfully");
                }
                else
                {                    
                    Console.WriteLine($"ERROR: already registered with plate number {command[2]}");
                }
            }
            else if (command[0].Equals("unregister"))
            {
                if (registeredPlates.Remove(command[1]))
                {
                    Console.WriteLine($"{command[1]} unregistered successfully");
                }
                else
                {
                    Console.WriteLine($"ERROR: user {command[1]} not found");
                }
            }
        }

        foreach (KeyValuePair<string, string> user in registeredPlates)
        {
            Console.WriteLine($"{user.Key} => {user.Value}");
        }
    }
}