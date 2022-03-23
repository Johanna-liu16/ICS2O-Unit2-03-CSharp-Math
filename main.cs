// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        string streetNumber;
        int streetName;

        Console.WriteLine("This program gets a user's street number and street name.");
        Console.WriteLine("");

        Console.Write("Enter your street number: ");
        streetNumber = Console.ReadLine();
        Console.Write("Enter your street name: ");
        streetName = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Your address is: " + streetNumber +" " + streetName + ".");

        Console.WriteLine("\nDone.");
    }
}