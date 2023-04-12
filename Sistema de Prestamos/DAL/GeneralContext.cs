using System.Data.Entity;

namespace Sistema_de_Prestamos.DAL
{
    public class GeneralContext : DbContext
    {
        public GeneralContext() : base("") { }
    }
}
