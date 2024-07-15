using System;

//using System;

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

    public override string ToString()
    {
        return $"{day}/{month}/{year}";
    }
}

public class Person
{
    protected string name;
    protected bool gender; 
    protected Date birth;
    protected string address;

   
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

    
    public virtual void Accept()
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

    public virtual void Print()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Gender: " + (gender ? "Male" : "Female"));
        Console.WriteLine("Birth Date: " + birth);
        Console.WriteLine("Address: " + address);
    }


    public override string ToString()
    {
        return $"Name: {name}, Gender: {(gender ? "Male" : "Female")}, Birth Date: {birth}, Address: {address}";
    }
}

public enum DepartmentType
{
    None,
    IT,
    HR,
    Finance,
    Marketing
}

public class Employee : Person
{
    private static int idCounter = 1;

    private int id;
    private double salary;
    private string designation;
    private DepartmentType dept;

    public Employee() : base()
    {
        id = idCounter++;
        salary = 0.0; 
        designation = "";
        dept = DepartmentType.None;
    }

    public Employee(string n, bool g, Date b, string a, double sal, string desig, DepartmentType d)
        : base(n, g, b, a)
    {
        id = idCounter++;
        salary = sal;
        designation = desig;
        dept = d;
    }

    public int Id { get { return id; } }
    public double Salary { get { return salary; } set { salary = value; } }
    public string Designation { get { return designation; } set { designation = value; } }
    public DepartmentType Dept { get { return dept; } set { dept = value; } }


    public new void Accept()
    {
        base.Accept();
        Console.Write("Enter salary: ");
        salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter designation: ");
        designation = Console.ReadLine();
        Console.Write("Enter department (IT, HR, Finance, Marketing): ");
        string departmentStr = Console.ReadLine();
        if (!Enum.TryParse(departmentStr, out dept))
        {
            Console.WriteLine("Invalid department, setting department to None.");
            dept = DepartmentType.None;
        }
    }

    
    public new void Print()
    {
        base.Print(); 
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("Designation: " + designation);
        Console.WriteLine("Department: " + dept);
    }

    
    public override string ToString()
    {
        return base.ToString() + $", ID: {id}, Salary: {salary}, Designation: {designation}, Department: {dept}";
    }
}

