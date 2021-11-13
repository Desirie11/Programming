using System;
namespace Timekeeping
{

    public class Program 
    {
        public static void Main()
        {
    Console.WriteLine("Employee's Daily Time Record");            


        Console.WriteLine($"Today's Date:  {DateTime.Today.ToShortDateString()}");            

        Console.Write("Please Enter your Employee ID:");            
        string employeeId = Console.ReadLine();            
    

         TimeSpan timeIn = new TimeSpan(8,45,0);            
         Console.WriteLine($"Login time has been recorded!: {timeIn}");            
 
 
         Console.WriteLine("*******************************");            
         Console.Write("Please Enter your Employee ID:");            
         employeeId = Console.ReadLine();            
 
        TimeSpan timeOut = new TimeSpan(17, 0, 0);            
        Console.WriteLine($"Logout time has been recorded!: {timeOut}");            
 
 TimeSpan lunchBreakDuration = new TimeSpan(1, 0, 0);            
 TimeSpan totalHours = (timeOut - timeIn) - lunchBreakDuration;            
 Console.WriteLine($"Yout total hours worked is: {totalHours}");            
 
 TimeSpan regularHoursStart = new TimeSpan(8, 00, 0);            
 TimeSpan regularHoursEnd = new TimeSpan(17, 0, 0);            
 TimeSpan lateIn = new TimeSpan(0,0,0);            
         
 
    if (timeIn > regularHoursStart)        
        {
      lateIn = timeIn - regularHoursStart;         
       }
     TimeSpan totalAmountLate = timeIn - regularHoursStart;            
    
    Console.WriteLine($"Your total late for today is: {totalAmountLate}");
}
  }
}
  
