
namespace POO1
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
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtbanco = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtdinero = new System.Windows.Forms.TextBox();
            this.txtfirma = new System.Windows.Forms.TextBox();
            this.lstcheckinfo = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(154, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "cheque";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(154, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "banco";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(154, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "usuario";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(154, 265);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "dinero";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(154, 341);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "firmna";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(284, 49);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 26);
            this.txtid.TabIndex = 5;
            // 
            // txtbanco
            // 
            this.txtbanco.Location = new System.Drawing.Point(284, 113);
            this.txtbanco.Name = "txtbanco";
            this.txtbanco.Size = new System.Drawing.Size(233, 26);
            this.txtbanco.TabIndex = 6;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(284, 185);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(233, 26);
            this.txtusuario.TabIndex = 7;
            // 
            // txtdinero
            // 
            this.txtdinero.Location = new System.Drawing.Point(284, 259);
            this.txtdinero.Name = "txtdinero";
            this.txtdinero.Size = new System.Drawing.Size(100, 26);
            this.txtdinero.TabIndex = 8;
            // 
            // txtfirma
            // 
            this.txtfirma.Location = new System.Drawing.Point(284, 341);
            this.txtfirma.Name = "txtfirma";
            this.txtfirma.Size = new System.Drawing.Size(100, 26);
            this.txtfirma.TabIndex = 9;
            // 
            // lstcheckinfo
            // 
            this.lstcheckinfo.FormattingEnabled = true;
            this.lstcheckinfo.ItemHeight = 20;
            this.lstcheckinfo.Location = new System.Drawing.Point(812, 49);
            this.lstcheckinfo.Name = "lstcheckinfo";
            this.lstcheckinfo.Size = new System.Drawing.Size(485, 184);
            this.lstcheckinfo.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(670, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 38);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1324, 504);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstcheckinfo);
            this.Controls.Add(this.txtfirma);
            this.Controls.Add(this.txtdinero);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtbanco);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.TextBox txbanco;
        private System.Windows.Forms.TextBox txusuario;
        private System.Windows.Forms.TextBox txcantidad;
        private System.Windows.Forms.TextBox txfirma;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ListBox lstChequeinfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtbanco;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtdinero;
        private System.Windows.Forms.TextBox txtfirma;
        private System.Windows.Forms.ListBox lstcheckinfo;
        private System.Windows.Forms.Button btnAdd;
    }
}

