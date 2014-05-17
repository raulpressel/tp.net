using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    using System;
    using System.Collections.Generic;

    public partial class Gerente
    {


        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string DNI { get; set; }

        public virtual ICollection<Proyecto> Proyecto { get; set; }
    }
}

