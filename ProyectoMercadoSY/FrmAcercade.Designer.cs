namespace ProyectoMercadoSY
{
    partial class FrmAcercade
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
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 514);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 290);
            label5.Name = "label5";
            label5.Size = new Size(305, 20);
            label5.TabIndex = 4;
            label5.Text = "Carlos Daniel Gomez Pineda 0420199900201\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 322);
            label4.Name = "label4";
            label4.Size = new Size(242, 20);
            label4.TabIndex = 3;
            label4.Text = "Jose Carlos Ramos. 1807200000229\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 256);
            label3.Name = "label3";
            label3.Size = new Size(318, 20);
            label3.TabIndex = 2;
            label3.Text = "Kelyn Leonela Rodríguez Arias 0506200402192";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 219);
            label2.Name = "label2";
            label2.Size = new Size(388, 23);
            label2.TabIndex = 1;
            label2.Text = "David sebastian izaguirre sanchez 0801200320866\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 140);
            label1.Name = "label1";
            label1.Size = new Size(352, 50);
            label1.TabIndex = 0;
            label1.Text = "Proyecto hecho por:";
            // 
            // FrmAcercade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(625, 514);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAcercade";
            Text = "FrmAcercade";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}