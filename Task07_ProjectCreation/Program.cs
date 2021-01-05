using System;

namespace Task07_ProjectCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int timePerProject = 3;
            int timeForAllProjects = numberOfProjects * timePerProject;          
            Console.WriteLine($"The architect {name} will need {timeForAllProjects} hours to complete {numberOfProjects} project/s.");
        }
    }
}
