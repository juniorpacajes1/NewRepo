using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace RN
{
    public class RNBarrio:Contexto
    {
        dbDesarrolloSistemaISeptiembre2026Entities Esquema;
        public RNBarrio() {
            Esquema = this.TraerContexto();
        }

        public List<Barrio> TraerBarrio(Int64 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Barrio select e).ToList();
            }
            else
                return (from e in Esquema.Barrio where e.id.Equals(id) select e).ToList();
        }

        public object TraerBarriozona(long id)
        {
            var consulta = from b in Esquema.Barrio
                           join z in Esquema.Zona
                           on b.idZona equals z.id
                           where id == 0 || b.id == id
                           select new
                           {
                               id = b.id,
                               NombreBarrio = b.NombreBarrio,
                               NombreZona = z.NombreZona,
                               NombreZonaBarrio = z.NombreZona + " / " + b.NombreBarrio
                           };

            return consulta.ToList();
        }
    }
}
