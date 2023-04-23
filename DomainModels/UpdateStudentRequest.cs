namespace StudentAdminPortal.API.DomainModels;

public class UpdateStudentRequest
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string DateOfBirth { get; set; } = String.Empty;
    public string? Email { get; set; }
    public long Mobile { get; set; }
    public Guid GenderId { get; set; }
    public string? PhysicalAddress { get; set; }
    public string? PostalAddress { get; set; }
}