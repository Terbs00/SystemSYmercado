using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMercadoSY
{
    public partial class login : Form
    {
        Conexion conexionbd = new Conexion();
        public login()
        {
            InitializeComponent();
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            textUser.Text = "";
            textpass.Text = "";
            this.Show();
        }

        private void Ingresarbt_Click(object sender, EventArgs e)
        {
            string usuario = textUser.Text;
            string contraseña = textpass.Text;


            DataTable result = conexionbd.Logear(usuario, contraseña);

            if (result.Rows.Count > 0)
            {

                MessageBox.Show("Login exitoso");
                Inicio form = new Inicio();

                form.Show();

                this.Hide();

                form.FormClosing += frm_closing;


            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }


        }

        private void Saliebt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
