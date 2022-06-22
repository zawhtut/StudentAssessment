using Microsoft.EntityFrameworkCore;

namespace StudentAssessment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student>? Students { get; set; }

        public DbSet<Attendance>? Attendances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>();

            modelBuilder.Entity<Attendance>();

            modelBuilder.Entity<LessonsLearned>();

            modelBuilder.Entity<WorkHabit>();

            modelBuilder.Entity<SocialEmotionDev>();

            modelBuilder.Entity<PhysicalDev>();

        }


    }
}
