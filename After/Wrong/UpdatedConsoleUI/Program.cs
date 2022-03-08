using UpdatedLibrary;

namespace UpdatedConsoleUI;

internal static class Program
{
    private static void Main(string[] args)
    {
        var applicants = new List<PersonModel>
        {
            new PersonModel {FirstName = "Fares", LastName = "Steen"},
            new PersonModel {FirstName = "Fadi", LastName = "Saibah", TypeOfEmployee = EmployeeType.Manager},
            new PersonModel {FirstName = "Wassem", LastName = "Daher",TypeOfEmployee = EmployeeType.Executive}
        };

        var employees = new List<EmployeeModel>();

        var accountsProcessor = new Accounts();

        foreach (var person in applicants)
        {
            employees.Add(accountsProcessor.Create(person));
            
        }

        foreach (var emp in employees)
        {
            Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
        }

        Console.ReadLine();
    }
}