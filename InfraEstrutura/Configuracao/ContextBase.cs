using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidades.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InfraEstrutura.Configuracao
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<SistemaFinanceiro> SistemaFinanceiro {get; set;}
        public DbSet<UsuarioSistemaFinanceiro> UsuarioSistemaFinanceiro {get; set;}
        public DbSet<Categoria> Categoria {get; set;}
        public DbSet<Despesa> Despesa {get; set;}

        //verifica se a url do banco esta configurada 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ObterStringConexao());
                base.OnConfiguring(optionsBuilder);
            }

        }

        //Para conseguir mapear qual o id da taela AspNetUsers para a tabela ApplicationUser
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t=>t.Id);
            base.OnModelCreating(builder);
        }

        //colocou a string de conexão aqui como segurança
        public string ObterStringConexao()
        {
            return "Server=localhost;Database=ProjetoGabriel;User Id=rm;Password=rm;";
        }

    }
}