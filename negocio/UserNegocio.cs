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
		public List<User> listar() 
		{ 
			List<User> list = new List<User>();
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setearConsulta("Select Id, Email, Contrasena From Usuarios");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					User aux = new User();
					aux.Id = (int)datos.Lector["Id"];
					//aux.Email = (string)datos.Lector["Email"];
					//aux.Contrasena = (string)datos.Lector["Contrasena"];

					list.Add(aux);
				}

				return list;
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
