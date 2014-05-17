using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Proyecto
    {
        public Proyecto()
        {
            this.Factor = new HashSet<Factor>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Gerente_Id { get; set; }
        public System.DateTime Fecha { get; set; }

        public virtual ICollection<Factor> Factor { get; set; }
        public virtual Gerente Gerente { get; set; }
    }
}
