using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Website.Areas.Identity.Data;
using Website.Models;

namespace Website.Data;

public class WebsiteContext : IdentityDbContext<WebsiteUser>
{
    public WebsiteContext(DbContextOptions<WebsiteContext> options)
        : base(options)
    {

    }
    public DbSet<Candidate> candidates { get; set; }
    public DbSet<CandidateAnswer> CandidateAnswers { get; set; }
    public DbSet<Candidatetest> Candidatetests { get; set; }
    public DbSet<Option> Options { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<QuestionCategory> QuestionCategories { get; set; }
    public DbSet<Result> Result { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<CandidateAnswer>()
            .HasOne(ca => ca.Question)
            .WithMany()
            .HasForeignKey(ca => ca.QuestionId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<CandidateAnswer>()
            .HasOne(ca => ca.option)
            .WithMany()
            .HasForeignKey(ca => ca.OptionId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<CandidateAnswer>()
            .HasOne(ca => ca.candidatetest)
            .WithMany()
            .HasForeignKey(ca => ca.CandidateTestId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
