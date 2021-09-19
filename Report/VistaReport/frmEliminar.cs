using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VistaReport
{
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ruta = textBoxCodigoElim.Text;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
