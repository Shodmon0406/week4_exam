using Task1.Classes;

var employee = new Employee(1, "y", "k", 100);
Console.WriteLine(employee.RaiseSalary(1));
Console.WriteLine(employee.GetAnnualSalary());
Console.WriteLine(employee.GetSalary());
Console.WriteLine(employee.ToString());