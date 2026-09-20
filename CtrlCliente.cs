using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.Entity;



namespace RN
{
    public class CtrlCliente:Contexto
    {

        dbDesarrolloSistemaISeptiembre2026Entities Esquema;
        public CtrlCliente() {
            Esquema = this.TraerContexto();
        }
        public Int64 GenerarId()
        {
            try
            {
                return (from e in Esquema.Cliente select e.id).Max() + 1;
            }
            catch { return 1; }
        }
        public bool InsertarClienteNatural(Cliente objCliente, Natural objNatural)
        { 
               try { 
                    // Insertar Cliente
                    Esquema.Cliente.Add(objCliente);
                    // Insertar Natural
                    Esquema.Natural.Add(objNatural);
                    // Guardar cambios
                    Esquema.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    // Al no ejecutar Complete(), se realiza Rollback
                    return false;
                }
            }
        }
    }
    

