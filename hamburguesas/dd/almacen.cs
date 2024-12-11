using dd.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dd
{
    public partial class almacen : Form
    {
        public almacen()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            producto producto = new producto();
            producto.nombre = txtnombre.Text;
            producto.cantidad = Convert.ToInt32(txtcant.Text);
            producto.precio = Convert.ToInt32(txtprec.Text);





            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            

                int result = ventaDAL.AgregarProducto(producto);


                if (result > 0)
                {
                    MessageBox.Show("Se guardo con exito");
                }
                else
                {
                    MessageBox.Show("No se guardo con exito");
                }
            
            refreshpantalla();

        }

        private void almacen_Load(object sender, EventArgs e)
        {
            refreshpantalla();
            txtid.Enabled = false;
        }

        public void refreshpantalla()
        {
            dataGridView1.DataSource = ventaDAL.presentarregistro();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_principal frm_Principal = new frm_principal();
            frm_Principal.Show();
            this.Hide();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtid.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["id"].Value);
            txtnombre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nombre"].Value);
            txtcant.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["cantidad"].Value);
            txtprec.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["precio"].Value);
        }

        private void btnmodi_Click(object sender, EventArgs e)
        {
            producto producto = new producto();
            producto.nombre = txtnombre.Text;
            producto.cantidad = Convert.ToInt32(txtcant.Text);
            producto.precio = Convert.ToInt32(txtprec.Text);





            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            if (id != null)
            {
                producto.id = id;
                int resultado = ventaDAL.Modificarventa(producto);


                if (resultado > 0)
                {
                    MessageBox.Show("Se modifico con exito");
                }
                else
                {
                    MessageBox.Show("No se guardo con exito");
                }
                refreshpantalla();
            }
        }
    }
}
