/*
 * 02.AMinerTask
 */

using System;
using System.Collections.Generic;

namespace _02.AMinerTask;

class Program
{
    static void Main()
    {
        Dictionary<string, ulong> resourceQuantities = new();
        string resource = Console.ReadLine()!;
        ulong quantity = default;
        while (!resource.Equals(value: "stop"))
        {        
            quantity = ulong.Parse(s: Console.ReadLine()!);
            if (resourceQuantities.ContainsKey(key: resource))
            {
                resourceQuantities[resource] += quantity;
            }
            else
            {
                resourceQuantities.Add(key: resource, value: quantity);
            }

            resource = Console.ReadLine()!;
        }

        foreach (KeyValuePair<string, ulong> pair in resourceQuantities)
        {
            Console.WriteLine(value: $"{pair.Key} -> {pair.Value}");
        }
    }
}