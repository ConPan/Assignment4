// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void MyFourthMethod(string word)
    {
        Console.WriteLine($"Please enter a {word}");
        string userName = Console.ReadLine();
        Console.WriteLine(userName);
    }

    static void Main(string[] args)
    {
        MyFourthMethod("girl name");
    }
}
