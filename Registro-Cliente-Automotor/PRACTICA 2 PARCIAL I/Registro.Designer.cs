namespace PRACTICA_2_PARCIAL_I
{
    partial class frmREGISTRO_SERVICIOS
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPATENTE = new System.Windows.Forms.TextBox();
            this.txtCLIENTE = new System.Windows.Forms.TextBox();
            this.cmbTIPO_ACEITE = new System.Windows.Forms.ComboBox();
            this.txtLITRO_ACEITE = new System.Windows.Forms.TextBox();
            this.chkFILTRO_ACEITE = new System.Windows.Forms.CheckBox();
            this.chkFILTRO_AIRE = new System.Windows.Forms.CheckBox();
            this.chkFILTRO_COMBUSTIBLE = new System.Windows.Forms.CheckBox();
            this.txtIMPORTE = new System.Windows.Forms.TextBox();
            this.btnCALCULAR = new System.Windows.Forms.Button();
            this.btnLIMPIAR = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Aceite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Litro de Aceite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(220, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Importe Total";
            // 
            // txtPATENTE
            // 
            this.txtPATENTE.Location = new System.Drawing.Point(152, 33);
            this.txtPATENTE.Name = "txtPATENTE";
            this.txtPATENTE.Size = new System.Drawing.Size(119, 23);
            this.txtPATENTE.TabIndex = 8;
            this.txtPATENTE.TextChanged += new System.EventHandler(this.txtPATENTE_TextChanged);
            // 
            // txtCLIENTE
            // 
            this.txtCLIENTE.Location = new System.Drawing.Point(152, 74);
            this.txtCLIENTE.Name = "txtCLIENTE";
            this.txtCLIENTE.Size = new System.Drawing.Size(215, 23);
            this.txtCLIENTE.TabIndex = 9;
            this.txtCLIENTE.TextChanged += new System.EventHandler(this.txtCLIENTE_TextChanged);
            // 
            // cmbTIPO_ACEITE
            // 
            this.cmbTIPO_ACEITE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTIPO_ACEITE.FormattingEnabled = true;
            this.cmbTIPO_ACEITE.Location = new System.Drawing.Point(152, 116);
            this.cmbTIPO_ACEITE.Name = "cmbTIPO_ACEITE";
            this.cmbTIPO_ACEITE.Size = new System.Drawing.Size(215, 24);
            this.cmbTIPO_ACEITE.TabIndex = 10;
            this.cmbTIPO_ACEITE.SelectedIndexChanged += new System.EventHandler(this.cmbTIPO_ACEITE_SelectedIndexChanged);
            // 
            // txtLITRO_ACEITE
            // 
            this.txtLITRO_ACEITE.Location = new System.Drawing.Point(152, 159);
            this.txtLITRO_ACEITE.Name = "txtLITRO_ACEITE";
            this.txtLITRO_ACEITE.Size = new System.Drawing.Size(119, 23);
            this.txtLITRO_ACEITE.TabIndex = 11;
            this.txtLITRO_ACEITE.TextChanged += new System.EventHandler(this.txtLITRO_ACEITE_TextChanged);
            // 
            // chkFILTRO_ACEITE
            // 
            this.chkFILTRO_ACEITE.AutoSize = true;
            this.chkFILTRO_ACEITE.Location = new System.Drawing.Point(152, 204);
            this.chkFILTRO_ACEITE.Name = "chkFILTRO_ACEITE";
            this.chkFILTRO_ACEITE.Size = new System.Drawing.Size(177, 21);
            this.chkFILTRO_ACEITE.TabIndex = 12;
            this.chkFILTRO_ACEITE.Text = "Cambiar Filtro de Aceite";
            this.chkFILTRO_ACEITE.UseVisualStyleBackColor = true;
            // 
            // chkFILTRO_AIRE
            // 
            this.chkFILTRO_AIRE.AutoSize = true;
            this.chkFILTRO_AIRE.Location = new System.Drawing.Point(152, 240);
            this.chkFILTRO_AIRE.Name = "chkFILTRO_AIRE";
            this.chkFILTRO_AIRE.Size = new System.Drawing.Size(163, 21);
            this.chkFILTRO_AIRE.TabIndex = 13;
            this.chkFILTRO_AIRE.Text = "Cambiar Filtro de Aire";
            this.chkFILTRO_AIRE.UseVisualStyleBackColor = true;
            // 
            // chkFILTRO_COMBUSTIBLE
            // 
            this.chkFILTRO_COMBUSTIBLE.AutoSize = true;
            this.chkFILTRO_COMBUSTIBLE.Location = new System.Drawing.Point(152, 278);
            this.chkFILTRO_COMBUSTIBLE.Name = "chkFILTRO_COMBUSTIBLE";
            this.chkFILTRO_COMBUSTIBLE.Size = new System.Drawing.Size(215, 21);
            this.chkFILTRO_COMBUSTIBLE.TabIndex = 14;
            this.chkFILTRO_COMBUSTIBLE.Text = "Cambiar Filtro de Combustible";
            this.chkFILTRO_COMBUSTIBLE.UseVisualStyleBackColor = true;
            // 
            // txtIMPORTE
            // 
            this.txtIMPORTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIMPORTE.Location = new System.Drawing.Point(354, 359);
            this.txtIMPORTE.Name = "txtIMPORTE";
            this.txtIMPORTE.Size = new System.Drawing.Size(119, 27);
            this.txtIMPORTE.TabIndex = 15;
            // 
            // btnCALCULAR
            // 
            this.btnCALCULAR.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCALCULAR.Enabled = false;
            this.btnCALCULAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCALCULAR.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnCALCULAR.Location = new System.Drawing.Point(398, 26);
            this.btnCALCULAR.Name = "btnCALCULAR";
            this.btnCALCULAR.Size = new System.Drawing.Size(75, 37);
            this.btnCALCULAR.TabIndex = 16;
            this.btnCALCULAR.Text = "&Calcular";
            this.btnCALCULAR.UseVisualStyleBackColor = false;
            this.btnCALCULAR.Click += new System.EventHandler(this.btnCALCULAR_Click);
            // 
            // btnLIMPIAR
            // 
            this.btnLIMPIAR.BackColor = System.Drawing.Color.MediumPurple;
            this.btnLIMPIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIMPIAR.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnLIMPIAR.Location = new System.Drawing.Point(398, 77);
            this.btnLIMPIAR.Name = "btnLIMPIAR";
            this.btnLIMPIAR.Size = new System.Drawing.Size(75, 37);
            this.btnLIMPIAR.TabIndex = 17;
            this.btnLIMPIAR.Text = "&Limpiar";
            this.btnLIMPIAR.UseVisualStyleBackColor = false;
            this.btnLIMPIAR.Click += new System.EventHandler(this.btnLIMPIAR_Click);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCERRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnCERRAR.Location = new System.Drawing.Point(398, 152);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(75, 37);
            this.btnCERRAR.TabIndex = 18;
            this.btnCERRAR.Text = "&Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // frmREGISTRO_SERVICIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(507, 429);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.btnLIMPIAR);
            this.Controls.Add(this.btnCALCULAR);
            this.Controls.Add(this.txtIMPORTE);
            this.Controls.Add(this.chkFILTRO_COMBUSTIBLE);
            this.Controls.Add(this.chkFILTRO_AIRE);
            this.Controls.Add(this.chkFILTRO_ACEITE);
            this.Controls.Add(this.txtLITRO_ACEITE);
            this.Controls.Add(this.cmbTIPO_ACEITE);
            this.Controls.Add(this.txtCLIENTE);
            this.Controls.Add(this.txtPATENTE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmREGISTRO_SERVICIOS";
            this.Text = "Registro de Servicios";
            this.Load += new System.EventHandler(this.frmREGISTRO_SERVICIOS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPATENTE;
        private System.Windows.Forms.TextBox txtCLIENTE;
        private System.Windows.Forms.ComboBox cmbTIPO_ACEITE;
        private System.Windows.Forms.TextBox txtLITRO_ACEITE;
        private System.Windows.Forms.CheckBox chkFILTRO_ACEITE;
        private System.Windows.Forms.CheckBox chkFILTRO_AIRE;
        private System.Windows.Forms.CheckBox chkFILTRO_COMBUSTIBLE;
        private System.Windows.Forms.TextBox txtIMPORTE;
        private System.Windows.Forms.Button btnCALCULAR;
        private System.Windows.Forms.Button btnLIMPIAR;
        private System.Windows.Forms.Button btnCERRAR;
    }
}

