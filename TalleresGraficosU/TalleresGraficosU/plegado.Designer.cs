using System.ComponentModel;

namespace TalleresGraficosU
{
    partial class plegado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(plegado));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbacabados = new System.Windows.Forms.GroupBox();
            this.radacordeon = new System.Windows.Forms.RadioButton();
            this.radcuadriptico = new System.Windows.Forms.RadioButton();
            this.radtriptico = new System.Windows.Forms.RadioButton();
            this.radDiptico = new System.Windows.Forms.RadioButton();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnconfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.grbacabados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grbacabados
            // 
            this.grbacabados.Controls.Add(this.radacordeon);
            this.grbacabados.Controls.Add(this.radcuadriptico);
            this.grbacabados.Controls.Add(this.radtriptico);
            this.grbacabados.Controls.Add(this.radDiptico);
            this.grbacabados.Location = new System.Drawing.Point(223, 12);
            this.grbacabados.Name = "grbacabados";
            this.grbacabados.Size = new System.Drawing.Size(136, 196);
            this.grbacabados.TabIndex = 1;
            this.grbacabados.TabStop = false;
            this.grbacabados.Text = "Acabados";
            // 
            // radacordeon
            // 
            this.radacordeon.Location = new System.Drawing.Point(13, 159);
            this.radacordeon.Name = "radacordeon";
            this.radacordeon.Size = new System.Drawing.Size(102, 24);
            this.radacordeon.TabIndex = 3;
            this.radacordeon.TabStop = true;
            this.radacordeon.Text = "Acordeón";
            this.radacordeon.UseVisualStyleBackColor = true;
            // 
            // radcuadriptico
            // 
            this.radcuadriptico.Location = new System.Drawing.Point(13, 113);
            this.radcuadriptico.Name = "radcuadriptico";
            this.radcuadriptico.Size = new System.Drawing.Size(108, 24);
            this.radcuadriptico.TabIndex = 2;
            this.radcuadriptico.TabStop = true;
            this.radcuadriptico.Text = "Cuadriptico";
            this.radcuadriptico.UseVisualStyleBackColor = true;
            // 
            // radtriptico
            // 
            this.radtriptico.Location = new System.Drawing.Point(13, 69);
            this.radtriptico.Name = "radtriptico";
            this.radtriptico.Size = new System.Drawing.Size(102, 24);
            this.radtriptico.TabIndex = 1;
            this.radtriptico.TabStop = true;
            this.radtriptico.Text = "Triptico";
            this.radtriptico.UseVisualStyleBackColor = true;
            // 
            // radDiptico
            // 
            this.radDiptico.Location = new System.Drawing.Point(13, 28);
            this.radDiptico.Name = "radDiptico";
            this.radDiptico.Size = new System.Drawing.Size(102, 24);
            this.radDiptico.TabIndex = 0;
            this.radDiptico.TabStop = true;
            this.radDiptico.Text = "Diptico";
            this.radDiptico.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.MistyRose;
            this.btncancelar.Location = new System.Drawing.Point(193, 249);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(91, 35);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.Color.DarkGray;
            this.btnconfirmar.Location = new System.Drawing.Point(302, 249);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(94, 35);
            this.btnconfirmar.TabIndex = 3;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // plegado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(408, 315);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.grbacabados);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "plegado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "plegado";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.grbacabados.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnconfirmar;

        private System.Windows.Forms.RadioButton radtriptico;
        private System.Windows.Forms.RadioButton radcuadriptico;
        private System.Windows.Forms.RadioButton radacordeon;

        private System.Windows.Forms.GroupBox grbacabados;
        private System.Windows.Forms.RadioButton radDiptico;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}