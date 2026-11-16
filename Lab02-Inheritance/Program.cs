using System;

interface IPrintable
{
    void Print();
}

interface IShowable
{
    void Show();
}

class Student : IPrintable, IShowable
{
    public void Print()
    {
        Console.WriteLine("Printing student details");
    }

    public void Show()
    {
        Console.WriteLine("Displaying student details");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s.Print();
        s.Show();
        Console.WriteLine("\n\t By Krishna Aryal");
    }
}