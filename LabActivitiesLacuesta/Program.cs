using System;
using System.Collections.Generic;

class Program
{
    static List<string> names = new List<string>();
    static List<int> grade1 = new List<int>();
    static List<int> grade2 = new List<int>();
    static List<int> grade3 = new List<int>();

    static void Main()
    {
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("===== STUDENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Compute Average Grade");
            Console.WriteLine("4. Find Highest Grade");
            Console.WriteLine("5. Exit");
            Console.WriteLine("==========================");
            Console.Write("Choose an option: ");

            choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;

                case 2:
                    ViewStudents();
                    break;

                case 3:
                    ComputeAverageGrade();
                    break;

                case 4:
                    FindHighestGrade();
                    break;

                case 5:
                    Console.WriteLine("Exiting program...");
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddStudent()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter grade 1: ");
        int g1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter grade 2: ");
        int g2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter grade 3: ");
        int g3 = Convert.ToInt32(Console.ReadLine());

        names.Add(name);
        grade1.Add(g1);
        grade2.Add(g2);
        grade3.Add(g3);

        Console.WriteLine("Student added successfully!");
    }

    static void ViewStudents()
    {
        if (names.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        for (int i = 0; i < names.Count; i++)
        {
            double average = (grade1[i] + grade2[i] + grade3[i]) / 3.0;

            Console.WriteLine("Name: " + names[i]);
            Console.WriteLine("Grades: " + grade1[i] + ", " + grade2[i] + ", " + grade3[i]);
            Console.WriteLine("Average: " + average.ToString("F2"));
            Console.WriteLine();
        }
    }

    static void ComputeAverageGrade()
    {
        if (names.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        double total = 0;

        for (int i = 0; i < names.Count; i++)
        {
            total += (grade1[i] + grade2[i] + grade3[i]) / 3.0;
        }

        double overallAverage = total / names.Count;

        Console.WriteLine("===== CLASS AVERAGE =====");
        Console.WriteLine("Overall Average Grade: " + overallAverage.ToString("F2"));
    }

    static void FindHighestGrade()
    {
        if (names.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        int highestGrade = grade1[0];
        string topStudent = names[0];

        for (int i = 0; i < names.Count; i++)
        {
            if (grade1[i] > highestGrade)
            {
                highestGrade = grade1[i];
                topStudent = names[i];
            }

            if (grade2[i] > highestGrade)
            {
                highestGrade = grade2[i];
                topStudent = names[i];
            }

            if (grade3[i] > highestGrade)
            {
                highestGrade = grade3[i];
                topStudent = names[i];
            }
        }

        Console.WriteLine("===== HIGHEST GRADE =====");
        Console.WriteLine("Top Student: " + topStudent);
        Console.WriteLine("Highest Grade: " + highestGrade);
    }
}