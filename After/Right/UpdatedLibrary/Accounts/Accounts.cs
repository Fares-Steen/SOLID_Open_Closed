using UpdatedLibrary.Applicants;

namespace UpdatedLibrary.Accounts;

public class Accounts : IAccounts
{
    public EmployeeModel Create(IApplicantModel personModel)
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