using System;

class Date
{
    private int day;
    private int month;
    private int year;

    // Default constructor
    public Date()
    {
        day = 1;
        month = 1;
        year = 2000;
    }

    // Parameterized constructor
    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    // Properties
    public int Day
    {
        get { return day; }
        set { day = value; }
    }

    public int Month
    {
        get { return month; }
        set { month = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    // Method to accept date from console
    public void AcceptDate()
    {
        Console.Write("Enter day: ");
        day = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter month: ");
        month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter year: ");
        year = Convert.ToInt32(Console.ReadLine());
    }

    // Method to print date to console
    public void PrintDate()
    {
        Console.WriteLine($"Date: {day}/{month}/{year}");
    }

    // Method to check validity of date
    public bool IsValid()
    {
        if (year < 1 || month < 1 || month > 12 || day < 1 || day > DateTime.DaysInMonth(year, month))
        {
            return false;
        }
        return true;
    }

    // ToString method
    public override string ToString()
    {
        return $"{day}/{month}/{year}";
    }

    // Static method to calculate difference in years between two dates
    public static int CalculateDifference(Date date1, Date date2)
    {
        int difference = Math.Abs(date1.year - date2.year);
        if (date1.month > date2.month || (date1.month == date2.month && date1.day > date2.day))
        {
            difference--;
        }
        return difference;
    }

    // Overloading "-" operator to calculate difference in years between two dates
    public static int operator -(Date date1, Date date2)
    {
        return CalculateDifference(date1, date2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Date date1 = new Date();
        Console.WriteLine("Enter first date:");
        date1.AcceptDate();

        Date date2 = new Date();
        Console.WriteLine("Enter second date:");
        date2.AcceptDate();

        Console.WriteLine("\nFirst Date:");
        date1.PrintDate();
        Console.WriteLine("Second Date:");
        date2.PrintDate();

        if (date1.IsValid() && date2.IsValid())
        {
            Console.WriteLine($"\nDifference between dates (in years): {Date.CalculateDifference(date1, date2)}");
            Console.WriteLine($"Difference between dates (overloaded operator): {date1 - date2}");
        }
        else
        {
            Console.WriteLine("Invalid date input!");
        }
    }
}

