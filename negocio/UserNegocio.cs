using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
	public class UserNegocio
	{
        public User Login(string email, string password)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, Email, Contrasena FROM Usuarios WHERE Email = @Email AND Contrasena = @Contrasena");
                datos.setearParametro("@Email", email);
                datos.setearParametro("@Contrasena", password);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    User usuario = new User();
                    usuario.Id = (int)datos.Lector["Id"];
                    usuario.Email = (string)datos.Lector["Email"];
                    usuario.Contrasena = (string)datos.Lector["Contrasena"];
                    return usuario;
                }

                return null; // No encontró coincidencia
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
