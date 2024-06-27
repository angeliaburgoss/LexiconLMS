
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LexiconLMS.Models;

namespace LexiconLMS.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    CourseId = 1,
                    CourseName = " Programming",
                    CourseDescription = "Learn  C#.",
                    StartDate = DateTime.Now
                },
                new Course
                {
                    CourseId = 2,
                    CourseName = "Databases",
                    CourseDescription = " database design .",
                    StartDate = DateTime.Now
                }
            );
        }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
