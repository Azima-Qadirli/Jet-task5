//1)Task Description; Create an abstract class called Employee with the following specifications:
//Properties:
//Name
//EmployeeId

//Methods:
//abstract double CalculateMonthlySalary();
//abstract void DisplayEmployeeDetails();
//Create two derived classes, FullTimeEmployee and ContractEmployee, that inherit from Employee and implement the abstract methods.

//Implementation Details:
//Derived Class: FullTimeEmployee
//Inherits from Employee.
//Adds a new property AnnualSalary.
//Implements the CalculateMonthlySalary() method by dividing the AnnualSalary by 12.
//Implements the DisplayEmployeeDetails() method to print employee details and monthly salary.

//Derived Class: ContractEmployee
//Inherits from Employee.
//Adds new properties HourlyRate and HoursWorked.
//Implements the CalculateMonthlySalary() method by multiplying HourlyRate by HoursWorked.
//Implements the DisplayEmployeeDetails() method to print employee details and monthly salary.
//using System.Runtime.CompilerServices;
//using System.Xml.Linq;
//using static FullTimeEmployee;

//public abstract class Employee
//{
//    public string Name { get; set; }
//    public int EmployeeId { get; set; }

//    public   Employee(string name, int employeeId)
//    {
//        Name = name;
//        EmployeeId = employeeId;
//    }

//    public abstract double CalculateMonthlySalary();
//    public abstract void DisplayEmployeeDetails();
//}
//public class FullTimeEmployee : Employee
//{
//    public double AnnualSalary { get; set; }

//    public FullTimeEmployee(string name, int employeeId, double annualSalary)
//        : base(name, employeeId)
//    {
//        AnnualSalary = annualSalary;
//    }

//    public override double CalculateMonthlySalary()
//    {
//        return AnnualSalary / 12;
//    }

//    public override void DisplayEmployeeDetails()
//    {
//        Console.WriteLine($"Name: {Name}, Employee ID: {EmployeeId}, Monthly Salary: {CalculateMonthlySalary()}");
//    }
//}
//public class ContractEmployee : Employee
//{
//    public double HourlyRate { get; set; }
//    public double HoursWorked { get; set; }


//    public ContractEmployee(string name, int employeeId, double hourlyRate, double hoursWorked) : base(name, employeeId)
//    {
//        HourlyRate = hourlyRate;
//        HoursWorked = hoursWorked;

//    }
//    public override double CalculateMonthlySalary()
//    {
//        return HourlyRate * HoursWorked;
//    }
//    public override void DisplayEmployeeDetails()
//    {
//        Console.WriteLine($"Name: {Name}, Employee ID: {EmployeeId}, Monthly Salary: {CalculateMonthlySalary()}");
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        FullTimeEmployee employee = new FullTimeEmployee("Azima", 124, 30000);
//        ContractEmployee contractEmployee = new ContractEmployee("Akif", 1256, 50, 150);

//        employee.DisplayEmployeeDetails();
//        contractEmployee.DisplayEmployeeDetails();
//    }
//}

