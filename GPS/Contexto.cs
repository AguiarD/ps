using GPS.Models;
using Microsoft.EntityFrameworkCore;

namespace GPS
{
    public class Contexto : DbContext
    {
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Parametro> Parametros { get; set; }
        public DbSet<Conta> Contas { get; set; }
        //public DbSet<Scout> Scouts { get; set; }
        public DbSet<Lancamento> Financeiros { get; set; }

        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost\MSSQLSERVER01; initial Catalog=GPS; User ID=sa; password=1234")
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            optionsBuilder.UseLazyLoadingProxies();
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Scout>()
                .HasOne(s => s.fk_jogador)
                .WithMany(j => j.Scouts)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Scout>()
                .HasOne(s => s.fk_parametro)
                .WithMany(j => j.Scouts)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Financeiro>()
                .HasOne(s => s.fk_jogador)
                .WithMany(f => f.Financeiros)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Financeiro>()
                .HasOne(s => s.fk_conta)
                .WithMany(f => f.Financeiros)
                .OnDelete(DeleteBehavior.ClientCascade);
        }*/
    }
}
