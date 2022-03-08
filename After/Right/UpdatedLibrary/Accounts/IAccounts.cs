using UpdatedLibrary.Applicants;

namespace UpdatedLibrary.Accounts;

public interface IAccounts
{
    EmployeeModel Create(IApplicantModel personModel);
}