using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Factor
    {
        public Factor()
        {
            this.Proyecto = new HashSet<Proyecto>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ponderacion { get; set; }
        public bool Habilitado { get; set; }
    
        public virtual ICollection<Proyecto> Proyecto { get; set; }
    }
}

