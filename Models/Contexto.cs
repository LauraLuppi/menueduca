using Microsoft.EntityFrameworkCore;

namespace MenuEduca.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        //public DbSet<CadastroUsuario> CadastroUsuario { get; set; }
        //public DbSet<InsercaoMedica> InsercaoMedica { get; set; }
        //public DbSet<Cardapio> Cardapio { get; set; }
        //public DbSet<Avaliacao> Avaliacao { get; set; }

    }
}
