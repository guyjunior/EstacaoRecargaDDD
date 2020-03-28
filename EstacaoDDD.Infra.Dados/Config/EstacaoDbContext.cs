using EstacaoDDD.Domain.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstacaoDDD.Infra.Dados.Config
{
    public class EstacaoDbContext : DbContext
    {
        public DbSet<Estacao> EstacaoRecarga { get; set; }


        public EstacaoDbContext()
        {

        }

        public EstacaoDbContext(DbContextOptions<EstacaoDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetConnectionString());

            base.OnConfiguring(optionsBuilder);
        }

        private string GetConnectionString()
        {
            //Alterar para configurações desejadas:
            return "Server=(localdb)\\MSSQLLocalDB;" +
                "Database=EstacaoDDD;" +
                "Trusted_Connection=True;" +
                "MultipleActiveResultSets=True;";
        }
    }
}
