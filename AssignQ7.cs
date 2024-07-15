using System;

public class Date
{
    private int day, month, year;

    public Date()
    {
        day = 0;
        month = 0;
        year = 0;
    }

    public Date(int d, int m, int y)
    {
        day = d;
        month = m;
        year = y;
    }

    public static int CalculateAge(Date birthDate)
    {
        DateTime now = DateTime.Today;
        int age = now.Year - birthDate.year;

        if (now < birthDate.ToDateTime().AddYears(age))
            age--;

        return age;
    }

    public override string ToString()
    {
        return $"{day}/{month}/{year}";
    }

    public DateTime ToDateTime()
    {
        return new DateTime(year, month, day);
    }
}

public class Person
{
    private string name;
    private bool gender; 
    private Date birth;
    private string address;

    
    public Person()
    {
        name = "";
        gender = true;
        birth = new Date();
        address = "";
    }

    
    public Person(string n, bool g, Date b, string a)
    {
        name = n;
        gender = g;
        birth = b;
        address = a;
    }

   
    public string Name { get { return name; } }
    public bool Gender { get { return gender; } }
    public Date Birth { get { return birth; } }
    public string Address { get { return address; } }
    public int Age { get { return Date.CalculateAge(birth); } }

    
    public void Accept()
    {
        Console.Write("Enter name: ");
        name = Console.ReadLine();
        Console.Write("Enter gender (1 for male, 0 for female): ");
        gender = Convert.ToBoolean(Console.ReadLine());
        Console.Write("Enter birth date (day month year): ");
        string[] dateParts = Console.ReadLine().Split(' ');
        birth = new Date(Convert.ToInt32(dateParts[0]), Convert.ToInt32(dateParts[1]), Convert.ToInt32(dateParts[2]));
        Console.Write("Enter address: ");
        address = Console.ReadLine();
    }

    
    public void Print()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Gender: " + (gender ? "Male" : "Female"));
        Console.WriteLine("Birth Date: " + birth);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Age: " + Age);
    }

   
    public override string ToString()
    {
        return $"Name: {name}, Gender: {(gender ? "Male" : "Female")}, Birth Date: {birth}, Address: {address}, Age: {Age}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Accept();
        person.Print();
        Console.WriteLine("String representation: " + person.ToString());
    }
}

