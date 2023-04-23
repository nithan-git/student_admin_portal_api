namespace StudentAdminPortal.API.DataModels;

public class Address
{
    public Guid Id { get; set; }
    public string? PhysicalAddress { get; set; }
    public string? PostalAddress { get; set; }

    // foreign key
    public Guid StudentId { get; set; }
}