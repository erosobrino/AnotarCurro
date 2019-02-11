namespace AnotarCurro
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btAñadir = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCambiarDni = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAñadir
            // 
            this.btAñadir.Location = new System.Drawing.Point(12, 12);
            this.btAñadir.Name = "btAñadir";
            this.btAñadir.Size = new System.Drawing.Size(158, 91);
            this.btAñadir.TabIndex = 0;
            this.btAñadir.Text = "Añadir";
            this.btAñadir.UseVisualStyleBackColor = true;
            this.btAñadir.Click += new System.EventHandler(this.btAñadir_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtInfo.Location = new System.Drawing.Point(0, 109);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(492, 341);
            this.txtInfo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dni";
            // 
            // btCambiarDni
            // 
            this.btCambiarDni.Location = new System.Drawing.Point(359, 9);
            this.btCambiarDni.Name = "btCambiarDni";
            this.btCambiarDni.Size = new System.Drawing.Size(121, 44);
            this.btCambiarDni.TabIndex = 4;
            this.btCambiarDni.Text = "Cambiar";
            this.btCambiarDni.UseVisualStyleBackColor = true;
            this.btCambiarDni.Click += new System.EventHandler(this.btCambiarDni_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(232, 12);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(110, 22);
            this.txtDni.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Puerto";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(232, 47);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(110, 22);
            this.txtIP.TabIndex = 8;
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(232, 81);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(110, 22);
            this.txtPuerto.TabIndex = 9;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(359, 59);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(121, 44);
            this.btGuardar.TabIndex = 10;
            this.btGuardar.Text = "Guardar Datos";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btCambiarDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btAñadir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Servidor Curro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAñadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCambiarDni;
        private System.Windows.Forms.TextBox txtDni;
        public System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Button btGuardar;
    }
}

