using UpdatedLibrary.Accounts;

namespace UpdatedLibrary.Applicants;

public class ExecutiveModel:IApplicantModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IAccounts AccountProcessor { get; set; } = new ExecutiveAccounts();
}