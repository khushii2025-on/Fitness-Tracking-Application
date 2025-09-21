using Fitness_Tracking_Application.Models;
using Fitness_Tracking_Application.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fitness_Tracking_Application.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Workout>()
                   .HasMany(w => w.Exercises)
                   .WithOne(e => e.Workout)
                   .HasForeignKey(e => e.WorkoutId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

