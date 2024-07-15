using System;

struct Student
{
    private string name;
    private bool gender;
    private int age;
    private int std;
    private char div;
    private double marks;

    
   // public Student()
    //{
      //  name = "";
       // gender = true; //
       // age = 0;
       // std = 0;
       // div = 'A';
       // marks = 0.0;
   // }

    
    public Student(string name, bool gender, int age, int std, char div, double marks)
    {
        this.name = name;
        this.gender = gender;
        this.age = age;
        this.std = std;
        this.div = div;
        this.marks = marks;
    }

   
    public string GetName()
    {
        return name;
    }

    public bool GetGender()
    {
        return gender;
    }

    public int GetAge()
    {
        return age;
    }

    public int GetStd()
    {
        return std;
    }

    public char GetDiv()
    {
        return div;
    }

    public double GetMarks()
    {
        return marks;
    }

   
    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetGender(bool gender)
    {
        this.gender = gender;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public void SetStd(int std)
    {
        this.std = std;
    }

    public void SetDiv(char div)
    {
        this.div = div;
    }

    public void SetMarks(double marks)
    {
        this.marks = marks;
    }

    
    public void AcceptDetails()
    {
        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Gender (true for male, false for female): ");
        gender = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Standard: ");
        std = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Division: ");
        div = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter Marks: ");
        marks = Convert.ToDouble(Console.ReadLine());
    }

    // Method to print details to console
    public void PrintDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Gender: " + (gender ? "Male" : "Female"));
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Standard: " + std);
        Console.WriteLine("Division: " + div);
        Console.WriteLine("Marks: " + marks);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.AcceptDetails();
        Console.WriteLine("\nStudent Details:");
        student.PrintDetails();
    }
}

