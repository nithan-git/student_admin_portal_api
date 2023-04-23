using Microsoft.EntityFrameworkCore;

namespace StudentAdminPortal.API.DataModels;
public class StudentAdminContext : DbContext
{
    public StudentAdminContext(DbContextOptions<StudentAdminContext> options) : base(options)
    {
    }

    public DbSet<Student> Student { get; set; } = null!;
    public DbSet<Gender> Gender { get; set; } = null!;
    public DbSet<Address> Address { get; set; } = null!;
}
