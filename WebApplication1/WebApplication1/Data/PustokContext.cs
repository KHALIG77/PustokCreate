using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class PustokContext:DbContext
    {
        public PustokContext(DbContextOptions<PustokContext> options):base(options) {

        }

        public DbSet<BookImages> BookImages { get; set; }
        public DbSet<Books> Books { get; set; }
       

    }
}
