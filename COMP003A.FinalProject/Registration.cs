namespace COMP003A.FinalProject;

public class Registration
{
    //Personal Information
    public string FirstName; //Prompt Example: Enter first name:
    public string LastName; //Enter last name:
    public int Age; //Enter Age:
    public string Email; //Enter Email:
    public string PhoneNumber; //Enter Phone Number:
    public string Address; //Enter Address:
    public string City; //Enter City:
    public string State; //Enter State:
    public string Country; //Enter Country:
    public string ZipCode; //Enter ZipCode:
    
    //Event Information
    public string EventName; //Enter Event Name:
    public DateTime EventDate; //Format: (mm/dd/yyyy)
    public string Ticket; //Enter Ticket Type (General or VIP):
    public string TicketID; //Enter Ticket ID:
    public int SeatSection; //Enter Seat Section (1-300):
    public char SeatRow; //Enter Seat Row (A-Z): 
    public int SeatNumber; //Enter Seat Number (1-20): 
    public DateTime RegistrationDate; //Format: (mm/dd/yyyy)
    public bool Attendance;
    public bool AssistanceNeeded; //Do you need assistance in the event? (y/n): 
    public bool Paid; //Have you paid for the ticket? (y/n)
    public int GeneralPrice = 50;  //price of General ticket
    public int VIPPrice = 100; //price of VIP ticket
    public int Price;
    
    //Payment Information
    public string PaymentMethod; //Enter Payment Method (cash or card):
    public string CardHolder; //Enter CardHolder Name:
    public string CardNumber; //Enter Card Number:
    public string Expiration; //Enter Expiration Date:
    public string SecurityCode; //Enter Security Code: 


    
    public Registration()
    {
       

    }
    
    public void DisplayRegistrations()
    {
        
        Console.WriteLine($"Ticket ID: {TicketID}");
        Console.WriteLine($"User Registered: {FirstName} {LastName}");
        Console.WriteLine($"Event Name: {EventName}");
        Console.WriteLine($"Event Date: {EventDate}");
        Console.WriteLine($"Ticket Type: {Ticket}");
        Console.WriteLine($"Seat Section: {SeatSection}, Seat Row: {SeatRow}, Seat Number: {SeatNumber} | {SeatSection}, {SeatRow}, {SeatNumber}");
        
        
    }

    



}