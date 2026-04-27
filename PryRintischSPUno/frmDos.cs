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
             
            if (txtUsuario.Text == "")
            {
                
                MessageBox.Show("Ingrese un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();

            }
            else if (txtContraseña.Text == "")
            {
                
                MessageBox.Show("Ingrese una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();

            }
            else if (cmbModulo.SelectedIndex == -1)
            {
                
                MessageBox.Show("Seleccione un módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbModulo.Focus();

            }

            
            if (txtUsuario.Text == "Adm" && txtContraseña.Text == "@1a" && cmbModulo.SelectedIndex == 0)
            {
               
                DialogResult result = MessageBox.Show("Bienvenido/a sr/sra administrador/a", "Sintepart SRL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmADM frmADM = new frmADM();
                frmADM.Show();
                txtUsuario.Text = ""; 
                txtContraseña.Text = "";

            }
            else if (txtUsuario.Text == "Adm" && txtContraseña.Text == "@1a" && cmbModulo.SelectedIndex == 2)
            {

                DialogResult result = MessageBox.Show("Bienvenido/a sr/sra administrador/a", "Sintepart SRL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmCOM frmCOM = new frmCOM();
                frmCOM.Show();
                txtUsuario.Text = "";
                txtContraseña.Text = "";

            }
            else if (txtUsuario.Text == "Adm" && txtContraseña.Text == "@1a" && cmbModulo.SelectedIndex == 3)
            {

                DialogResult result = MessageBox.Show("Bienvenido/a sr/sra administrador/a", "Sintepart SRL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmVTA frmVTA = new frmVTA();
                frmVTA.Show();
                txtUsuario.Text = "";
                txtContraseña.Text = "";

            }
            else if (txtUsuario.Text == "Jhon" && txtContraseña.Text == "2b" && cmbModulo.SelectedIndex == 1)
            {

                DialogResult result = MessageBox.Show("Bienvenido Sr.Jhon", "Sintepart SRL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmSIST frmSIST = new frmSIST();
                frmSIST.Show();
                txtUsuario.Text = "";               
                txtContraseña.Text = "";

            }
            else if (txtUsuario.Text == "Ceci" && txtContraseña.Text == "@3c" && cmbModulo.SelectedIndex == 0)
            {

                DialogResult result = MessageBox.Show("Bienvenida Sra.Ceci", "Sintepart SRL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmADM frmADM = new frmADM();
                frmADM.Show();
                txtUsuario.Text = "";
                txtContraseña.Text = "";

            }
            else if (txtUsuario.Text == "Ceci" && txtContraseña.Text == "@3c" && cmbModulo.SelectedIndex == 3)
            {
                
                DialogResult result = MessageBox.Show("Bienvenida Sra.Ceci", "Sintepart SRL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmVTA frmVTA = new frmVTA();
                frmVTA.Show();
                txtUsuario.Text = "";
                txtContraseña.Text = "";

            }
            else if (txtUsuario.Text == "God" && txtContraseña.Text == "@#4d" && cmbModulo.SelectedIndex == 0)
            {
                DialogResult result = MessageBox.Show("Bienvenido Sr.Dios" + "\n" + "Amèn", "Sintepart SRL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmADM frmADM = new frmADM();
                frmADM.Show();
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
            else if (txtUsuario.Text == "God" && txtContraseña.Text == "@#4d" && cmbModulo.SelectedIndex == 1)
            {
                DialogResult result = MessageBox.Show("Bienvenido Sr.Dios" + "\n" + "Amèn", "Sintepart SRL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmSIST frmSIST = new frmSIST();
                frmSIST.Show();
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
            else if (txtUsuario.Text == "God" && txtContraseña.Text == "@#4d" && cmbModulo.SelectedIndex == 2)
            {
                DialogResult result = MessageBox.Show("Bienvenido Sr.Dios" + "\n" + "Amèn", "Sintepart SRL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmCOM frmCOM = new frmCOM();
                frmCOM.Show();
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
            else if (txtUsuario.Text == "God" && txtContraseña.Text == "@#4d" && cmbModulo.SelectedIndex == 3)
            {
                DialogResult result = MessageBox.Show("Bienvenido Sr.Dios" + "\n" + "Amèn", "Sintepart SRL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmVTA frmVTA = new frmVTA();
                frmVTA.Show();
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrectos para el modulo seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtContraseña.Clear();
                txtUsuario.Focus();
            }
        }
    }
}
