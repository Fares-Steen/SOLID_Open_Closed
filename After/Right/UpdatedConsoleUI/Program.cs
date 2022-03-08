
using UpdatedLibrary;
using UpdatedLibrary.Applicants;

namespace UpdatedConsoleUI;

internal static class Program
{
    private static void Main(string[] args)
    {
        var applicants = new List<IApplicantModel>
        {
            new PersonModel {FirstName = "Fares", LastName = "Steen"},
            new ManagerModel {FirstName = "Fadi", LastName = "Saibah"},
            new ExecutiveModel {FirstName = "Wassem", LastName = "Daher"}
        };

        var employees = new List<EmployeeModel>();
        

        foreach (var person in applicants)
        {
            employees.Add(person.AccountProcessor.Create(person));
        }

        foreach (var emp in employees)
        {
            Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
        }

        Console.ReadLine();
    }
}