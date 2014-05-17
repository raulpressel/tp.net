using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Modelo
{
    using System;
    using System.Collections.Generic;

    public class Factor
    {


        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ponderacion { get; set; }
        public bool Habilitado { get; set; }

        public virtual ICollection<Proyecto> Proyecto { get; set; }
    }
}
