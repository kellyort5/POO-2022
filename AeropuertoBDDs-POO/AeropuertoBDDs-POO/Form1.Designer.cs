namespace AeropuertoBDDs_POO
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
            this.btmPasajeros = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPasajeros = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmPasajeros
            // 
            this.btmPasajeros.Location = new System.Drawing.Point(6, 19);
            this.btmPasajeros.Name = "btmPasajeros";
            this.btmPasajeros.Size = new System.Drawing.Size(102, 29);
            this.btmPasajeros.TabIndex = 0;
            this.btmPasajeros.Text = "Mostrar pasajeros";
            this.btmPasajeros.UseVisualStyleBackColor = true;
            this.btmPasajeros.Click += new System.EventHandler(this.btmPasajeros_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPasajeros);
            this.groupBox1.Controls.Add(this.btmPasajeros);
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 430);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pasajeros sin parametros";
            // 
            // txtPasajeros
            // 
            this.txtPasajeros.Location = new System.Drawing.Point(6, 54);
            this.txtPasajeros.Multiline = true;
            this.txtPasajeros.Name = "txtPasajeros";
            this.txtPasajeros.Size = new System.Drawing.Size(579, 370);
            this.txtPasajeros.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 449);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Aerolinea ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtPasajeros;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Button btmPasajeros;

        #endregion
    }
}