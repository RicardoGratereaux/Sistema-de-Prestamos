namespace PROG_FINAL_prueba_3.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Monto { get; set; } 
        public int Plazo { get; set; }
        public decimal TasaInteres { get; set; }
        public int cuotaspendientes { get; set; }
        public int pagocuota { get; set; }
    }

}
