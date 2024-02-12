using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Práctica
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
            //
            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
            //
            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;
            else
                txtEdad.BackColor = System.Drawing.SystemColors.Control;
            //
            if (txtDirección.Text == "")
                txtDirección.BackColor = Color.Red;
            else
                txtDirección.BackColor = System.Drawing.SystemColors.Control;

            string apellidoYnombre = "Apellido y Nombre: " + txtApellido.Text + " " + txtNombre.Text;

            string edad = "Edad: " + txtEdad.Text;

            string direccion = "Dirección: " + txtDirección.Text;



            lvResultado.Items.Add(apellidoYnombre);
            lvResultado.Items.Add(edad);
            lvResultado.Items.Add(direccion);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //txtApellido.Clear();
            //txtNombre.Clear();
            //txtEdad.Clear();
            //txtDirección.Clear();
            //lvResultado.Clear();
            this.Close();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
