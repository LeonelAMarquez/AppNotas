using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NoteNegocio
{
	class NoteNegocio
	{
		public List<Note> listar()
		{
			List<Note> lista = new List<Note>();
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;

			try
			{
				conexion.ConnectionString = "server=.\\SQLEXPRESS; database=NOTAS_APP; integrated security=true";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select Id, UsuarioId, TagId, Titulo, Contenido from Notas";
				comando.Connection = conexion;

				conexion.Open();
				lector = comando.ExecuteReader();
				while (lector.Read())
				{
					Note aux = new Note();
					aux.Id = lector.GetInt32(0);
					aux.UserId = lector.GetInt32(1);
                    aux.TagId = lector.GetInt32(2);
                    aux.Titulo = (string)lector["Titulo"];
					aux.Contenido = (string)lector["Contenido"];
					
					lista.Add(aux);
				}
				conexion.Close();
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
    }
}

//+54 9 3546 56 - 3701