namespace Sistema_de_Prestamos.Models
{
    public class Prestamos
    {
        public int Id { get; set; }

         public long Monto { get; set;}

        public decimal FechaComienzo { get; set;}

        public decimal FechaFinal { get; set;}
        public decimal Interes { get; set; }

        public int ClientesId { get; set; }
        public virtual Clientes Clientes { get; set; }
    }
}
