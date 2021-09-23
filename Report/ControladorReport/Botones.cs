using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VistaReport;
using System.Data.Odbc;
using System.Windows.Forms;

namespace ControladorReport
{


   public class Botones
    {
        clsConexion cn = new clsConexion();

        
        


       public  void Guardar( string[]datos  )
        {
            int estado;
            string Vis = "Visible";
            if (datos[3] == Vis)
            {
                estado = 1;
            }
            else
            {
                estado = 0;
            }
            string cadena = @"UPDATE reportes SET nombreReporte='" + datos[0] + @"', rutaReporte='" + datos[1] + "', Departamento='" + datos[2] + "' estado='"+estado+"', where idReporte='" + datos[4] + "'";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
            MessageBox.Show("Guardado");
        }

    }
}

   

    
