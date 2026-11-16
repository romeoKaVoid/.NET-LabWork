using System;
using System.Collections.Generic;
using System.Linq;

class Voter
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Address { get; set; } = string.Empty;
}

class Program
{
    static void Main()
    {
        List<Voter> voters = new List<Voter>()
        {
            new Voter
            {
                Name = "Ram",
                Age = 20,
                Address = "Patan"
            },
            new Voter
            {
                Name = "Hari",
                Age = 17,
                Address = "Kathmandu"
            },
            new Voter
            {
                Name = "Prash",
                Age = 20,
                Address = "Patan"
            },
            new Voter
            {
                Name = "Gita",
                Age = 22,
                Address = "Thamel"
            }
        };

        var result = voters
            .Where(v => v.Age > 18 &&
                        v.Address == "Patan")
            .Select(v => v.Name);

        Console.WriteLine("Eligible voter names:");

        foreach (var name in result)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("\n\t By Krishna Aryal");
    }
}