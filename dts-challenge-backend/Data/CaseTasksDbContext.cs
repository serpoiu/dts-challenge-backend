using Microsoft.EntityFrameworkCore;

namespace dts_challenge_backend.Data
{
    public class CaseTasksDbContext : DbContext
    {
        public CaseTasksDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=localhost;Database=CaseTasksDb;Trusted_Connection=True;MultipleActiveResultSets=True";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        DbSet<CaseTask> CaseTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CaseTask>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<CaseTask>().HasData(
                new CaseTask(1, "Update Hearing Schedule", "Update the court hearing schedule", TaskStatus.Open, new DateOnly(2026,06,10)),
                new CaseTask(2, "Sorting Evidence", "", TaskStatus.InProgress, new DateOnly(2026,05,25)),
                new CaseTask(3, "Review Evidence", "Review evidence in cae 00010", TaskStatus.Completed, new DateOnly(2026,05,15)));
        }
    }
}
