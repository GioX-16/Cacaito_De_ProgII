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
    public partial class ClientesForm : Form
    {
        private bool winCerrar;
        public bool WinCerrar { get => winCerrar; set => winCerrar = value; }

        public ClientesForm()
        {
            InitializeComponent();
            this.FormClosing +=  new FormClosingEventHandler(FormClose); //Anexar un determinado bloque de codigo al evento FromClosin con el evento llamado 'FormClose'
        }

        private void FormClose(object sender, FormClosingEventArgs e)
        {
            WinCerrar = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
