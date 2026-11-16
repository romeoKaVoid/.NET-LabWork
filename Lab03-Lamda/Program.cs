using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public int DepartmentId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Student s = new Student();

            Console.WriteLine("\nStudent " + (i + 1));

            Console.Write("ID: ");
            s.Id = int.Parse(Console.ReadLine());

            Console.Write("Department ID: ");
            s.DepartmentId = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Address: ");
            s.Address = Console.ReadLine();

            students.Add(s);
        }

        Console.Write("\nEnter Department ID to filter: ");
        int deptId = int.Parse(Console.ReadLine());

        var result = students.Where(
            s => s.DepartmentId == deptId);

        Console.WriteLine("\nFiltered Student List:");

        foreach (var s in result)
        {
            Console.WriteLine(
                $"{s.Id} {s.Name} {s.Address}");
        }
    }
}