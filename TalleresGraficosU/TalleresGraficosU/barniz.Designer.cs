using System.ComponentModel;

namespace TalleresGraficosU
{
    partial class barniz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(barniz));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbPlastificado = new System.Windows.Forms.GroupBox();
            this.radplasM = new System.Windows.Forms.RadioButton();
            this.radplasB = new System.Windows.Forms.RadioButton();
            this.grbbarniz = new System.Windows.Forms.GroupBox();
            this.radmate = new System.Windows.Forms.RadioButton();
            this.radbrillante = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnconfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.grbPlastificado.SuspendLayout();
            this.grbbarniz.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grbPlastificado
            // 
            this.grbPlastificado.Controls.Add(this.radplasM);
            this.grbPlastificado.Controls.Add(this.radplasB);
            this.grbPlastificado.Location = new System.Drawing.Point(244, 14);
            this.grbPlastificado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbPlastificado.Name = "grbPlastificado";
            this.grbPlastificado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbPlastificado.Size = new System.Drawing.Size(120, 96);
            this.grbPlastificado.TabIndex = 1;
            this.grbPlastificado.TabStop = false;
            this.grbPlastificado.Text = "Plastificado";
            // 
            // radplasM
            // 
            this.radplasM.Location = new System.Drawing.Point(7, 54);
            this.radplasM.Name = "radplasM";
            this.radplasM.Size = new System.Drawing.Size(109, 21);
            this.radplasM.TabIndex = 2;
            this.radplasM.TabStop = true;
            this.radplasM.Text = "Mate";
            this.radplasM.UseVisualStyleBackColor = true;
            // 
            // radplasB
            // 
            this.radplasB.Location = new System.Drawing.Point(7, 27);
            this.radplasB.Name = "radplasB";
            this.radplasB.Size = new System.Drawing.Size(109, 21);
            this.radplasB.TabIndex = 1;
            this.radplasB.TabStop = true;
            this.radplasB.Text = "Brillante";
            this.radplasB.UseVisualStyleBackColor = true;
            // 
            // grbbarniz
            // 
            this.grbbarniz.Controls.Add(this.radmate);
            this.grbbarniz.Controls.Add(this.radbrillante);
            this.grbbarniz.Location = new System.Drawing.Point(244, 120);
            this.grbbarniz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbbarniz.Name = "grbbarniz";
            this.grbbarniz.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbbarniz.Size = new System.Drawing.Size(120, 96);
            this.grbbarniz.TabIndex = 2;
            this.grbbarniz.TabStop = false;
            this.grbbarniz.Text = "Barniz";
            // 
            // radmate
            // 
            this.radmate.Location = new System.Drawing.Point(7, 56);
            this.radmate.Name = "radmate";
            this.radmate.Size = new System.Drawing.Size(109, 21);
            this.radmate.TabIndex = 1;
            this.radmate.TabStop = true;
            this.radmate.Text = "Mate";
            this.radmate.UseVisualStyleBackColor = true;
            // 
            // radbrillante
            // 
            this.radbrillante.Location = new System.Drawing.Point(7, 29);
            this.radbrillante.Name = "radbrillante";
            this.radbrillante.Size = new System.Drawing.Size(109, 21);
            this.radbrillante.TabIndex = 0;
            this.radbrillante.TabStop = true;
            this.radbrillante.Text = "Brillante";
            this.radbrillante.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(208, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.Color.DarkGray;
            this.btnconfirmar.Location = new System.Drawing.Point(315, 257);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(92, 27);
            this.btnconfirmar.TabIndex = 4;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // barniz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 342);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbbarniz);
            this.Controls.Add(this.grbPlastificado);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "barniz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "barniz";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.grbPlastificado.ResumeLayout(false);
            this.grbbarniz.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RadioButton radplasB;
        private System.Windows.Forms.RadioButton radplasM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnconfirmar;

        private System.Windows.Forms.GroupBox grbbarniz;

        private System.Windows.Forms.RadioButton radmate;
        private System.Windows.Forms.RadioButton radbrillante;

        private System.Windows.Forms.GroupBox grbPlastificado;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}