
interface GovtRules
{
    double CalculateEmployeePF(double basicSalary);
    string GetLeaveDetails();
    double CalculateGratuity(float yearsOfService, double basicSalary);
}

class Employee
{
    public int EmpId { get; set; }
    public string Name { get; set; }
    public string Dept { get; set; }
    public string Designation { get; set; }
    public double BasicSalary { get; set; }

    public Employee(int empId, string name, string dept, string desg, double basicSalary)
    {
        EmpId = empId;
        Name = name;
        Dept = dept;
        Designation = desg;
        BasicSalary = basicSalary;
    }
}

class TCS : Employee, GovtRules
{
    public TCS(int empId, string name, string dept, string desg, double basicSalary)
        : base(empId, name, dept, desg, basicSalary) { }

    public double CalculateEmployeePF(double basicSalary)
    {
        if (basicSalary <= 0)
            throw new ArgumentException("Basic salary should be greater than zero.");

        return 0.12 * basicSalary;
    }

    public string GetLeaveDetails() => "Casual Leave: 1 day/month, Sick Leave: 12 days/year, Privilege Leave: 10 days/year";

    public double CalculateGratuity(float yearsOfService, double basicSalary)
    {
        if (yearsOfService < 0 || basicSalary <= 0)
            throw new ArgumentException("Invalid input for years of service or basic salary.");

        if (yearsOfService > 20) return 3 * basicSalary;
        else if (yearsOfService > 10) return 2 * basicSalary;
        else if (yearsOfService > 5) return basicSalary;
        else return 0;
    }
}

class Accenture : Employee, GovtRules
{
    public Accenture(int empId, string name, string dept, string desg, double basicSalary)
        : base(empId, name, dept, desg, basicSalary) { }

    public double CalculateEmployeePF(double basicSalary)
    {
        if (basicSalary <= 0)
            throw new ArgumentException("Basic salary should be greater than zero.");

        return 0.12 * basicSalary;
    }

    public string GetLeaveDetails() => "Casual Leave: 2 days/month, Sick Leave: 5 days/year, Privilege Leave: 5 days/year";

    public double CalculateGratuity(float yearsOfService, double basicSalary)
    {
        if (yearsOfService < 0 || basicSalary <= 0)
            throw new ArgumentException("Invalid input for years of service or basic salary.");

        return 0; // Gratuity not applicable
    }
}

class Program
{
    static void Main()
    {
        try
        {
            TCS john = new TCS(1, "John", "IT", "Software Engineer", 60000);
            Console.WriteLine($"TCS Employee PF: {john.CalculateEmployeePF(john.BasicSalary)}");
            Console.WriteLine($"TCS Leave Details: {john.GetLeaveDetails()}");
            Console.WriteLine($"TCS Gratuity Amount: {john.CalculateGratuity(8, john.BasicSalary)}");

            Console.WriteLine();

            Accenture alice = new Accenture(2, "Alice", "HR", "HR Specialist", 70000);
            Console.WriteLine($"Accenture Employee PF: {alice.CalculateEmployeePF(alice.BasicSalary)}");
            Console.WriteLine($"Accenture Leave Details: {alice.GetLeaveDetails()}");
            Console.WriteLine($"Accenture Gratuity Amount: {alice.CalculateGratuity(7, alice.BasicSalary)}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
