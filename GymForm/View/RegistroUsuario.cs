using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymForm
{
    public partial class RegistroUsuario : Form
    {
        private bool winCerrar;
        public bool WinCerrar { get => winCerrar; set => winCerrar = value; }
        public RegistroUsuario()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(FormClose); //Anexar un determinado bloque de codigo al evento FromClosin con el evento llamado 'FormClose'
        }
        private void FormClose(object sender, FormClosingEventArgs e)
        {
            WinCerrar = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!Validaciones())
            {
                MessageBox.Show("Registro completo");
                this.Close();
            }
            else
                MessageBox.Show("Papi rey, llene todos los campos pórfavor");
        }

        private bool Validaciones()
        {
            if (string.IsNullOrEmpty(txtNombre.Text)) return true;
            if (string.IsNullOrEmpty(txtApelido.Text)) return true;
            if (string.IsNullOrEmpty(txtUsuario.Text)) return true;
            if (string.IsNullOrEmpty(txtContra.Text)) return true;
            if (string.IsNullOrEmpty(txtTelefono.Text)) return true;
            if (string.IsNullOrEmpty(txtCorreo.Text)) return true;
            return false;
        }
    }
}
