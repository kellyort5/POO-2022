namespace TalleresGraficosU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logo = new System.Windows.Forms.PictureBox();
            this.baner = new System.Windows.Forms.PictureBox();
            this.pnlCabeza = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEncuadernado = new System.Windows.Forms.Button();
            this.btnbarniz = new System.Windows.Forms.Button();
            this.btnPlegado = new System.Windows.Forms.Button();
            this.grbCarrito = new System.Windows.Forms.GroupBox();
            this.txtCarrito = new System.Windows.Forms.TextBox();
            this.tipo_pago = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.baner)).BeginInit();
            this.pnlCabeza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.grbCarrito.SuspendLayout();
            this.tipo_pago.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image) (resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(3, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(65, 73);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // baner
            // 
            this.baner.Image = ((System.Drawing.Image) (resources.GetObject("baner.Image")));
            this.baner.Location = new System.Drawing.Point(74, 3);
            this.baner.Name = "baner";
            this.baner.Size = new System.Drawing.Size(510, 73);
            this.baner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.baner.TabIndex = 1;
            this.baner.TabStop = false;
            // 
            // pnlCabeza
            // 
            this.pnlCabeza.Controls.Add(this.baner);
            this.pnlCabeza.Controls.Add(this.logo);
            this.pnlCabeza.Location = new System.Drawing.Point(12, 12);
            this.pnlCabeza.Name = "pnlCabeza";
            this.pnlCabeza.Size = new System.Drawing.Size(587, 76);
            this.pnlCabeza.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnEncuadernado
            // 
            this.btnEncuadernado.Image = ((System.Drawing.Image) (resources.GetObject("btnEncuadernado.Image")));
            this.btnEncuadernado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEncuadernado.Location = new System.Drawing.Point(12, 241);
            this.btnEncuadernado.Name = "btnEncuadernado";
            this.btnEncuadernado.Size = new System.Drawing.Size(174, 61);
            this.btnEncuadernado.TabIndex = 4;
            this.btnEncuadernado.Text = "Encuadernado";
            this.btnEncuadernado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncuadernado.UseVisualStyleBackColor = true;
            this.btnEncuadernado.Click += new System.EventHandler(this.btnEncuadernado_Click);
            // 
            // btnbarniz
            // 
            this.btnbarniz.Image = ((System.Drawing.Image) (resources.GetObject("btnbarniz.Image")));
            this.btnbarniz.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbarniz.Location = new System.Drawing.Point(209, 241);
            this.btnbarniz.Name = "btnbarniz";
            this.btnbarniz.Size = new System.Drawing.Size(194, 61);
            this.btnbarniz.TabIndex = 5;
            this.btnbarniz.Text = "Barniz";
            this.btnbarniz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbarniz.UseVisualStyleBackColor = true;
            this.btnbarniz.Click += new System.EventHandler(this.btnbarniz_Click);
            // 
            // btnPlegado
            // 
            this.btnPlegado.Image = ((System.Drawing.Image) (resources.GetObject("btnPlegado.Image")));
            this.btnPlegado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlegado.Location = new System.Drawing.Point(425, 241);
            this.btnPlegado.Name = "btnPlegado";
            this.btnPlegado.Size = new System.Drawing.Size(174, 61);
            this.btnPlegado.TabIndex = 6;
            this.btnPlegado.Text = "Plegados";
            this.btnPlegado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlegado.UseVisualStyleBackColor = true;
            this.btnPlegado.Click += new System.EventHandler(this.btnPlegado_Click);
            // 
            // grbCarrito
            // 
            this.grbCarrito.Controls.Add(this.txtCarrito);
            this.grbCarrito.Location = new System.Drawing.Point(14, 308);
            this.grbCarrito.Name = "grbCarrito";
            this.grbCarrito.Size = new System.Drawing.Size(389, 169);
            this.grbCarrito.TabIndex = 7;
            this.grbCarrito.TabStop = false;
            this.grbCarrito.Text = "Carrito";
            // 
            // txtCarrito
            // 
            this.txtCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtCarrito.Location = new System.Drawing.Point(6, 25);
            this.txtCarrito.Multiline = true;
            this.txtCarrito.Name = "txtCarrito";
            this.txtCarrito.ReadOnly = true;
            this.txtCarrito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCarrito.Size = new System.Drawing.Size(383, 126);
            this.txtCarrito.TabIndex = 0;
            // 
            // tipo_pago
            // 
            this.tipo_pago.Controls.Add(this.button1);
            this.tipo_pago.Location = new System.Drawing.Point(421, 351);
            this.tipo_pago.Name = "tipo_pago";
            this.tipo_pago.Size = new System.Drawing.Size(175, 76);
            this.tipo_pago.TabIndex = 8;
            this.tipo_pago.TabStop = false;
            this.tipo_pago.Text = "Tipo de pago";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(16, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 489);
            this.Controls.Add(this.tipo_pago);
            this.Controls.Add(this.grbCarrito);
            this.Controls.Add(this.btnPlegado);
            this.Controls.Add(this.btnbarniz);
            this.Controls.Add(this.btnEncuadernado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlCabeza);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taller Grafico UCA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.baner)).EndInit();
            this.pnlCabeza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.grbCarrito.ResumeLayout(false);
            this.grbCarrito.PerformLayout();
            this.tipo_pago.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox tipo_pago;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox txtCarrito;

        private System.Windows.Forms.GroupBox grbCarrito;

        private System.Windows.Forms.Button btnbarniz;
        private System.Windows.Forms.Button btnPlegado;

        private System.Windows.Forms.Button btnEncuadernado;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Panel pnlCabeza;

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox baner;

        #endregion
    }
}