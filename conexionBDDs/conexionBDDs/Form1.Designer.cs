namespace conexionBDDs
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtnoparametros = new System.Windows.Forms.TextBox();
            this.btnCategoriaid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvcategorias = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnname = new System.Windows.Forms.Button();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.nudCategoriaid = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.txtdescrip = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvcategorias)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudCategoriaid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar categorias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnoparametros
            // 
            this.txtnoparametros.Location = new System.Drawing.Point(6, 45);
            this.txtnoparametros.Multiline = true;
            this.txtnoparametros.Name = "txtnoparametros";
            this.txtnoparametros.ReadOnly = true;
            this.txtnoparametros.Size = new System.Drawing.Size(455, 23);
            this.txtnoparametros.TabIndex = 3;
            // 
            // btnCategoriaid
            // 
            this.btnCategoriaid.Location = new System.Drawing.Point(189, 9);
            this.btnCategoriaid.Name = "btnCategoriaid";
            this.btnCategoriaid.Size = new System.Drawing.Size(138, 30);
            this.btnCategoriaid.TabIndex = 2;
            this.btnCategoriaid.Text = "Mostrar categorias por ID";
            this.btnCategoriaid.UseVisualStyleBackColor = true;
            this.btnCategoriaid.Click += new System.EventHandler(this.btnCategoriaid_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category ID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.dgvcategorias);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 156);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorias sin parametros";
            // 
            // dgvcategorias
            // 
            this.dgvcategorias.AllowUserToAddRows = false;
            this.dgvcategorias.AllowUserToDeleteRows = false;
            this.dgvcategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategorias.Location = new System.Drawing.Point(5, 19);
            this.dgvcategorias.Name = "dgvcategorias";
            this.dgvcategorias.ReadOnly = true;
            this.dgvcategorias.Size = new System.Drawing.Size(384, 134);
            this.dgvcategorias.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnname);
            this.groupBox2.Controls.Add(this.txtnombres);
            this.groupBox2.Controls.Add(this.nudCategoriaid);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnCategoriaid);
            this.groupBox2.Controls.Add(this.txtnoparametros);
            this.groupBox2.Location = new System.Drawing.Point(7, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 137);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categorias con parametros";
            // 
            // cmbname
            // 
            this.cmbname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbname.FormattingEnabled = true;
            this.cmbname.Location = new System.Drawing.Point(101, 80);
            this.cmbname.Name = "cmbname";
            this.cmbname.Size = new System.Drawing.Size(164, 21);
            this.cmbname.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category Name";
            // 
            // btnname
            // 
            this.btnname.Location = new System.Drawing.Point(303, 74);
            this.btnname.Name = "btnname";
            this.btnname.Size = new System.Drawing.Size(158, 30);
            this.btnname.TabIndex = 6;
            this.btnname.Text = "Mostrar categorias por NAME";
            this.btnname.UseVisualStyleBackColor = true;
            this.btnname.Click += new System.EventHandler(this.btnname_Click);
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(2, 110);
            this.txtnombres.Multiline = true;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.ReadOnly = true;
            this.txtnombres.Size = new System.Drawing.Size(459, 24);
            this.txtnombres.TabIndex = 7;
            // 
            // nudCategoriaid
            // 
            this.nudCategoriaid.Location = new System.Drawing.Point(85, 16);
            this.nudCategoriaid.Maximum = new decimal(new int[] {8, 0, 0, 0});
            this.nudCategoriaid.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudCategoriaid.Name = "nudCategoriaid";
            this.nudCategoriaid.ReadOnly = true;
            this.nudCategoriaid.Size = new System.Drawing.Size(85, 20);
            this.nudCategoriaid.TabIndex = 5;
            this.nudCategoriaid.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnmostrar);
            this.groupBox3.Controls.Add(this.txtdescrip);
            this.groupBox3.Controls.Add(this.txtnombre);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(4, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 125);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insertar Categorias";
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(386, 49);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(124, 26);
            this.btnmostrar.TabIndex = 2;
            this.btnmostrar.Text = "Agregar categoria";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // txtdescrip
            // 
            this.txtdescrip.Location = new System.Drawing.Point(108, 80);
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.Size = new System.Drawing.Size(260, 20);
            this.txtdescrip.TabIndex = 13;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(108, 24);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(260, 20);
            this.txtnombre.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(28, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Category Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvcategorias)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudCategoriaid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdescrip;
        private System.Windows.Forms.Button btnmostrar;

        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.ComboBox cmbname;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnname;
        private System.Windows.Forms.TextBox txtnombres;

        private System.Windows.Forms.DataGridView dgvcategorias;

        private System.Windows.Forms.NumericUpDown nudCategoriaid;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox txtnoparametros;
        private System.Windows.Forms.Button btnCategoriaid;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}