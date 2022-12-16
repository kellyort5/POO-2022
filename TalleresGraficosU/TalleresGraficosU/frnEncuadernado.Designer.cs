using System.ComponentModel;

namespace TalleresGraficosU
{
    partial class frnEncuadernado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnEncuadernado));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbPegado = new System.Windows.Forms.GroupBox();
            this.radAnillado = new System.Windows.Forms.RadioButton();
            this.radEngrapado = new System.Windows.Forms.RadioButton();
            this.radHotMelt = new System.Windows.Forms.RadioButton();
            this.grbEmpastado = new System.Windows.Forms.GroupBox();
            this.radRustico = new System.Windows.Forms.RadioButton();
            this.radLujo = new System.Windows.Forms.RadioButton();
            this.btnCalcelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.grbPegado.SuspendLayout();
            this.grbEmpastado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grbPegado
            // 
            this.grbPegado.Controls.Add(this.radAnillado);
            this.grbPegado.Controls.Add(this.radEngrapado);
            this.grbPegado.Controls.Add(this.radHotMelt);
            this.grbPegado.Location = new System.Drawing.Point(205, 5);
            this.grbPegado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbPegado.Name = "grbPegado";
            this.grbPegado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbPegado.Size = new System.Drawing.Size(139, 135);
            this.grbPegado.TabIndex = 1;
            this.grbPegado.TabStop = false;
            this.grbPegado.Text = "Pegado";
            // 
            // radAnillado
            // 
            this.radAnillado.Location = new System.Drawing.Point(14, 62);
            this.radAnillado.Name = "radAnillado";
            this.radAnillado.Size = new System.Drawing.Size(103, 25);
            this.radAnillado.TabIndex = 2;
            this.radAnillado.TabStop = true;
            this.radAnillado.Text = "Anillado";
            this.radAnillado.UseVisualStyleBackColor = true;
            // 
            // radEngrapado
            // 
            this.radEngrapado.Location = new System.Drawing.Point(14, 93);
            this.radEngrapado.Name = "radEngrapado";
            this.radEngrapado.Size = new System.Drawing.Size(113, 25);
            this.radEngrapado.TabIndex = 1;
            this.radEngrapado.TabStop = true;
            this.radEngrapado.Text = "Engrapado";
            this.radEngrapado.UseVisualStyleBackColor = true;
            // 
            // radHotMelt
            // 
            this.radHotMelt.Location = new System.Drawing.Point(14, 31);
            this.radHotMelt.Name = "radHotMelt";
            this.radHotMelt.Size = new System.Drawing.Size(103, 25);
            this.radHotMelt.TabIndex = 0;
            this.radHotMelt.TabStop = true;
            this.radHotMelt.Text = "Hot Melt";
            this.radHotMelt.UseVisualStyleBackColor = true;
            // 
            // grbEmpastado
            // 
            this.grbEmpastado.Controls.Add(this.radRustico);
            this.grbEmpastado.Controls.Add(this.radLujo);
            this.grbEmpastado.Location = new System.Drawing.Point(205, 150);
            this.grbEmpastado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbEmpastado.Name = "grbEmpastado";
            this.grbEmpastado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbEmpastado.Size = new System.Drawing.Size(139, 112);
            this.grbEmpastado.TabIndex = 3;
            this.grbEmpastado.TabStop = false;
            this.grbEmpastado.Text = "Empastado";
            // 
            // radRustico
            // 
            this.radRustico.Location = new System.Drawing.Point(14, 62);
            this.radRustico.Name = "radRustico";
            this.radRustico.Size = new System.Drawing.Size(113, 25);
            this.radRustico.TabIndex = 1;
            this.radRustico.TabStop = true;
            this.radRustico.Text = "Rustico";
            this.radRustico.UseVisualStyleBackColor = true;
            // 
            // radLujo
            // 
            this.radLujo.Location = new System.Drawing.Point(14, 31);
            this.radLujo.Name = "radLujo";
            this.radLujo.Size = new System.Drawing.Size(103, 25);
            this.radLujo.TabIndex = 0;
            this.radLujo.TabStop = true;
            this.radLujo.Text = "De Lujo";
            this.radLujo.UseVisualStyleBackColor = true;
            // 
            // btnCalcelar
            // 
            this.btnCalcelar.BackColor = System.Drawing.Color.Salmon;
            this.btnCalcelar.Location = new System.Drawing.Point(208, 281);
            this.btnCalcelar.Name = "btnCalcelar";
            this.btnCalcelar.Size = new System.Drawing.Size(85, 30);
            this.btnCalcelar.TabIndex = 4;
            this.btnCalcelar.Text = "Cancelar";
            this.btnCalcelar.UseVisualStyleBackColor = false;
            this.btnCalcelar.Click += new System.EventHandler(this.btnCalcelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(299, 281);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 30);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frnEncuadernado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 374);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCalcelar);
            this.Controls.Add(this.grbEmpastado);
            this.Controls.Add(this.grbPegado);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frnEncuadernado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encuadernado";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.grbPegado.ResumeLayout(false);
            this.grbEmpastado.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCalcelar;
        private System.Windows.Forms.Button btnConfirmar;

        private System.Windows.Forms.GroupBox grbEmpastado;
        private System.Windows.Forms.RadioButton radRustico;
        private System.Windows.Forms.RadioButton radLujo;

        private System.Windows.Forms.RadioButton radHotMelt;
        private System.Windows.Forms.RadioButton radEngrapado;
        private System.Windows.Forms.RadioButton radAnillado;

        private System.Windows.Forms.GroupBox grbPegado;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}