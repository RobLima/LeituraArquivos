using System;
using System.Data.Entity;
using BLLDomain.Entities;
using Infrastructure.EntityConfig;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Infrastructure
{
    public class Contexto : DbContext
    {
        public Contexto() : base("stringConexao")
        {
        }


        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                 .Where(p => p.Name == p.ReflectedType.Name + "Id")
                 .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());

            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

        }
    }
}
