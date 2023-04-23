namespace StudentAdminPortal.API.DataModels;

public class Student
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Email { get; set; }
    public long Mobile { get; set; }
    public string? ProfileImageUrl { get; set; }
    public Guid GenderId { get; set; }

    // foreign key
    public Gender Gender { get; set; } = new Gender();
    public Address Address { get; set; } = new Address();
}