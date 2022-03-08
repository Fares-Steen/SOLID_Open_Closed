using UpdatedLibrary.Applicants;

namespace UpdatedLibrary.Accounts;

public class ManagerAccounts:IAccounts
{
    public EmployeeModel Create(IApplicantModel personModel)
    {
        var output = new EmployeeModel
        {
            FirstName = personModel.FirstName,
            LastName = personModel.LastName,
            EmailAddress = $"{personModel.FirstName[..1]}{personModel.LastName}@rymanitCorp.com",
            IsManager = true,
        };
        
        return output;
    }
}