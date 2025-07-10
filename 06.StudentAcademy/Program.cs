/// <summary>
/// 06.StudentAcademy 
/// </summary>

namespace _06.StudentAcademy;

using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<float>> grades = [];
        int count = int.Parse(Console.ReadLine()!);
        
        for (; count > 0; count--)
        {
            string student = Console.ReadLine()!;
            float grade = float.Parse(Console.ReadLine()!);

#pragma warning disable CA1854
            if (grades.ContainsKey(student))
            {
                grades[student].Add(grade);
            }
#pragma warning restore CA1854
            else
            {
#pragma warning disable IDE0028
            grades.Add(student, new List<float>() { grade });
#pragma warning restore IDE0028
            }
        }

        grades = grades
            .Where(pair => GetAverage(pair.Value) >= 4.50)
            .ToDictionary();

        foreach (KeyValuePair<string, List<float>> pair in grades)
        {
            if (pair.Value.Count > 1)
            {
                Console.WriteLine($"{pair.Key} -> {GetAverage(pair.Value):F2}");
            }
            else if (pair.Value.Count == 1)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value[0]:F2}");
            }
            else
            {
                Console.WriteLine("Empty list of grades or non positive index");
            }
        }
    }

    /// <summary>
    ///  Calculate the average of a collection of real numbers (float)
    /// </summary>
    /// <param name="numbers">The collection witch average will be found</param>
    /// <returns></returns>
    static float GetAverage(List<float> numbers)
    {
        float sum = default;
        foreach (float number in numbers)
        {
            sum += number;
        }

        return sum /= numbers.Count;
    }
}