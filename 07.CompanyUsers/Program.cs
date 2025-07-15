/// <summary>
///  07.CompanyUsers
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main()
        {        
            List<string> def = [.. Console.ReadLine()!.Split("->", StringSplitOptions.TrimEntries)];

            Dictionary<string, List<string>> companies = [];

            while (!def[0].Equals("End"))
            {
                string companyName = def[0];
                string workerId = string.Empty;

                if (def.Count > 1)
                {
                    workerId = def[1];
                }

#pragma warning disable CA1854
                if (companies.ContainsKey(companyName))
                {
                    bool isSameId = companies[companyName].Contains(workerId);
                    if (!isSameId)
                    {
                        companies[companyName].Add(workerId);                       
                    }
                }
#pragma warning restore CA1854 
                else
                {
#pragma warning disable IDE0028 
                    companies.Add(companyName, new List<string>() { workerId });
#pragma warning restore IDE0028 
                }

                def = [.. Console.ReadLine()!.Split("->", StringSplitOptions.TrimEntries)];
            }

            foreach ((string company, List<string> workers) in companies)
            {
                Console.WriteLine(company);
                workers.ForEach(workerNumber => Console.WriteLine($"-- {workerNumber}"));
            }
        }
    }
}
