
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
                    CourseDescription = "Learn  C#",
                    StartDate = DateTime.Now
                },
                new Course
                {
                    CourseId = 2,
                    CourseName = "Databases",
                    CourseDescription = "Database Design",
                    StartDate = DateTime.Now
                }
            );

            DateTime startDate = DateTime.Now;
            DateTime endDate = startDate.AddDays( 30);

            modelBuilder.Entity<Module>().HasData(
                new Module
                {
                    ModuleId = 1,
                    ModuleName = ".NET",
                    ModuleDescription = "Fullstack developer",
                    StartDate = startDate,
                    EndDate = endDate
                }
                ); 

            DateTime start = DateTime.Now;
            DateTime end = start.AddDays( 7 );
            modelBuilder.Entity<Activity>().HasData(
                new Activity
                {
                    ActivityId = 1,
                    ActivityName = "LexiconLMS",
                    ActivityDescription = "Blazor + API",
                    StartDate = start,
                    EndDate = end

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
