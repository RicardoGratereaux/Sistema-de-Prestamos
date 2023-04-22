using Microsoft.EntityFrameworkCore;
using PROG_FINAL_prueba_3.Models;
using PROG_FINAL_prueba_3.Servicios.Contratos;

namespace PROG_FINAL_prueba_3.Servicios.Implementacion
{
    public class UsuarioService : IUsuarioService
    {
        private readonly LoginPrestamosContext _dbcontext;
        public UsuarioService(LoginPrestamosContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Usuario> GetUsuario(string correo, string clave)
        {
            Usuario usuario_encontrado = await _dbcontext.Usuarios.Where(u => u.Correo == correo && u.Clave ==clave).FirstOrDefaultAsync();
            return usuario_encontrado;
        }

        public async Task<Usuario> SaveUsuario(Usuario modelo)
        {
            _dbcontext.Usuarios.Add(modelo);
            await _dbcontext.SaveChangesAsync();
            return modelo;
        }
    }
}
