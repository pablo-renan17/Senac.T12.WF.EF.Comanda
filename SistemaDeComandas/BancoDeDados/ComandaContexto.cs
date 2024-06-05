

using Microsoft.EntityFrameworkCore;
using SistemaDeComandas.Modelos;

namespace SistemaDeComandas.BancoDeDados
{
    //essa classe representa nosso banco
     //DbContext foi feita pela microsoft
    public class ComandaContexto : DbContext
    {

        //criar as variaveis que representam as tabelas
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<CardapioItem> CardapioItems { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<ComandaItem> ComandaItems { get; set; }
        public DbSet<PedidoCozinha> PedidoCozinhas { get; set; }
        public DbSet<PedidoCozinhaItem> PedidoCozinhaItems { get; set; }

        //metodo para configurar banco(para abrir rapido e so escrever override onconfiure e depois enter)
        //serve para configurar a conexao do banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Datasource=comanda.db");
            base.OnConfiguring(optionsBuilder);
        }

        //serve para configurar os relacionamentos das tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //acesso a entidade CardapioItem para determinar a nomenclatura
            modelBuilder.Entity<CardapioItem>()
                .HasComment("Cadastro de items do cardapio");
                
            //Uma comanda possui muitos ComandasItems
            //E suas chave estraingeira é ComandaId
            modelBuilder.Entity<Comanda>()
                .HasMany<ComandaItem>()
                .WithOne(ci=> ci.Comanda)
                .HasForeignKey(f => f.ComandaId);

            //Pedido Cozinha com Pedido Cozinha item
            modelBuilder.Entity<PedidoCozinha>()
                .HasMany<PedidoCozinhaItem>()
                .WithOne(pci => pci.PedidoCozinha)
                .HasForeignKey(pci => pci.PedidoCozinhaId);

            //Pedido cozinha item possui um comanda item
            //E sua chave estrangeira é ComadaItemId
            modelBuilder.Entity<PedidoCozinhaItem>()
                .HasOne(pci => pci.ComandaItem)
                .WithMany()
                .HasForeignKey(pci => pci.ComandaItemId);

            modelBuilder.Entity<ComandaItem>()
                .HasOne(ci => ci.CardapioItem)
                .WithMany()
                .HasForeignKey(ci => ci.CardapioItemId);       

            base.OnModelCreating(modelBuilder);
        }
    }
}
