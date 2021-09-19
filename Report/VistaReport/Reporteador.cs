using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.Odbc;
using System.IO;
//using ModeloReport;

namespace VistaReport
{
    public partial class Reporteador : Form
    {
        
        public Reporteador()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsConexion cn = new clsConexion();
            string Vis = "Visible";
            int estado;

            if(comboBoxEstado.Text == Vis)
            {
                estado = 1;
            }
            else
            {
                estado = 0;
            }

            /*UPDATE agenda
  SET telefono = '662142223', email = 'albesanch@mimail.com'
  WHERE nombre = 'Alberto Sanchez'*/

            //string cadena = "UPDATE reportes SET nombreReporte='" + textBoxNombre.Text + "', rutaReporte='" + textBoxRuta.Text + "', Departamento='" + textBoxDepartamento.Text + "', estado='" + est
            string cadena = "UPDATE reportes SET nombreReporte='" +textBoxNombre.Text+"', rutaReporte='" + textBoxRuta.Text + "', Departamento='" + textBoxDepartamento.Text + "', estado='"+ estado+ "' where idReporte='"+textBoxID.Text+"'";
                //@"VALUES ('"+ textBoxNombre+"' , '"+textBoxRuta+"','"+textBoxDepartamento+"','"+estado+"');";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
            MessageBox.Show("Guardado");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string rutaArchivo = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;
            }
            textBoxRuta.Text = rutaArchivo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*frmEliminar eli = new frmEliminar();
            eli.Show();*/

            string ruta = textBoxRuta.Text;
            try
            {
                bool result = File.Exists(ruta);
                if (result == true)
                {
                    MessageBox.Show("Archivo Encontrado");
                    File.Delete(ruta);
                    MessageBox.Show("Archivo Eliminado Exitosamente");
                }
                else
                {
                    MessageBox.Show("Archivo No Encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar archivo: {0}", ex.ToString());
            }
            Console.WriteLine("Presiona Enter para terminar.");
            var name = Console.ReadLine();
            textBoxRuta.Text = " ";

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxID.Enabled = true;
            textBoxNombre.Enabled = true;
            textBoxRuta.Enabled = true;
            textBoxDepartamento.Enabled = true;
            comboBoxEstado.Enabled = true;

        }
    }
}
