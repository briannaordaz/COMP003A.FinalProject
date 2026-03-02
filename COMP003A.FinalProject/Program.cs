// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using COMP003A.FinalProject;

//Event Registration System

class Program
{
    
    //List that stores multiple registration objects
    static List<Registration> registrations = new List<Registration>();

    
    static void Main(string[] args)
    {
      

       

        Console.WriteLine("Welcome to Event Registration!");

        Console.WriteLine("1. Enter Event\n2. View Events\n3. Search Events\n4. Display Event Statistics\n5. Exit");
        
        int choice = 0;
        
        
        do
        {
            
            
            try
            {
                Console.WriteLine("Please enter a menu option (1-5): ");
                choice = int.Parse(Console.ReadLine());


                if (choice < 1 || choice > 5)
                {
                    Console.WriteLine("Please enter a valid choice.");

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
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input.");
                break;
            }

        } while (choice != 5);


    }
    
    
    static public void NewEventRegistration()
    { 
        Registration userRegistration = new Registration();
        
        
        //Personal Information
        Console.WriteLine("Enter First Name: ");
        userRegistration.FirstName = Console.ReadLine();
        registrations.Add(userRegistration);
        
        Console.WriteLine("Enter Last Name: ");
        userRegistration.LastName = Console.ReadLine();
        registrations.Add(userRegistration);
        
        Console.WriteLine("Enter Age: ");
        userRegistration.Age = Convert.ToInt32(Console.ReadLine());
        registrations.Add(userRegistration);
        
        Console.WriteLine("Enter Email: ");
        userRegistration.Email = Console.ReadLine();
        registrations.Add(userRegistration);
            
        Console.WriteLine("Enter Phone Number: ");
        userRegistration.PhoneNumber = Console.ReadLine();
        registrations.Add(userRegistration);
            
        Console.WriteLine("Enter Address: ");
        userRegistration.Address = Console.ReadLine();
        registrations.Add(userRegistration);
        
        Console.WriteLine("Enter Country: ");
        userRegistration.Country = Console.ReadLine();
        registrations.Add(userRegistration);
        
        Console.WriteLine("Enteer City: ");
        userRegistration.City = Console.ReadLine();
        registrations.Add(userRegistration);
        
        Console.WriteLine("Enter ZipCode: ");
        userRegistration.ZipCode = Console.ReadLine();
        registrations.Add(userRegistration);
        
        
        //Event Information: 
        Console.WriteLine("Enter Event Name: ");
        userRegistration.EventName = Console.ReadLine();
        registrations.Add(userRegistration);

        Console.WriteLine("Enter Event Date: ");
        userRegistration.EventDate = Convert.ToDateTime(Console.ReadLine());
        registrations.Add(userRegistration);
        
        Console.WriteLine("Enter Ticket Type (General or VIP): ");
        userRegistration.Ticket = Console.ReadLine();
        registrations.Add(userRegistration);




    }


}
