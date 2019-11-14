using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Shirish";
            int cohort = 34;

            name = "Jissie";
            cohort = 35;

            string greeting = "Hello " + name + ", Welcome to cohort" + cohort;
            // string interpolation
            string greeting2 = $"Hello {name}, Welcome to cohort {cohort}";

            bool isTheBest = cohort == 35;
            if (isTheBest)
            {
                Console.WriteLine("Ah, the best around");
            }
            else if (name == "Jisie")
            {
                Console.WriteLine("Well, not in the right cohort");
            }
            else
            {
                Console.WriteLine("You may... want to rethink your decision");
            }

            int[] cohorts = new int[] { 34, 35, 36, 37 };

            for (int i = 0; i < cohorts.Length; i++)
            {
                Console.WriteLine($"Cohort {cohorts[i]}");
            }

            foreach (int item in cohorts)
            {
                Console.WriteLine($"Cohort {item}");
            }

            Console.WriteLine(greeting2);

            while (cohort > 0)
            {
                cohort--;
                Console.WriteLine(cohort);

            }

        }
    }
}