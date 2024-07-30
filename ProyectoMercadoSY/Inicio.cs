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


namespace ProyectoMercadoSY
{
    public partial class Inicio : Form
    {

     
        public Inicio()
        {

            InitializeComponent();
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {

            this.Show();
        }
        private void butuser_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new frmUsuario());
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
          
        }

        private void Abrirformhijo(object formhija)
        {
            if (this.panelpantalla.Controls.Count > 0)
                this.panelpantalla.Controls.RemoveAt(0);
            Form ft = formhija as Form;
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            this.panelpantalla.Controls.Add(ft);
            this.panelpantalla.Tag = ft;
            ft.Show();
        }

        private void butask_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new FrmAcercade());
        }

        private void butproduct_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new FrmProducto());
        }

        private void butclient_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new FrmClientes());
        }

        private void butprove_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new FrmProveedor());
        }

        private void butreport_Click(object sender, EventArgs e)
        {
            Abrirformhijo (new FrmReportes());
        }
    }
}
