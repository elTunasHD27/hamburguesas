using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;


namespace dd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }
        
        

        private void button1_Click(object sender, EventArgs e) 
        {

            frm_principal frm_Principal = new frm_principal();
            frm_Principal.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
