using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryRintischSPUno
{
    public partial class frmDos : Form
    {
        public frmDos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmDos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir?", "Sintepart SRL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                this.Hide();
                frmUno frmUno = new frmUno();
                frmUno.Show();
               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;
                                
            if (Usuario == "")
            {
                MessageBox.Show("Ingrese un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
            }
            else if (Contraseña == "")
            {
                MessageBox.Show("Ingrese una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
            }
            else if (cmbModulo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbModulo.Focus();
            }
            else if (Usuario == "Adm" || Usuario == "Administrador" || Contraseña == "@1a" || cmbModulo.SelectedIndex == (0))
            {
               
                DialogResult result = MessageBox.Show("Bienvenido sr/sra administrador/a", "Sintepart SRL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmADM frmADM = new frmADM();
                frmADM.Show();

            }
            else if (Usuario == "Adm" || Usuario == "Administrador" || Contraseña == "@1a" || cmbModulo.SelectedIndex == (2))
            {

                DialogResult result = MessageBox.Show("Bienvenido sr/sra administrador/a", "Sintepart SRL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmCOM frmCOM = new frmCOM();
                frmCOM.Show();

            }
            else if (Usuario == "Adm" || Usuario == "Administrador" || Contraseña == "@1a" || cmbModulo.SelectedIndex == (3))
            {

                DialogResult result = MessageBox.Show("Bienvenido sr/sra administrador/a", "Sintepart SRL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmVTA frmVTA = new frmVTA();
                frmVTA.Show();

            }
        }
    }
}
