namespace QuizApp.Server.Data
{
    using Microsoft.EntityFrameworkCore;
    using QuizApp.Server.Models;

    public class QuizDbContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }

        public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Question>().HasKey(q => q.Id); 
        }
    }
}
