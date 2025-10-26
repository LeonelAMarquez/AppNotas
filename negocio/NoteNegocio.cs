using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using conexionBD;

namespace negocio
{
	public class NoteNegocio
	{

		public List<Note> listarConSP() 
		{
            List<Note> lista = new List<Note>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT Id, UsuarioId, TagId, Titulo, Contenido FROM Notas";

                datos.setearConsulta(consulta);
				datos.ejecutarLectura();
				while (datos.Lector.Read())
                {
                    Note aux = new Note();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.UserId = (int)datos.Lector["UsuarioId"];
                    aux.TagId = (int)datos.Lector["TagId"];
                    aux.Titulo = datos.Lector["Titulo"] is DBNull ? "" : (string)datos.Lector["Titulo"];
                    aux.Contenido = (string)datos.Lector["Contenido"];

                    lista.Add(aux);
                }
                
                return lista;
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

        public void agregar(Note nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO Notas (UsuarioId, TagId, Titulo, Contenido) VALUES (@UsuarioId, @TagId, @Titulo, @Contenido)");
                datos.setearParametro("@UsuarioId", nueva.UserId.ToString());
                datos.setearParametro("@TagId", nueva.TagId.ToString());
                datos.setearParametro("@Titulo", nueva.Titulo);
                datos.setearParametro("@Contenido", nueva.Contenido);
                datos.ejecutarAccion();
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

