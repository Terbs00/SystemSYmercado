namespace ProyectoMercadoSY
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            panel1 = new Panel();
            butask = new Button();
            butreport = new Button();
            butprove = new Button();
            butclient = new Button();
            butproduct = new Button();
            butuser = new Button();
            pictureBox1 = new PictureBox();
            panelpantalla = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(butask);
            panel1.Controls.Add(butreport);
            panel1.Controls.Add(butprove);
            panel1.Controls.Add(butclient);
            panel1.Controls.Add(butproduct);
            panel1.Controls.Add(butuser);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 617);
            panel1.TabIndex = 0;
            // 
            // butask
            // 
            butask.Location = new Point(44, 520);
            butask.Name = "butask";
            butask.Size = new Size(188, 46);
            butask.TabIndex = 6;
            butask.Text = "Acerca de";
            butask.UseVisualStyleBackColor = true;
            butask.Click += butask_Click;
            // 
            // butreport
            // 
            butreport.Location = new Point(44, 450);
            butreport.Name = "butreport";
            butreport.Size = new Size(188, 46);
            butreport.TabIndex = 5;
            butreport.Text = "Reportes";
            butreport.UseVisualStyleBackColor = true;
            butreport.Click += butreport_Click;
            // 
            // butprove
            // 
            butprove.Location = new Point(44, 383);
            butprove.Name = "butprove";
            butprove.Size = new Size(188, 46);
            butprove.TabIndex = 4;
            butprove.Text = "proveedor";
            butprove.UseVisualStyleBackColor = true;
            butprove.Click += butprove_Click;
            // 
            // butclient
            // 
            butclient.Location = new Point(44, 319);
            butclient.Name = "butclient";
            butclient.Size = new Size(188, 46);
            butclient.TabIndex = 3;
            butclient.Text = "Clientes";
            butclient.UseVisualStyleBackColor = true;
            butclient.Click += butclient_Click;
            // 
            // butproduct
            // 
            butproduct.Location = new Point(44, 254);
            butproduct.Name = "butproduct";
            butproduct.Size = new Size(188, 46);
            butproduct.TabIndex = 2;
            butproduct.Text = "Producto";
            butproduct.UseVisualStyleBackColor = true;
            butproduct.Click += butproduct_Click;
            // 
            // butuser
            // 
            butuser.Location = new Point(44, 138);
            butuser.Name = "butuser";
            butuser.Size = new Size(188, 46);
            butuser.TabIndex = 1;
            butuser.Text = "Usuario";
            butuser.UseVisualStyleBackColor = true;
            butuser.Click += butuser_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(23, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelpantalla
            // 
            panelpantalla.BackColor = Color.Silver;
            panelpantalla.Dock = DockStyle.Fill;
            panelpantalla.Location = new Point(312, 0);
            panelpantalla.Name = "panelpantalla";
            panelpantalla.Size = new Size(719, 617);
            panelpantalla.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(44, 197);
            button1.Name = "button1";
            button1.Size = new Size(188, 46);
            button1.TabIndex = 7;
            button1.Text = "Compra";
            button1.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 617);
            Controls.Add(panelpantalla);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inicio";
            Text = "Inicio";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button butask;
        private Button butreport;
        private Button butprove;
        private Button butclient;
        private Button butproduct;
        private Button butuser;
        private Panel panelpantalla;
        private Button button1;
    }
}