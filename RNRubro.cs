using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace RN
{
    public class RNRubro:Contexto  {
        dbDesarrolloSistemaISeptiembre2026Entities Esquema;
        public RNRubro()  {
            Esquema = this.TraerContexto();
        }
        public Int64 GenerarId() {
            try {
                return (from e in Esquema.Rubro select e.id).Max() + 1;
            }
            catch { return 1; }
        }
        public Boolean Insertar(Rubro ObjRubro) {
            Esquema.Rubro.Add (ObjRubro);
            return Esquema.SaveChanges ()==1;
        }
        public List<Rubro> TraerRubro(Int64 id) {
            if (id == 0) {
                return (from e in Esquema.Rubro select e).ToList();
            }
            else
                return (from e in Esquema.Rubro where e.id.Equals(id) select e).ToList();
        }
        public List<Rubro> TraerRubroPorNombre(string  NombreRubro) {
            return (from e in Esquema.Rubro where e.NombreRubro.ToUpper().StartsWith(NombreRubro.ToUpper()) select e).ToList();
        }
    }
}
