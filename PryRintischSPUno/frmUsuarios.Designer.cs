namespace PryRintischSPUno
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.lblAdm = new System.Windows.Forms.Label();
            this.lblJjhon = new System.Windows.Forms.Label();
            this.lblCeci = new System.Windows.Forms.Label();
            this.lblGod = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdm
            // 
            this.lblAdm.AutoSize = true;
            this.lblAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdm.Location = new System.Drawing.Point(12, 9);
            this.lblAdm.Name = "lblAdm";
            this.lblAdm.Size = new System.Drawing.Size(165, 39);
            this.lblAdm.TabIndex = 0;
            this.lblAdm.Text = "Usuario: Adm \r\ncontraseña:@1a\r\nAccesos: ADM - COM - VTA";
            // 
            // lblJjhon
            // 
            this.lblJjhon.AutoSize = true;
            this.lblJjhon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJjhon.Location = new System.Drawing.Point(194, 9);
            this.lblJjhon.Name = "lblJjhon";
            this.lblJjhon.Size = new System.Drawing.Size(93, 39);
            this.lblJjhon.TabIndex = 1;
            this.lblJjhon.Text = "Usuariuo: Jhon\r\nContraseña: 2b\r\nAcceso: SIST";
            // 
            // lblCeci
            // 
            this.lblCeci.AutoSize = true;
            this.lblCeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCeci.Location = new System.Drawing.Point(12, 78);
            this.lblCeci.Name = "lblCeci";
            this.lblCeci.Size = new System.Drawing.Size(126, 39);
            this.lblCeci.TabIndex = 2;
            this.lblCeci.Text = "Usuario: Ceci\r\nContraseña: @3c\r\nAccesos: ADM - VTA";
            // 
            // lblGod
            // 
            this.lblGod.AutoSize = true;
            this.lblGod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGod.Location = new System.Drawing.Point(194, 78);
            this.lblGod.Name = "lblGod";
            this.lblGod.Size = new System.Drawing.Size(113, 39);
            this.lblGod.TabIndex = 3;
            this.lblGod.Text = "Usuario: God\r\nContraseña: @#4d\r\nAccesos: Todo";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar.Location = new System.Drawing.Point(259, 125);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 160);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblGod);
            this.Controls.Add(this.lblCeci);
            this.Controls.Add(this.lblJjhon);
            this.Controls.Add(this.lblAdm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios y Contraseñas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdm;
        private System.Windows.Forms.Label lblJjhon;
        private System.Windows.Forms.Label lblCeci;
        private System.Windows.Forms.Label lblGod;
        private System.Windows.Forms.Button btnCerrar;
    }
}