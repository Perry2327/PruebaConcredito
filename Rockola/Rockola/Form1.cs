using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rockola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cargardatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
             String nombrecancion =   this.Txtnombre.Text;
            Conexion con  = new Conexion();
            con.guardarcancion(nombrecancion);
            this.Txtnombre.Clear();
            MessageBox.Show("Se agrego con exito la cancion :" + nombrecancion);
            this.cargardatos();
            }
            catch (Exception error )
            {
               MessageBox.Show(error.Message) ;
            }

            
        }

        private void Txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void cargardatos()
        {
            Conexion con = new Conexion();
            DataSet ds = new DataSet();
            ds = con.metodocancion();
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void btnreproducir_Click(object sender, EventArgs e)
        {
            string nombrecancion = "";
            nombrecancion = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblreproduccion.Text = nombrecancion; 
        }

        private void btnaleatorio_Click(object sender, EventArgs e)
        {

            string nombrecancion = "";
            int idcancion = 0;

            Random random = new Random();
            idcancion = random.Next(0, dataGridView1.Rows.Count - 1);
            nombrecancion = dataGridView1.Rows[idcancion].Cells[1].Value.ToString();

            lblreproduccion.Text = nombrecancion; 

            //nombrecancion = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //lblreproduccion.Text = nombrecancion;
            
        }
    }
}
