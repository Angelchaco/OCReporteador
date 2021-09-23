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
using System.Data.SqlClient;
using MySqlConnector;
using ControladorReport;


namespace VistaReport
{
    public partial class Reporteador : Form
    {
        
        public Reporteador()
        {
            InitializeComponent();
            dataGrid();
        
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
            Botones bt = new Botones();
            
            string[] datos_guard = { textBoxNombre.Text,textBoxRuta.Text, textBoxDepartamento.Text, comboBoxEstado.Text, textBoxID.Text };


            
            for (int i=0; i<=4; i++) {
                bt.Guardar(datos_guard[i]);
            }
            
          
            

     

            //string cadena = "UPDATE reportes SET nombreReporte='" + textBoxNombre.Text + "', rutaReporte='" + textBoxRuta.Text + "', Departamento='" + textBoxDepartamento.Text + "', estado='" + est
           
                //@"VALUES ('"+ textBoxNombre+"' , '"+textBoxRuta+"','"+textBoxDepartamento+"','"+estado+"');";
          

            cleanTextBox();
            desactivarTextBox();
            dataGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string rutaArchivo = @" "; //string.Empty
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;
            }
            textBoxRuta.Text = rutaArchivo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEliminar eli = new frmEliminar();
            eli.Show();
            dataGrid();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            activarTextBox();
        }

        public void activarTextBox()
        {
            textBoxID.Enabled = true;
            textBoxNombre.Enabled = true;
            textBoxRuta.Enabled = true;
            textBoxDepartamento.Enabled = true;
            comboBoxEstado.Enabled = true;
        }

        public void desactivarTextBox()
        {
            textBoxID.Enabled = false;
            textBoxNombre.Enabled = false;
            textBoxRuta.Enabled = false;
            textBoxDepartamento.Enabled = false;
            comboBoxEstado.Enabled = false;
        }

        public void cleanTextBox()
        {
            textBoxID.Text = " ";
            textBoxNombre.Text = " ";
            textBoxRuta.Text = " ";
            textBoxDepartamento.Text = " ";
            comboBoxEstado.Text = " ";
        }

        public void dataGrid()
        {
            clsConexion cn = new clsConexion();
            string cadena = @"SELECT * FROM provisional.reportes;";
            OdbcDataAdapter consulta = new OdbcDataAdapter(cadena, cn.conexion());
            DataTable dt = new DataTable();
            consulta.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
