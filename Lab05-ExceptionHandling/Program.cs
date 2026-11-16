using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter product price: ");

            decimal price = decimal.Parse(
                Console.ReadLine());

            Console.WriteLine(
                "Product price: " + price);
        }
        catch (FormatException)
        {
            Console.WriteLine(
                "Error: Please enter a numeric price.");
        }
    Console.WriteLine("\n\t By Krishna Aryal");
    }
}