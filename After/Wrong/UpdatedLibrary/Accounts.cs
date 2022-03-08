namespace UpdatedLibrary;

public class Accounts
{
    public EmployeeModel Create(PersonModel personModel)
    {
        var output = new EmployeeModel
        {
            FirstName = personModel.FirstName,
            LastName = personModel.LastName,
            EmailAddress = $"{personModel.FirstName[..1]}{personModel.LastName}@rymanit.com"
        };

        // if (personModel.TypeOfEmployee==EmployeeType.Manager)
        // {
        //     output.IsManager = true;
        // }

        switch (personModel.TypeOfEmployee)
        {
            case EmployeeType.Staff :
                break;
            case EmployeeType.Manager:
                output.IsManager = true;
                break;
            case EmployeeType.Executive:
                output.IsManager = true;
                output.IsExecutive = true;
                break;
        }
        return output;
    }
}