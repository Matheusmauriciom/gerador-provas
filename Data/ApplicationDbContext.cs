using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Concurso.Models;

namespace Concurso.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Questao> Questoes { get; set; }
     public DbSet<Alternativa> Alternativas { get; set; }
     public DbSet<ImagemQuestao> ImagensQuestoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar o relacionamento entre Questao e ImagemQuestao
            modelBuilder.Entity<ImagemQuestao>()
                .HasOne(iq => iq.Questao)
                .WithMany(q => q.Imagens)
                .HasForeignKey(iq => iq.QuestaoId)
                .OnDelete(DeleteBehavior.Cascade); // Isso é opcional e define o comportamento de exclusão
        }
}
