using UpdatedLibrary.Accounts;

namespace UpdatedLibrary.Applicants;

public class PersonModel : IApplicantModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public IAccounts AccountProcessor { get; set; } = new Accounts.Accounts();
}