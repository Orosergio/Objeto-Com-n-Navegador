using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        public int codigoMax(string tabla, string campo)
        {
            int codigo = sn.procInsertar(tabla, campo);

            return codigo;
        }

        public void Datos(string tabla, List<string> lista)
        {
            sn.Insertar(tabla, lista);
        }
        public void Datos2(string tabla, List<string> campos, List<string> datos)
        {
            sn.Modificar(tabla, campos, datos);
        }

        public DataTable enviar(string tabla)
        {
            try
            {
                OdbcDataAdapter dt = sn.obtener(tabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Puede que los parametros seas erroneos, verifique los parametro enviados" + ex);
                return null;
            }

        }

       // --------------------------------------------------------------------------
        public bool Eliminar(string tabla, string campo, string idTabla, string id)
        {
            if (sn.procEliminar(tabla, campo, idTabla, id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
