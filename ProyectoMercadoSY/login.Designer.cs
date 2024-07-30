namespace ProyectoMercadoSY
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            textUser = new TextBox();
            textpass = new TextBox();
            Ingresarbt = new Button();
            Saliebt = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textUser
            // 
            textUser.BackColor = Color.PaleTurquoise;
            textUser.Location = new Point(344, 82);
            textUser.Name = "textUser";
            textUser.Size = new Size(299, 27);
            textUser.TabIndex = 0;
            textUser.TextChanged += textUser_TextChanged;
            // 
            // textpass
            // 
            textpass.BackColor = Color.PaleTurquoise;
            textpass.Location = new Point(344, 172);
            textpass.Name = "textpass";
            textpass.Size = new Size(299, 27);
            textpass.TabIndex = 1;
            textpass.TextChanged += textpass_TextChanged;
            // 
            // Ingresarbt
            // 
            Ingresarbt.BackColor = Color.SteelBlue;
            Ingresarbt.Cursor = Cursors.Hand;
            Ingresarbt.Location = new Point(333, 248);
            Ingresarbt.Name = "Ingresarbt";
            Ingresarbt.Size = new Size(150, 40);
            Ingresarbt.TabIndex = 2;
            Ingresarbt.Text = "Ingresar";
            Ingresarbt.UseVisualStyleBackColor = false;
            Ingresarbt.Click += Ingresarbt_Click;
            // 
            // Saliebt
            // 
            Saliebt.BackColor = Color.Crimson;
            Saliebt.Cursor = Cursors.Hand;
            Saliebt.Location = new Point(506, 248);
            Saliebt.Name = "Saliebt";
            Saliebt.Size = new Size(150, 40);
            Saliebt.TabIndex = 3;
            Saliebt.Text = "Salir";
            Saliebt.UseVisualStyleBackColor = false;
            Saliebt.Click += Saliebt_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 328);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(37, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 192);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 24);
            label1.Name = "label1";
            label1.Size = new Size(240, 41);
            label1.TabIndex = 5;
            label1.Text = "Ingrese Usuario :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(344, 128);
            label2.Name = "label2";
            label2.Size = new Size(289, 41);
            label2.TabIndex = 6;
            label2.Text = "Ingrese Contraseña :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 248);
            label3.Name = "label3";
            label3.Size = new Size(305, 50);
            label3.TabIndex = 1;
            label3.Text = "Sistema Mercado";
            label3.Click += label3_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(698, 328);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(Saliebt);
            Controls.Add(Ingresarbt);
            Controls.Add(textpass);
            Controls.Add(textUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUser;
        private TextBox textpass;
        private Button Ingresarbt;
        private Button Saliebt;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}
