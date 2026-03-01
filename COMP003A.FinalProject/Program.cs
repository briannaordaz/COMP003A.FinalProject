// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using COMP003A.FinalProject;

//Event Registration System

class Program
{
    static void Main(string[] args)
    {
        //List that stores multiple registration objects
        List<Registration> registrations = new List<Registration>();
        
        
        int choice = 0;
        
        Console.WriteLine("Welcome to Event Registration!");
        
        Console.WriteLine("1. Enter Event\n2. View Events\n3. Search Events\n4. Display Event Statistics\n5. Exit");
        do
        {
            
            Console.WriteLine("Please enter a valid choice.");
            choice = int.Parse(Console.ReadLine());
            
            if (choice < 1 || choice > 5)
            {
                
                
            }
            else if (choice == 1)
            {
                
            }
            else if (choice == 2)
            {
                
            }
            else if (choice == 3)
            {
                
            }
            else if (choice == 4)
            {
                
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            
        }
        while(choice != 5);
        
        
        
        
    }
}
