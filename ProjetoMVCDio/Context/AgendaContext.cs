using Microsoft.EntityFrameworkCore;
using ProjetoMVCDio.Models;

namespace ProjetoMVCDio.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        public DbSet<Contato> Contatos { get; set; }
    }
}
