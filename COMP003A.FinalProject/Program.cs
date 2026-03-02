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
            Console.WriteLine("Please enter a menu option (1-5): ");
            
            try
            {
                
                choice = int.Parse(Console.ReadLine());


                

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input.");
                break;
            }

            switch (choice)
            {
                case 1:
                    NewEventRegistration();
                    break;
                case 2:
                    
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    Console.WriteLine("Goodbye.");
                    break;
            }

        } while (choice != 5);


    }
    
    
    static public void NewEventRegistration()
    { 
        Registration userRegistration = new Registration(); //An object named userRegistration that stores fields from the Registration class
        
        
        //Personal Information
        Console.WriteLine("Enter First Name: "); 
        userRegistration.FirstName = Console.ReadLine(); //Saves user input into the FirstName field of the "userRegistration" Object
        
        Console.WriteLine("Enter Last Name: ");
        userRegistration.LastName = Console.ReadLine(); //Saves user input into the LastName field of the "userRegistration" Object
        
        Console.WriteLine("Enter Age: ");
        userRegistration.Age = Convert.ToInt32(Console.ReadLine()); //converts user input into an integer and saves it in the Age field of the "userRegistration" Object
        
        Console.WriteLine("Enter Email: ");
        userRegistration.Email = Console.ReadLine();
            
        Console.WriteLine("Enter Phone Number: ");
        userRegistration.PhoneNumber = Console.ReadLine();
            
        Console.WriteLine("Enter Address: ");
        userRegistration.Address = Console.ReadLine();
        
        Console.WriteLine("Enter Country: ");
        userRegistration.Country = Console.ReadLine();
        
        Console.WriteLine("Enteer City: ");
        userRegistration.City = Console.ReadLine();
        
        Console.WriteLine("Enter ZipCode: ");
        userRegistration.ZipCode = Console.ReadLine();
        
        
        //Event Information: 
        Console.WriteLine("Enter Event Name: ");
        userRegistration.EventName = Console.ReadLine();

        Console.WriteLine("Enter Event Date (mm/dd/yyyy): ");
        userRegistration.EventDate = Convert.ToDateTime(Console.ReadLine());
        
        Console.WriteLine("Enter Ticket Type (General or VIP): ");
        userRegistration.Ticket = Console.ReadLine();
        
        Console.WriteLine("Enter Ticket ID: ");
        userRegistration.TicketID = Console.ReadLine();

        Console.WriteLine("Enter Seat Section (1-300): ");
        userRegistration.SeatSection = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Seat Row (A-Z): ");
        userRegistration.SeatRow = char.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter Seat Number: ");
        userRegistration.SeatNumber = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Registration Date (MM/dd/yyyy): ");
        userRegistration.RegistrationDate = Convert.ToDateTime(Console.ReadLine());
        
        Console.WriteLine("Have you attended This Event? (y/n): ");
        userRegistration.Attendence = Convert.ToBoolean(Console.ReadLine());
        
        Console.WriteLine("Do you need Assistance during this event? (y/n): ");
        userRegistration.AssistanceNeeded = Convert.ToBoolean(Console.ReadLine());
        
        Console.WriteLine("Have you paid for the ticket? (y/n): ");
        userRegistration.paid = Convert.ToBoolean(Console.ReadLine());
      
        
        //Payment Information
        Console.WriteLine("Enter Payment Method (cash or card) ");
        userRegistration.PaymentMethod = Console.ReadLine();
        registrations.Add(userRegistration);

        Console.WriteLine("Enter Cardholder Name: ");
        userRegistration.CardHolder = Console.ReadLine();
        
        Console.WriteLine("Enter Card Number: ");
        userRegistration.CardNumber = Console.ReadLine();
        
        Console.WriteLine("Enter Expiration Date (MM/yyyy): ");
        userRegistration.Expiration = Console.ReadLine();
        
        Console.WriteLine("Enter Security Code: ");
        userRegistration.SecurityCode = Console.ReadLine();
        
        
        registrations.Add(userRegistration); //This adds the object to the registration list







    }


}




