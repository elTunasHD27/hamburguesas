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
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Deseas cerrar sesion del sistema",
                "Aviso del sistema",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();

               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            almacen almacen = new almacen();
            almacen.Show();
            this.Hide();
        }
    }
}
