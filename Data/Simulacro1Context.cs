using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Simulacro1.Models;

namespace Simulacro1.Data
{
    public class Simulacro1Context : DbContext
    {
        public Simulacro1Context(DbContextOptions<Simulacro1Context> options) : base(options)
        {

        }

        //DBSET
        public DbSet<Author> Authors { get; set; }
        public DbSet<Editorial> Editorials { get; set; }
        public DbSet<Book> Books { get; set; }
    }

}
