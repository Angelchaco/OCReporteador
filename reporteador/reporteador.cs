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

namespace reporteador
{
    public partial class reporteador : Form
    {
        public reporteador()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpeg");
            this.BackgroundImage = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarRuta();
            txtapellidos.Text = "";
        }

        void GuardarRuta()
        {
            string cadena = "INSERT INTO ruta (id, ruta, estado) " +
            "VALUES (0, '" + txtapellidos.Text + "', '1');";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
            MessageBox.Show("Reporte Guardado");
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            string rutaArchivo = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;
            }
            txtapellidos.Text = rutaArchivo;
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {

        }

        private void txtapellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ruta = @"D:\Users\Emanuel\Documents\Prueba.txt";
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

        }

        private void reporteador_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
