using System;

public class GreetingProgram
{
	public Class1()
	{
        Console.WriteLine("Enter your name: ");
        String name = Console.ReadLine();
        Console.WriteLine("Enter the total number of your enrolled courses: ");
        int courses = Console.Read();
        Console.WriteLine("Enter the price of your favourite book: ");
        int price = Console.Read();

        Console.WriteLine(" ");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Total enrolled courses: " + courses);
        Console.WriteLine("price of my favourite book: " + price);
    }
}
