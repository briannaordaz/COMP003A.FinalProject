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

        userRegistration.GeneralPrice = 50;
        userRegistration.VIPPrice = 100;
        
        //Personal Information
        Console.WriteLine("Enter Age: ");
        userRegistration.Age = Convert.ToInt32(Console.ReadLine()); //converts user input into an integer and saves it in the Age field of the "userRegistration" Object
        if (userRegistration.Age < 16)
        {
            Console.WriteLine("You are too young to register. ");
            return;
        }
        
        Console.WriteLine("Enter First Name: "); 
        userRegistration.FirstName = Console.ReadLine(); //Saves user input into the FirstName field of the "userRegistration" Object
        
        Console.WriteLine("Enter Last Name: ");
        userRegistration.LastName = Console.ReadLine(); //Saves user input into the LastName field of the "userRegistration" Object
        
        Console.WriteLine("Enter Email: ");
        userRegistration.Email = Console.ReadLine();
            
        Console.WriteLine("Enter Phone Number: ");
        userRegistration.PhoneNumber = Console.ReadLine();
            
        Console.WriteLine("Enter Address: ");
        userRegistration.Address = Console.ReadLine();
        
        Console.WriteLine("Enter Country: ");
        userRegistration.Country = Console.ReadLine();
        
        Console.WriteLine("Enter City: ");
        userRegistration.City = Console.ReadLine();
        
        Console.WriteLine("Enter ZipCode: ");
        userRegistration.ZipCode = Console.ReadLine();
        
        Console.WriteLine("Enter Registration Date (MM/dd/yyyy): ");
        userRegistration.RegistrationDate = Convert.ToDateTime(Console.ReadLine());

        
        
        //Event Information: 
        Console.WriteLine("Enter Event Name: ");
        userRegistration.EventName = Console.ReadLine();

        Console.WriteLine("Enter Event Date (mm/dd/yyyy): ");
        userRegistration.EventDate = Convert.ToDateTime(Console.ReadLine());
        
        
        Console.WriteLine("1. General \n2. VIP ");
        Console.WriteLine("Enter Ticket Type (1 or 2): "); //selection
        int userChoice = int.Parse(Console.ReadLine());
        if (userChoice == 1)
        {
            userRegistration.Ticket = "General";
            Console.WriteLine($"The General Ticket is ${userRegistration.GeneralPrice}" );
        }
        else if (userChoice == 2)
        {
            userRegistration.Ticket = "VIP";
            Console.WriteLine("The VIP Ticket is $" + userRegistration.VIPPrice);
        }
        else
        {
            Console.WriteLine("Only choose between 1 and 2!!");
            return;
        }
        
        
        Console.WriteLine("Enter Ticket ID: "); 
        userRegistration.TicketID = Console.ReadLine();
        
        
        //Seat Information
        Console.WriteLine("Enter Seat Section (1-300): "); 
        userRegistration.SeatSection = Convert.ToInt32(Console.ReadLine());

        if (userRegistration.SeatSection < 1 || userRegistration.SeatSection > 300)
        {
            Console.WriteLine("Invalid Seat Section. Please enter a seat in the sections 1-300");
            return;
        }
        else
        {
            
            
            Console.WriteLine("Enter Seat Row (A-Z): ");
            string row = Console.ReadLine().ToUpper();
            
            if (string.IsNullOrEmpty(row))
            {
                
                
                Console.WriteLine("Please enter a row (A-Z)");
                return;
                
            }
            userRegistration.SeatRow = row[0];
            
             if (userRegistration.SeatRow < 'A' || userRegistration.SeatRow > 'Z')
            {
                Console.WriteLine("Invalid Seat Row. Please enter a seat in the rows A-Z");
                return;
            }
            else
            {




                Console.WriteLine("Enter Seat Number (1-20): ");
                userRegistration.SeatNumber = Convert.ToInt32(Console.ReadLine());

                if (userRegistration.SeatNumber < 1 || userRegistration.SeatNumber > 20)
                {
                    Console.WriteLine("Invalid Seat Number. Please enter a seat in the range 1-20");
                    return;
                }
                else
                {
                    Console.WriteLine("Seat successfully entered. ");
                }

            }

        }
        
        
        //Attendance information
        Console.WriteLine("Have you attended this Event? (y/n): ");
        string Attendance = Console.ReadLine().ToUpper();
        userRegistration.Attendance = (Attendance == "Y");
        
        if (userRegistration.Attendance)
        {
            Console.WriteLine("Your information is saved in the system! ");
        }
        else 
        {
            Console.WriteLine("Do you need Assistance during this event? (y/n): ");
            string AssistanceNeeded = Console.ReadLine().ToUpper();
            userRegistration.AssistanceNeeded = (AssistanceNeeded == "Y");
            
            Console.WriteLine("Have you paid for the ticket? (y/n): ");
            string paid = Console.ReadLine().ToUpper();
            userRegistration.Paid = (paid == "Y");

            if (!userRegistration.Paid)
            {
                Console.WriteLine("Enter Payment Method (Cash or Card) ");
                userRegistration.PaymentMethod = Console.ReadLine();
                
                
                //Payment Information
                if (userRegistration.PaymentMethod.ToLower() == "card")
                {
                    
                    Console.WriteLine("Enter Cardholder Name: ");
                    userRegistration.CardHolder = Console.ReadLine();
                    
                    Console.WriteLine("Enter Card Number: ");
                    userRegistration.CardNumber = Console.ReadLine();
        
                    Console.WriteLine("Enter Expiration Date (MM/yyyy): ");
                    userRegistration.Expiration = Console.ReadLine();
        
                    Console.WriteLine("Enter Security Code: ");
                    userRegistration.SecurityCode = Console.ReadLine();
                }
                else if (userRegistration.PaymentMethod.ToLower() == "cash")
                {
                    Console.WriteLine("We'll save your information in the system so you can pay once you arrive to the event!! ");   
                }
                else
                {
                    Console.WriteLine("Please choose between Cash or Card!");
                    return;
                }
                
                

            }

            
        }
        
        
        registrations.Add(userRegistration); //This adds the object to the registration list



    }

    
    
    

}




