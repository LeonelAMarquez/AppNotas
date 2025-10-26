using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Note
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int TagId { get; set; }

        public string Titulo { get; set; }

        public string Contenido { get; set; }

        public string TagNombre
        {
            get
            {
                switch (TagId)
                {
                    case 1:
                        return "Football";
                    case 2:
                        return "University";
                    case 3:
                        return "Family";
                    default:
                        return "Sin categoría";
                }
            }
        }

    }

}
