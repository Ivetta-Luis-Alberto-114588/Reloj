namespace Reloj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblTiempo1 = new Label();
            label1 = new Label();
            lblSegundos1 = new Label();
            lblFecha1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblFecha1);
            panel1.Controls.Add(lblSegundos1);
            panel1.Controls.Add(lblTiempo1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(75, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 163);
            panel1.TabIndex = 0;
            // 
            // lblTiempo1
            // 
            lblTiempo1.AutoSize = true;
            lblTiempo1.BorderStyle = BorderStyle.FixedSingle;
            lblTiempo1.Font = new Font("DS-Digital", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblTiempo1.ForeColor = SystemColors.HighlightText;
            lblTiempo1.Location = new Point(109, 39);
            lblTiempo1.Name = "lblTiempo1";
            lblTiempo1.Size = new Size(118, 49);
            lblTiempo1.TabIndex = 1;
            lblTiempo1.Text = "13:00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(109, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 0;
            label1.Text = "Hora Local";
            // 
            // lblSegundos1
            // 
            lblSegundos1.AutoSize = true;
            lblSegundos1.BorderStyle = BorderStyle.FixedSingle;
            lblSegundos1.Font = new Font("DS-Digital", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundos1.ForeColor = SystemColors.HighlightText;
            lblSegundos1.Location = new Point(216, 39);
            lblSegundos1.Name = "lblSegundos1";
            lblSegundos1.Size = new Size(48, 33);
            lblSegundos1.TabIndex = 2;
            lblSegundos1.Text = "43";
            // 
            // lblFecha1
            // 
            lblFecha1.AutoSize = true;
            lblFecha1.BorderStyle = BorderStyle.FixedSingle;
            lblFecha1.Font = new Font("DS-Digital", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha1.ForeColor = SystemColors.HighlightText;
            lblFecha1.Location = new Point(35, 104);
            lblFecha1.Name = "lblFecha1";
            lblFecha1.Size = new Size(229, 37);
            lblFecha1.TabIndex = 3;
            lblFecha1.Text = "12 Agosto 2023";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1056, 475);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Reloj";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTiempo1;
        private Label label1;
        private Label lblSegundos1;
        private Label lblFecha1;
    }
}