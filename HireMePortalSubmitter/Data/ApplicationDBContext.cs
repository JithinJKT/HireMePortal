using HireMePortalSubmitter.Models;
using Microsoft.EntityFrameworkCore;

namespace HireMePortalSubmitter.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { 

        }

        public DbSet<Career> Careers { get; set; }
        public DbSet<CareerApply> CareerApply { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Career>().HasData(
                new Career
                {
                    Id = 1,
                    Name = "Developer",
                    JobCode = "DEV001",
                    Location = "New York",
                    JobDetails = "Develop and maintain web applications.",
                    ExperienceRange = "2-4 years"
                },
                new Career
                {
                    Id = 2,
                    Name = "Designer",
                    JobCode = "DES001",
                    Location = "Los Angeles",
                    JobDetails = "Design user interfaces and graphics.",
                    ExperienceRange = "3-5 years"
                },
                new Career
                {
                    Id = 3,
                    Name = "Tester",
                    JobCode = "TES001",
                    Location = "Chicago",
                    JobDetails = "Test software applications for bugs.",
                    ExperienceRange = "1-3 years"
                },
                new Career
                {
                    Id = 4,
                    Name = "Manager",
                    JobCode = "MAN001",
                    Location = "San Francisco",
                    JobDetails = "Manage project teams and deliverables.",
                    ExperienceRange = "5-7 years"
                },
                new Career
                {
                    Id = 5,
                    Name = "Support",
                    JobCode = "SUP001",
                    Location = "Miami",
                    JobDetails = "Provide technical support to clients.",
                    ExperienceRange = "2-4 years"
                }
            );
        }
    }
}

