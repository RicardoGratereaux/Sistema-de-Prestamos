using Microsoft.EntityFrameworkCore;
using PROG_FINAL_prueba_3.Models;

namespace PROG_FINAL_prueba_3.Servicios.Contratos
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuario(string correo, string clave);
        Task<Usuario> SaveUsuario(Usuario modelo);
    }
}
