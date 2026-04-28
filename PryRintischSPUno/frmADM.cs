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
    public partial class frmADM : Form
    {
        public frmADM()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmDos frmDos = new frmDos();
            this.Hide();
            frmDos.Show();
        }

        private void frmADM_Load(object sender, EventArgs e)
        {
            lblHola.Left = (this.ClientSize.Width - lblHola.Width) / 2;
            lblHola.Top = (this.ClientSize.Height - lblHola.Height) / 4;
            btnVolver.Left = (this.ClientSize.Width - btnVolver.Width) / 2;
            btnVolver.Top = (this.ClientSize.Height - btnVolver.Height) / 2;
        }
    }
}
