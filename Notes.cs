using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Notes
{
	public Notes()
	{
		public int Id {  get; set; }

		public int UserId { get; set; }

		public int TagId { get; set; }

		public string Titulo { get; set; }
	
		public string Contenido { get; set; }

		//public int Fecha { get; set; }
	}
}
