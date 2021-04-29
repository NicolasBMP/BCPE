
namespace BCPE1
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtRAZONNP = new System.Windows.Forms.TextBox();
            this.txtIDCCLIENTE = new System.Windows.Forms.TextBox();
            this.txtNOMBRECLIENTE = new System.Windows.Forms.TextBox();
            this.txtCODIGOCUENTA = new System.Windows.Forms.TextBox();
            this.txtDEUDATOTAL = new System.Windows.Forms.TextBox();
            this.cmbMONEDA = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbMONEDA);
            this.panel1.Controls.Add(this.txtDEUDATOTAL);
            this.panel1.Controls.Add(this.txtCODIGOCUENTA);
            this.panel1.Controls.Add(this.txtNOMBRECLIENTE);
            this.panel1.Controls.Add(this.txtIDCCLIENTE);
            this.panel1.Controls.Add(this.txtRAZONNP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 311);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDC ClLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE DE CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CÓDIGO CUENTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "DEUDA TOTAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "RAZÓN DE NO PAGO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "MONEDA";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(179, 343);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(151, 40);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "GRABAR";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtRAZONNP
            // 
            this.txtRAZONNP.Location = new System.Drawing.Point(193, 196);
            this.txtRAZONNP.Multiline = true;
            this.txtRAZONNP.Name = "txtRAZONNP";
            this.txtRAZONNP.Size = new System.Drawing.Size(286, 100);
            this.txtRAZONNP.TabIndex = 6;
            // 
            // txtIDCCLIENTE
            // 
            this.txtIDCCLIENTE.Enabled = false;
            this.txtIDCCLIENTE.Location = new System.Drawing.Point(193, 20);
            this.txtIDCCLIENTE.Name = "txtIDCCLIENTE";
            this.txtIDCCLIENTE.Size = new System.Drawing.Size(147, 27);
            this.txtIDCCLIENTE.TabIndex = 7;
            // 
            // txtNOMBRECLIENTE
            // 
            this.txtNOMBRECLIENTE.Location = new System.Drawing.Point(193, 56);
            this.txtNOMBRECLIENTE.Name = "txtNOMBRECLIENTE";
            this.txtNOMBRECLIENTE.ReadOnly = true;
            this.txtNOMBRECLIENTE.Size = new System.Drawing.Size(286, 27);
            this.txtNOMBRECLIENTE.TabIndex = 8;
            // 
            // txtCODIGOCUENTA
            // 
            this.txtCODIGOCUENTA.Location = new System.Drawing.Point(193, 91);
            this.txtCODIGOCUENTA.Name = "txtCODIGOCUENTA";
            this.txtCODIGOCUENTA.ReadOnly = true;
            this.txtCODIGOCUENTA.Size = new System.Drawing.Size(216, 27);
            this.txtCODIGOCUENTA.TabIndex = 9;
            // 
            // txtDEUDATOTAL
            // 
            this.txtDEUDATOTAL.Location = new System.Drawing.Point(193, 125);
            this.txtDEUDATOTAL.Name = "txtDEUDATOTAL";
            this.txtDEUDATOTAL.ReadOnly = true;
            this.txtDEUDATOTAL.Size = new System.Drawing.Size(216, 27);
            this.txtDEUDATOTAL.TabIndex = 10;
            // 
            // cmbMONEDA
            // 
            this.cmbMONEDA.FormattingEnabled = true;
            this.cmbMONEDA.Items.AddRange(new object[] {
            "SOLES",
            "DOLARES"});
            this.cmbMONEDA.Location = new System.Drawing.Point(193, 162);
            this.cmbMONEDA.Name = "cmbMONEDA";
            this.cmbMONEDA.Size = new System.Drawing.Size(151, 28);
            this.cmbMONEDA.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 395);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Ingreso de Razón de No Pago";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtRAZONNP;
        private System.Windows.Forms.TextBox txtIDCCLIENTE;
        private System.Windows.Forms.TextBox txtNOMBRECLIENTE;
        private System.Windows.Forms.TextBox txtCODIGOCUENTA;
        private System.Windows.Forms.TextBox txtDEUDATOTAL;
        private System.Windows.Forms.ComboBox cmbMONEDA;
    }
}