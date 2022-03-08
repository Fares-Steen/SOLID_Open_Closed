namespace Library;

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
        return output;
    }
}