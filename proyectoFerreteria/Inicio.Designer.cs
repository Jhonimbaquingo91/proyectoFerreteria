﻿
namespace proyectoFerreteria
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.pnlSubMante = new System.Windows.Forms.Panel();
            this.btnActiviarEm = new System.Windows.Forms.Button();
            this.btnAgregarRol = new System.Windows.Forms.Button();
            this.btnVerEm = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.pnlSubHerr = new System.Windows.Forms.Panel();
            this.btnAgregarPro = new System.Windows.Forms.Button();
            this.btnAgregarHerr = new System.Windows.Forms.Button();
            this.btnVerHerra = new System.Windows.Forms.Button();
            this.btnHerramientas = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlSubMante.SuspendLayout();
            this.pnlSubHerr.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 38);
            this.panel1.TabIndex = 3;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.White;
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.Black;
            this.btnMin.Location = new System.Drawing.Point(1178, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(26, 29);
            this.btnMin.TabIndex = 7;
            this.btnMin.Text = "-";
            this.btnMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(1210, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 29);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlMenu.Controls.Add(this.button2);
            this.pnlMenu.Controls.Add(this.btnCerrar);
            this.pnlMenu.Controls.Add(this.lblHora);
            this.pnlMenu.Controls.Add(this.pnlSubMante);
            this.pnlMenu.Controls.Add(this.btnMantenimiento);
            this.pnlMenu.Controls.Add(this.pnlSubHerr);
            this.pnlMenu.Controls.Add(this.btnHerramientas);
            this.pnlMenu.Controls.Add(this.btnInicio);
            this.pnlMenu.Controls.Add(this.flowLayoutPanel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 38);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(251, 542);
            this.pnlMenu.TabIndex = 4;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(82, 510);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 20);
            this.lblHora.TabIndex = 1;
            // 
            // pnlSubMante
            // 
            this.pnlSubMante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.pnlSubMante.Controls.Add(this.btnActiviarEm);
            this.pnlSubMante.Controls.Add(this.btnAgregarRol);
            this.pnlSubMante.Controls.Add(this.btnVerEm);
            this.pnlSubMante.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMante.Location = new System.Drawing.Point(0, 420);
            this.pnlSubMante.Name = "pnlSubMante";
            this.pnlSubMante.Size = new System.Drawing.Size(251, 131);
            this.pnlSubMante.TabIndex = 10;
            // 
            // btnActiviarEm
            // 
            this.btnActiviarEm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActiviarEm.FlatAppearance.BorderSize = 0;
            this.btnActiviarEm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActiviarEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActiviarEm.Location = new System.Drawing.Point(0, 86);
            this.btnActiviarEm.Name = "btnActiviarEm";
            this.btnActiviarEm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnActiviarEm.Size = new System.Drawing.Size(251, 43);
            this.btnActiviarEm.TabIndex = 10;
            this.btnActiviarEm.Text = "Activar usuario";
            this.btnActiviarEm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActiviarEm.UseVisualStyleBackColor = true;
            this.btnActiviarEm.Click += new System.EventHandler(this.btnActiviarEm_Click);
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarRol.FlatAppearance.BorderSize = 0;
            this.btnAgregarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRol.Location = new System.Drawing.Point(0, 43);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregarRol.Size = new System.Drawing.Size(251, 43);
            this.btnAgregarRol.TabIndex = 9;
            this.btnAgregarRol.Text = "Agregar rol";
            this.btnAgregarRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRol.UseVisualStyleBackColor = true;
            this.btnAgregarRol.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // btnVerEm
            // 
            this.btnVerEm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerEm.FlatAppearance.BorderSize = 0;
            this.btnVerEm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEm.Location = new System.Drawing.Point(0, 0);
            this.btnVerEm.Name = "btnVerEm";
            this.btnVerEm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVerEm.Size = new System.Drawing.Size(251, 43);
            this.btnVerEm.TabIndex = 8;
            this.btnVerEm.Text = "Ver empleados";
            this.btnVerEm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerEm.UseVisualStyleBackColor = true;
            this.btnVerEm.Click += new System.EventHandler(this.btnVerEm_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimiento.FlatAppearance.BorderSize = 0;
            this.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.Location = new System.Drawing.Point(0, 377);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMantenimiento.Size = new System.Drawing.Size(251, 43);
            this.btnMantenimiento.TabIndex = 9;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // pnlSubHerr
            // 
            this.pnlSubHerr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.pnlSubHerr.Controls.Add(this.btnAgregarPro);
            this.pnlSubHerr.Controls.Add(this.btnAgregarHerr);
            this.pnlSubHerr.Controls.Add(this.btnVerHerra);
            this.pnlSubHerr.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubHerr.Location = new System.Drawing.Point(0, 245);
            this.pnlSubHerr.Name = "pnlSubHerr";
            this.pnlSubHerr.Size = new System.Drawing.Size(251, 132);
            this.pnlSubHerr.TabIndex = 8;
            // 
            // btnAgregarPro
            // 
            this.btnAgregarPro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarPro.FlatAppearance.BorderSize = 0;
            this.btnAgregarPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPro.Location = new System.Drawing.Point(0, 86);
            this.btnAgregarPro.Name = "btnAgregarPro";
            this.btnAgregarPro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregarPro.Size = new System.Drawing.Size(251, 43);
            this.btnAgregarPro.TabIndex = 10;
            this.btnAgregarPro.Text = "Agregar proveedores";
            this.btnAgregarPro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPro.UseVisualStyleBackColor = true;
            this.btnAgregarPro.Click += new System.EventHandler(this.btnAgregarPro_Click);
            // 
            // btnAgregarHerr
            // 
            this.btnAgregarHerr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarHerr.FlatAppearance.BorderSize = 0;
            this.btnAgregarHerr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarHerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarHerr.Location = new System.Drawing.Point(0, 43);
            this.btnAgregarHerr.Name = "btnAgregarHerr";
            this.btnAgregarHerr.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregarHerr.Size = new System.Drawing.Size(251, 43);
            this.btnAgregarHerr.TabIndex = 9;
            this.btnAgregarHerr.Text = "Agregar herramientas";
            this.btnAgregarHerr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarHerr.UseVisualStyleBackColor = true;
            // 
            // btnVerHerra
            // 
            this.btnVerHerra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerHerra.FlatAppearance.BorderSize = 0;
            this.btnVerHerra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerHerra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerHerra.Location = new System.Drawing.Point(0, 0);
            this.btnVerHerra.Name = "btnVerHerra";
            this.btnVerHerra.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVerHerra.Size = new System.Drawing.Size(251, 43);
            this.btnVerHerra.TabIndex = 8;
            this.btnVerHerra.Text = "Ver herramientas";
            this.btnVerHerra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerHerra.UseVisualStyleBackColor = true;
            this.btnVerHerra.Click += new System.EventHandler(this.btnVerHerra_Click);
            // 
            // btnHerramientas
            // 
            this.btnHerramientas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHerramientas.FlatAppearance.BorderSize = 0;
            this.btnHerramientas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHerramientas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerramientas.Location = new System.Drawing.Point(0, 202);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHerramientas.Size = new System.Drawing.Size(251, 43);
            this.btnHerramientas.TabIndex = 7;
            this.btnHerramientas.Text = "Herramientas";
            this.btnHerramientas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHerramientas.UseVisualStyleBackColor = true;
            this.btnHerramientas.Click += new System.EventHandler(this.btnHerramientas_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(0, 159);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(251, 43);
            this.btnInicio.TabIndex = 6;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::proyectoFerreteria.Properties.Resources.login1F;
            this.panel2.Controls.Add(this.pnlContenedor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(251, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 542);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlContenedor.Location = new System.Drawing.Point(37, 58);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(916, 472);
            this.pnlContenedor.TabIndex = 0;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::proyectoFerreteria.Properties.Resources.shutdown_40px;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(12, 499);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(41, 40);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(251, 159);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::proyectoFerreteria.Properties.Resources.drill_48px;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, -5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 38);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectoFerreteria.Properties.Resources.herramienta_imagen_animada_0002;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 551);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(251, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "Reportes";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1241, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimientos";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlSubMante.ResumeLayout(false);
            this.pnlSubHerr.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlSubMante;
        private System.Windows.Forms.Button btnActiviarEm;
        private System.Windows.Forms.Button btnAgregarRol;
        private System.Windows.Forms.Button btnVerEm;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Panel pnlSubHerr;
        private System.Windows.Forms.Button btnAgregarPro;
        private System.Windows.Forms.Button btnAgregarHerr;
        private System.Windows.Forms.Button btnVerHerra;
        private System.Windows.Forms.Button btnHerramientas;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label lblHora;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}