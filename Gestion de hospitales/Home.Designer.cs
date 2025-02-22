﻿namespace Gestion_de_hospitales
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            PanelMenuLateral = new Panel();
            BotonFarmacia = new FontAwesome.Sharp.IconButton();
            AsistenciaMedica = new FontAwesome.Sharp.IconButton();
            BotonCerrarSesion = new FontAwesome.Sharp.IconButton();
            BotonContactos = new FontAwesome.Sharp.IconButton();
            BotonBaseDeDatos = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            BotonLogo = new FontAwesome.Sharp.IconButton();
            IconoTitulo = new FontAwesome.Sharp.IconPictureBox();
            Titulo = new Label();
            PanelSuperior = new Panel();
            MainPanel = new Panel();
            labelFecha = new Label();
            labelHora = new Label();
            HoraFecha = new System.Windows.Forms.Timer(components);
            PanelMenuLateral.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconoTitulo).BeginInit();
            PanelSuperior.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // PanelMenuLateral
            // 
            PanelMenuLateral.BackColor = Color.FromArgb(36, 37, 38);
            PanelMenuLateral.Controls.Add(BotonFarmacia);
            PanelMenuLateral.Controls.Add(AsistenciaMedica);
            PanelMenuLateral.Controls.Add(BotonCerrarSesion);
            PanelMenuLateral.Controls.Add(BotonContactos);
            PanelMenuLateral.Controls.Add(BotonBaseDeDatos);
            PanelMenuLateral.Controls.Add(panel1);
            PanelMenuLateral.Dock = DockStyle.Left;
            PanelMenuLateral.Location = new Point(0, 0);
            PanelMenuLateral.Name = "PanelMenuLateral";
            PanelMenuLateral.Size = new Size(220, 594);
            PanelMenuLateral.TabIndex = 14;
            // 
            // BotonFarmacia
            // 
            BotonFarmacia.Dock = DockStyle.Top;
            BotonFarmacia.FlatAppearance.BorderSize = 0;
            BotonFarmacia.FlatStyle = FlatStyle.Flat;
            BotonFarmacia.ForeColor = SystemColors.ControlLightLight;
            BotonFarmacia.IconChar = FontAwesome.Sharp.IconChar.PrescriptionBottleAlt;
            BotonFarmacia.IconColor = Color.White;
            BotonFarmacia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BotonFarmacia.ImageAlign = ContentAlignment.MiddleLeft;
            BotonFarmacia.Location = new Point(0, 440);
            BotonFarmacia.Name = "BotonFarmacia";
            BotonFarmacia.Padding = new Padding(10, 0, 20, 0);
            BotonFarmacia.Size = new Size(220, 100);
            BotonFarmacia.TabIndex = 6;
            BotonFarmacia.Tag = "Configuración";
            BotonFarmacia.Text = "Farmacia";
            BotonFarmacia.TextAlign = ContentAlignment.MiddleLeft;
            BotonFarmacia.TextImageRelation = TextImageRelation.ImageBeforeText;
            BotonFarmacia.UseVisualStyleBackColor = true;
            BotonFarmacia.Click += BotonFarmacia_Click;
            // 
            // AsistenciaMedica
            // 
            AsistenciaMedica.Dock = DockStyle.Top;
            AsistenciaMedica.FlatAppearance.BorderSize = 0;
            AsistenciaMedica.FlatStyle = FlatStyle.Flat;
            AsistenciaMedica.ForeColor = SystemColors.ControlLightLight;
            AsistenciaMedica.IconChar = FontAwesome.Sharp.IconChar.Robot;
            AsistenciaMedica.IconColor = Color.White;
            AsistenciaMedica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AsistenciaMedica.ImageAlign = ContentAlignment.MiddleLeft;
            AsistenciaMedica.Location = new Point(0, 340);
            AsistenciaMedica.Name = "AsistenciaMedica";
            AsistenciaMedica.Padding = new Padding(10, 0, 20, 0);
            AsistenciaMedica.Size = new Size(220, 100);
            AsistenciaMedica.TabIndex = 5;
            AsistenciaMedica.Tag = "Configuración";
            AsistenciaMedica.Text = "Asistente medico (IA)";
            AsistenciaMedica.TextAlign = ContentAlignment.MiddleLeft;
            AsistenciaMedica.TextImageRelation = TextImageRelation.ImageBeforeText;
            AsistenciaMedica.UseVisualStyleBackColor = true;
            AsistenciaMedica.Click += AsistenciaMedica_Click;
            // 
            // BotonCerrarSesion
            // 
            BotonCerrarSesion.Dock = DockStyle.Bottom;
            BotonCerrarSesion.FlatAppearance.BorderSize = 0;
            BotonCerrarSesion.FlatStyle = FlatStyle.Flat;
            BotonCerrarSesion.ForeColor = SystemColors.ControlLightLight;
            BotonCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            BotonCerrarSesion.IconColor = Color.White;
            BotonCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BotonCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            BotonCerrarSesion.Location = new Point(0, 542);
            BotonCerrarSesion.Name = "BotonCerrarSesion";
            BotonCerrarSesion.Padding = new Padding(10, 0, 20, 0);
            BotonCerrarSesion.Size = new Size(220, 52);
            BotonCerrarSesion.TabIndex = 4;
            BotonCerrarSesion.Tag = "Cerrar Sesion";
            BotonCerrarSesion.Text = "Cerrar Sesion";
            BotonCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            BotonCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            BotonCerrarSesion.UseVisualStyleBackColor = true;
            BotonCerrarSesion.Click += BotonCerrarSesion_Click_1;
            // 
            // BotonContactos
            // 
            BotonContactos.Dock = DockStyle.Top;
            BotonContactos.FlatAppearance.BorderSize = 0;
            BotonContactos.FlatStyle = FlatStyle.Flat;
            BotonContactos.ForeColor = SystemColors.ControlLightLight;
            BotonContactos.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            BotonContactos.IconColor = Color.White;
            BotonContactos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BotonContactos.ImageAlign = ContentAlignment.MiddleLeft;
            BotonContactos.Location = new Point(0, 240);
            BotonContactos.Name = "BotonContactos";
            BotonContactos.Padding = new Padding(10, 0, 20, 0);
            BotonContactos.Size = new Size(220, 100);
            BotonContactos.TabIndex = 2;
            BotonContactos.Tag = "Contactos";
            BotonContactos.Text = "Gestion de citas";
            BotonContactos.TextAlign = ContentAlignment.MiddleLeft;
            BotonContactos.TextImageRelation = TextImageRelation.ImageBeforeText;
            BotonContactos.UseVisualStyleBackColor = true;
            BotonContactos.Click += BotonConfiguracion_Click;
            // 
            // BotonBaseDeDatos
            // 
            BotonBaseDeDatos.Dock = DockStyle.Top;
            BotonBaseDeDatos.FlatAppearance.BorderSize = 0;
            BotonBaseDeDatos.FlatStyle = FlatStyle.Flat;
            BotonBaseDeDatos.ForeColor = SystemColors.ControlLightLight;
            BotonBaseDeDatos.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            BotonBaseDeDatos.IconColor = Color.White;
            BotonBaseDeDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BotonBaseDeDatos.ImageAlign = ContentAlignment.MiddleLeft;
            BotonBaseDeDatos.Location = new Point(0, 140);
            BotonBaseDeDatos.Name = "BotonBaseDeDatos";
            BotonBaseDeDatos.Padding = new Padding(10, 0, 20, 0);
            BotonBaseDeDatos.Size = new Size(220, 100);
            BotonBaseDeDatos.TabIndex = 1;
            BotonBaseDeDatos.Tag = "Base de datos";
            BotonBaseDeDatos.Text = "Gestion de pacientes";
            BotonBaseDeDatos.TextAlign = ContentAlignment.MiddleLeft;
            BotonBaseDeDatos.TextImageRelation = TextImageRelation.ImageBeforeText;
            BotonBaseDeDatos.UseVisualStyleBackColor = true;
            BotonBaseDeDatos.Click += BotonBaseDeDatos_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BotonLogo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 140);
            panel1.TabIndex = 0;
            // 
            // BotonLogo
            // 
            BotonLogo.Dock = DockStyle.Fill;
            BotonLogo.FlatAppearance.BorderSize = 0;
            BotonLogo.FlatStyle = FlatStyle.Flat;
            BotonLogo.ForeColor = SystemColors.ControlLightLight;
            BotonLogo.IconChar = FontAwesome.Sharp.IconChar.Hospital;
            BotonLogo.IconColor = Color.White;
            BotonLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BotonLogo.IconSize = 90;
            BotonLogo.Location = new Point(0, 0);
            BotonLogo.Name = "BotonLogo";
            BotonLogo.Padding = new Padding(10, 0, 20, 0);
            BotonLogo.Size = new Size(220, 140);
            BotonLogo.TabIndex = 5;
            BotonLogo.Text = "Hospital los bolos unidos";
            BotonLogo.TextImageRelation = TextImageRelation.ImageAboveText;
            BotonLogo.UseVisualStyleBackColor = true;
            BotonLogo.Click += BotonLogo_Click;
            // 
            // IconoTitulo
            // 
            IconoTitulo.BackColor = Color.FromArgb(36, 37, 38);
            IconoTitulo.ForeColor = Color.FromArgb(172, 126, 241);
            IconoTitulo.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            IconoTitulo.IconColor = Color.FromArgb(172, 126, 241);
            IconoTitulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconoTitulo.IconSize = 56;
            IconoTitulo.Location = new Point(24, 22);
            IconoTitulo.Name = "IconoTitulo";
            IconoTitulo.Size = new Size(61, 56);
            IconoTitulo.TabIndex = 2;
            IconoTitulo.TabStop = false;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = SystemColors.ControlLightLight;
            Titulo.Location = new Point(91, 32);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(103, 32);
            Titulo.TabIndex = 4;
            Titulo.Text = "Home";
            // 
            // PanelSuperior
            // 
            PanelSuperior.BackColor = Color.FromArgb(36, 37, 38);
            PanelSuperior.Controls.Add(IconoTitulo);
            PanelSuperior.Controls.Add(Titulo);
            PanelSuperior.Dock = DockStyle.Top;
            PanelSuperior.Location = new Point(220, 0);
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Size = new Size(1012, 100);
            PanelSuperior.TabIndex = 15;
            PanelSuperior.MouseDown += PanelSuperior_MouseDown;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(24, 25, 26);
            MainPanel.Controls.Add(labelFecha);
            MainPanel.Controls.Add(labelHora);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(220, 100);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1012, 494);
            MainPanel.TabIndex = 16;
            MainPanel.Paint += MainPanel_Paint;
            // 
            // labelFecha
            // 
            labelFecha.Anchor = AnchorStyles.None;
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFecha.ForeColor = SystemColors.ButtonShadow;
            labelFecha.Location = new Point(449, 175);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(85, 37);
            labelFecha.TabIndex = 1;
            labelFecha.Text = "Fecha";
            // 
            // labelHora
            // 
            labelHora.Anchor = AnchorStyles.None;
            labelHora.AutoSize = true;
            labelHora.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHora.ForeColor = SystemColors.AppWorkspace;
            labelHora.Location = new Point(423, 84);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(146, 72);
            labelHora.TabIndex = 0;
            labelHora.Text = "Hora";
            labelHora.Click += labelHora_Click;
            // 
            // HoraFecha
            // 
            HoraFecha.Enabled = true;
            HoraFecha.Tick += HoraFecha_Tick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 594);
            Controls.Add(MainPanel);
            Controls.Add(PanelSuperior);
            Controls.Add(PanelMenuLateral);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Home";
            Load += Form1_Load;
            Click += Form1_Click;
            PanelMenuLateral.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IconoTitulo).EndInit();
            PanelSuperior.ResumeLayout(false);
            PanelSuperior.PerformLayout();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Panel PanelMenuLateral;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton BotonContactos;
        private FontAwesome.Sharp.IconButton BotonBaseDeDatos;
        private FontAwesome.Sharp.IconButton BotonCerrarSesion;
        private FontAwesome.Sharp.IconButton BotonLogo;
        private FontAwesome.Sharp.IconPictureBox IconoTitulo;
        private Label Titulo;
        private Panel PanelSuperior;
        private Panel MainPanel;
        private Label labelFecha;
        private Label labelHora;
        private System.Windows.Forms.Timer HoraFecha;
        private FontAwesome.Sharp.IconButton AsistenciaMedica;
        private FontAwesome.Sharp.IconButton BotonFarmacia;
    }
}
