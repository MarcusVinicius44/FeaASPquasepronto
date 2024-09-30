
using Microsoft.EntityFrameworkCore;

namespace FEAasp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<contato> contatos { get; set; }
        public DbSet<Parceiros> Parceiro { get; set; }

        internal bool TestConnection()
        {
            throw new NotImplementedException();
        }
    }
}
