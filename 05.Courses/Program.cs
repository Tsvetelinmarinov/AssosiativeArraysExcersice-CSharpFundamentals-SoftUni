/*
 * 05.Courses
 */

namespace _05.Courses;

class Program
{
    static void Main()
    {
        //= debug =>
        //Programming Fundamentals : John Smith 
        //Programming Fundamentals : Linda Johnson
        //JS Core : Will Wilson
        //Java Advanced : Harrison White
        //end
        //= debug =//

        Dictionary<string, List<string>> courses = new();
        List<string> courseDefinition = Console.ReadLine()!
            .Split(" : ")
            .ToList();

        while (!courseDefinition[0].Equals("end"))
        {
            if (courses.ContainsKey(courseDefinition[0]))
            {
                courses[courseDefinition[0]].Add(courseDefinition[1]);
            }
            else
            {
                courses.Add(courseDefinition[0], new List<string>());
                courses[courseDefinition[0]].Add(courseDefinition[1]);
            }

            courseDefinition = Console.ReadLine()!
                .Split(" : ")
                .ToList();
        }

        foreach ((string module, List<string> students) in courses)
        {
            Console.WriteLine($"{module}: {students.Count}");
            foreach (string student in students)
            {
                Console.WriteLine($"-- {student}");
            }
        }
    }
}