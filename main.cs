// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math

using System;

class Program{
    public static void Main(string[] args)
    {
        // This function states user's address input.
        string streetName;
        int streetNumber;
        Console.WriteLine("This program will retell you your street name and street number.");
        Console.WriteLine("");
        
        Console.Write("Enter your street name: ");
        streetName = Console.ReadLine();
        Console.Write("Enter your street number: ");
        streetNumber = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("");
        Console.WriteLine("Your address is: " + streetNumber + " " + streetName + ".");
        
        Console.WriteLine("\nDone.");
    }
}