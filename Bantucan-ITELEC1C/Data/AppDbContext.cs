using Bantucan_ITELEC1C.Models;
using Microsoft.EntityFrameworkCore;

namespace Bantucan_ITELEC1C.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    FirstName = "Toge",
                    LastName = "Inumaki",
                    Course = Course.BSIT,
                    AdmissionDate = DateTime.Parse("2022-08-26"),
                    GPA = 1.5,
                    Email = "togeinumaki69@gmail.com"
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Gon",
                    LastName = "Freecss",
                    Course = Course.BSIS,
                    AdmissionDate = DateTime.Parse("2022-08-07"),
                    GPA = 1,
                    Email = "gonfreecss@gmail.com"
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Nagi",
                    LastName = "Seishiro",
                    Course = Course.BSCS,
                    AdmissionDate = DateTime.Parse("2020-01-25"),
                    GPA = 1.5,
                    Email = "nagishhro@gmail.com"
                });

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor()
                {
                    Id = 1,
                    FirstName = "Light",
                    LastName = "Yagami",
                    HiringDate = new DateTime(2022, 08, 26),
                    IsTenured = true,
                    Rank = Rank.Instructor

                },
                new Instructor()
                {
                    Id = 2,
                    FirstName = "Lelouch",
                    LastName = "Lamperouge",
                    HiringDate = new DateTime(2022, 08, 07),
                    IsTenured = true,
                    Rank = Rank.AssistantProfessor

                },
                new Instructor()
                {
                    Id = 3,
                    FirstName = "Levi",
                    LastName = "Ackerman",
                    HiringDate = new DateTime(2022, 01, 25),
                    IsTenured = false,
                    Rank = Rank.AssociateProfessor

                });
        }

    }
}
