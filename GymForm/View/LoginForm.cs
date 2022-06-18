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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbxAdmCli.SelectedItem == "Cliente")
            {
                if (!string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtPassword.Text)) //Solo va a entrar al if si las dos condiciones retornan distinto de true
                {
                    var Rutina_Form = new RutinaClienteForm();
                    this.Visible = false;
                    Rutina_Form.ShowDialog();
                    if (Rutina_Form.WinCerrar == true)
                        this.Visible = true;
                }
                else
                    MessageBox.Show("No se puede encontrar el usuario, tiene que registrarse primero."); 
            }
            else
            {
                if (!string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtPassword.Text)) //Solo va a entrar al if si las dos condiciones retornan distinto de true
                {
                    var Rutina_Form = new ClientesForm();
                    this.Visible = false;
                    Rutina_Form.ShowDialog();
                    if (Rutina_Form.WinCerrar == true)
                        this.Visible = true;
                }
                else
                    MessageBox.Show("No se puede encontrar el usuario, tiene que registrarse primero.");
            }
        }

        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistroUsuario Registro_Usuario_Form = new RegistroUsuario();
            this.Visible = false;
            Registro_Usuario_Form.ShowDialog();
            if (Registro_Usuario_Form.WinCerrar == true)
                this.Visible = true;
        }
    }
}
