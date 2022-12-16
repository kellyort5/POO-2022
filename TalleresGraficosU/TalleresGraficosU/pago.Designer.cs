using System.ComponentModel;

namespace TalleresGraficosU
{
    partial class pago
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grbPago = new System.Windows.Forms.GroupBox();
            this.radefectivo = new System.Windows.Forms.RadioButton();
            this.radtarjeta = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.grbPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(89, 12);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(238, 24);
            this.txtnombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edad:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 24);
            this.textBox1.TabIndex = 3;
            // 
            // grbPago
            // 
            this.grbPago.Controls.Add(this.radefectivo);
            this.grbPago.Controls.Add(this.radtarjeta);
            this.grbPago.Location = new System.Drawing.Point(18, 114);
            this.grbPago.Name = "grbPago";
            this.grbPago.Size = new System.Drawing.Size(208, 121);
            this.grbPago.TabIndex = 4;
            this.grbPago.TabStop = false;
            this.grbPago.Text = "Metodo de pago";
            // 
            // radefectivo
            // 
            this.radefectivo.Location = new System.Drawing.Point(112, 53);
            this.radefectivo.Name = "radefectivo";
            this.radefectivo.Size = new System.Drawing.Size(90, 22);
            this.radefectivo.TabIndex = 1;
            this.radefectivo.TabStop = true;
            this.radefectivo.Text = "Efectivo";
            this.radefectivo.UseVisualStyleBackColor = true;
            // 
            // radtarjeta
            // 
            this.radtarjeta.Location = new System.Drawing.Point(20, 53);
            this.radtarjeta.Name = "radtarjeta";
            this.radtarjeta.Size = new System.Drawing.Size(101, 22);
            this.radtarjeta.TabIndex = 0;
            this.radtarjeta.TabStop = true;
            this.radtarjeta.Text = "Tarjeta";
            this.radtarjeta.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.DarkGray;
            this.btnContinuar.Location = new System.Drawing.Point(214, 270);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(103, 27);
            this.btnContinuar.TabIndex = 6;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btncancelar.Location = new System.Drawing.Point(105, 270);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(103, 27);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 325);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbPago);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "pago";
            this.Text = "pago";
            this.grbPago.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btncancelar;

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grbPago;
        private System.Windows.Forms.RadioButton radtarjeta;
        private System.Windows.Forms.RadioButton radefectivo;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}