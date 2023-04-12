using Sistema_de_Prestamos.Models;
using System.Data.Entity;

namespace Sistema_de_Prestamos.DAL
{
    public class GeneralContext : DbContext
    {
        public GeneralContext() : base("Conexion") { }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }
    }
}
