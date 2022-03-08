namespace UpdatedLibrary;

public class EmployeeModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }

    //new code
    public bool IsManager { get; set; } = false;
    public bool IsExecutive { get; set; } = false;
}