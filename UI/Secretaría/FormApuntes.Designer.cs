﻿
namespace UI
{
    partial class FormApuntes
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
            System.Windows.Forms.TabPage tabNuevoApunte;
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.labelNota = new System.Windows.Forms.Label();
            this.textNota = new System.Windows.Forms.TextBox();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtras = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabApuntes = new System.Windows.Forms.TabControl();
            this.tabLibro = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnGestionarContactos = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridApunte = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelContenedorDeDirectorio = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.btSearchLibreta = new FontAwesome.Sharp.IconPictureBox();
            this.textSerachLibreta = new System.Windows.Forms.TextBox();
            this.btnCloseSearchLibreta = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            tabNuevoApunte = new System.Windows.Forms.TabPage();
            tabNuevoApunte.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabApuntes.SuspendLayout();
            this.tabLibro.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApunte)).BeginInit();
            this.panelContenedorDeDirectorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSearchLibreta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSearchLibreta)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNuevoApunte
            // 
            tabNuevoApunte.Controls.Add(this.panel4);
            tabNuevoApunte.Location = new System.Drawing.Point(4, 24);
            tabNuevoApunte.Name = "tabNuevoApunte";
            tabNuevoApunte.Size = new System.Drawing.Size(792, 448);
            tabNuevoApunte.TabIndex = 1;
            tabNuevoApunte.Text = "Nuevo apunte";
            tabNuevoApunte.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Controls.Add(this.labelNota);
            this.panel4.Controls.Add(this.textNota);
            this.panel4.Controls.Add(this.textTitulo);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(40, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(714, 392);
            this.panel4.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnModificar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRegistrar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 352);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(714, 40);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkRed;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.btnModificar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 30;
            this.btnModificar.Location = new System.Drawing.Point(360, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 34);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.BackColor = System.Drawing.Color.Green;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnRegistrar.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.IconSize = 30;
            this.btnRegistrar.Location = new System.Drawing.Point(254, 3);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 34);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "Guardar";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota.Location = new System.Drawing.Point(15, 79);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(44, 16);
            this.labelNota.TabIndex = 17;
            this.labelNota.Text = "Nota:";
            // 
            // textNota
            // 
            this.textNota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNota.Location = new System.Drawing.Point(18, 98);
            this.textNota.Multiline = true;
            this.textNota.Name = "textNota";
            this.textNota.Size = new System.Drawing.Size(673, 248);
            this.textNota.TabIndex = 16;
            this.textNota.Text = "Redactar";
            this.textNota.Enter += new System.EventHandler(this.textNota_Enter);
            this.textNota.Leave += new System.EventHandler(this.textNota_Leave);
            // 
            // textTitulo
            // 
            this.textTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitulo.Location = new System.Drawing.Point(71, 39);
            this.textTitulo.Multiline = true;
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(610, 26);
            this.textTitulo.TabIndex = 7;
            this.textTitulo.Text = "Titulo";
            this.textTitulo.Enter += new System.EventHandler(this.textTitulo_Enter);
            this.textTitulo.Leave += new System.EventHandler(this.textTitulo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Titulo:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.iconPictureBox4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(714, 32);
            this.panel5.TabIndex = 1;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 28;
            this.iconPictureBox4.Location = new System.Drawing.Point(5, 3);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(28, 28);
            this.iconPictureBox4.TabIndex = 9;
            this.iconPictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(36, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Agregar nuevo apunte";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 59);
            this.panel1.TabIndex = 2;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.btnAtras.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtras.IconSize = 28;
            this.btnAtras.Location = new System.Drawing.Point(12, 18);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(28, 28);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(92, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libro De Apuntes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Apuntes1;
            this.pictureBox1.Location = new System.Drawing.Point(46, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tabApuntes
            // 
            this.tabApuntes.Controls.Add(this.tabLibro);
            this.tabApuntes.Controls.Add(tabNuevoApunte);
            this.tabApuntes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabApuntes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabApuntes.Location = new System.Drawing.Point(0, 59);
            this.tabApuntes.Name = "tabApuntes";
            this.tabApuntes.SelectedIndex = 0;
            this.tabApuntes.Size = new System.Drawing.Size(800, 476);
            this.tabApuntes.TabIndex = 3;
            // 
            // tabLibro
            // 
            this.tabLibro.Controls.Add(this.panel7);
            this.tabLibro.Controls.Add(this.panel3);
            this.tabLibro.Location = new System.Drawing.Point(4, 25);
            this.tabLibro.Name = "tabLibro";
            this.tabLibro.Padding = new System.Windows.Forms.Padding(3);
            this.tabLibro.Size = new System.Drawing.Size(792, 447);
            this.tabLibro.TabIndex = 0;
            this.tabLibro.Text = "Libro";
            this.tabLibro.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnGestionarContactos);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(3, 401);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(786, 43);
            this.panel7.TabIndex = 4;
            // 
            // btnGestionarContactos
            // 
            this.btnGestionarContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestionarContactos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnGestionarContactos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarContactos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionarContactos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGestionarContactos.IconColor = System.Drawing.Color.Black;
            this.btnGestionarContactos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionarContactos.Location = new System.Drawing.Point(332, 4);
            this.btnGestionarContactos.Name = "btnGestionarContactos";
            this.btnGestionarContactos.Size = new System.Drawing.Size(135, 35);
            this.btnGestionarContactos.TabIndex = 1;
            this.btnGestionarContactos.Text = "Gestionar apuntes";
            this.btnGestionarContactos.UseVisualStyleBackColor = false;
            this.btnGestionarContactos.Click += new System.EventHandler(this.btnGestionarContactos_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dataGridApunte);
            this.panel3.Controls.Add(this.panelContenedorDeDirectorio);
            this.panel3.Location = new System.Drawing.Point(42, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(714, 389);
            this.panel3.TabIndex = 0;
            // 
            // dataGridApunte
            // 
            this.dataGridApunte.AllowUserToAddRows = false;
            this.dataGridApunte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridApunte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.Editar,
            this.Borrar});
            this.dataGridApunte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridApunte.Location = new System.Drawing.Point(0, 32);
            this.dataGridApunte.Name = "dataGridApunte";
            this.dataGridApunte.ReadOnly = true;
            this.dataGridApunte.RowHeadersVisible = false;
            this.dataGridApunte.Size = new System.Drawing.Size(714, 357);
            this.dataGridApunte.TabIndex = 1;
            this.dataGridApunte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridApunte_CellClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 70;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::UI.Properties.Resources.edit_user;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 50;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Image = global::UI.Properties.Resources.borrar;
            this.Borrar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Width = 60;
            // 
            // panelContenedorDeDirectorio
            // 
            this.panelContenedorDeDirectorio.BackColor = System.Drawing.Color.Black;
            this.panelContenedorDeDirectorio.Controls.Add(this.label27);
            this.panelContenedorDeDirectorio.Controls.Add(this.textTotal);
            this.panelContenedorDeDirectorio.Controls.Add(this.iconPictureBox3);
            this.panelContenedorDeDirectorio.Controls.Add(this.btSearchLibreta);
            this.panelContenedorDeDirectorio.Controls.Add(this.textSerachLibreta);
            this.panelContenedorDeDirectorio.Controls.Add(this.btnCloseSearchLibreta);
            this.panelContenedorDeDirectorio.Controls.Add(this.label1);
            this.panelContenedorDeDirectorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContenedorDeDirectorio.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorDeDirectorio.Name = "panelContenedorDeDirectorio";
            this.panelContenedorDeDirectorio.Size = new System.Drawing.Size(714, 32);
            this.panelContenedorDeDirectorio.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label27.Location = new System.Drawing.Point(403, 8);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 16);
            this.label27.TabIndex = 33;
            this.label27.Text = "Total";
            // 
            // textTotal
            // 
            this.textTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotal.Location = new System.Drawing.Point(449, 5);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(46, 22);
            this.textTotal.TabIndex = 32;
            this.textTotal.Text = "0";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 28;
            this.iconPictureBox3.Location = new System.Drawing.Point(5, 3);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(28, 28);
            this.iconPictureBox3.TabIndex = 9;
            this.iconPictureBox3.TabStop = false;
            // 
            // btSearchLibreta
            // 
            this.btSearchLibreta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearchLibreta.BackColor = System.Drawing.Color.Transparent;
            this.btSearchLibreta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSearchLibreta.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btSearchLibreta.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSearchLibreta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btSearchLibreta.IconSize = 28;
            this.btSearchLibreta.Location = new System.Drawing.Point(683, 3);
            this.btSearchLibreta.Name = "btSearchLibreta";
            this.btSearchLibreta.Size = new System.Drawing.Size(28, 28);
            this.btSearchLibreta.TabIndex = 7;
            this.btSearchLibreta.TabStop = false;
            this.btSearchLibreta.Click += new System.EventHandler(this.btSearchLibreta_Click);
            // 
            // textSerachLibreta
            // 
            this.textSerachLibreta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSerachLibreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSerachLibreta.Location = new System.Drawing.Point(501, 1);
            this.textSerachLibreta.Multiline = true;
            this.textSerachLibreta.Name = "textSerachLibreta";
            this.textSerachLibreta.Size = new System.Drawing.Size(180, 30);
            this.textSerachLibreta.TabIndex = 6;
            this.textSerachLibreta.Text = "Buscar por titulo";
            this.textSerachLibreta.Visible = false;
            this.textSerachLibreta.TextChanged += new System.EventHandler(this.textSerachLibreta_TextChanged);
            this.textSerachLibreta.Enter += new System.EventHandler(this.textSerachLibreta_Enter);
            this.textSerachLibreta.Leave += new System.EventHandler(this.textSerachLibreta_Leave);
            // 
            // btnCloseSearchLibreta
            // 
            this.btnCloseSearchLibreta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseSearchLibreta.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseSearchLibreta.ForeColor = System.Drawing.Color.Red;
            this.btnCloseSearchLibreta.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCloseSearchLibreta.IconColor = System.Drawing.Color.Red;
            this.btnCloseSearchLibreta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseSearchLibreta.IconSize = 28;
            this.btnCloseSearchLibreta.Location = new System.Drawing.Point(683, 2);
            this.btnCloseSearchLibreta.Name = "btnCloseSearchLibreta";
            this.btnCloseSearchLibreta.Size = new System.Drawing.Size(28, 28);
            this.btnCloseSearchLibreta.TabIndex = 5;
            this.btnCloseSearchLibreta.TabStop = false;
            this.btnCloseSearchLibreta.Visible = false;
            this.btnCloseSearchLibreta.Click += new System.EventHandler(this.btnCloseSearchLibreta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(36, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libro de apuntes";
            // 
            // FormApuntes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.tabApuntes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormApuntes";
            this.Text = "FormApuntes";
            tabNuevoApunte.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabApuntes.ResumeLayout(false);
            this.tabLibro.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApunte)).EndInit();
            this.panelContenedorDeDirectorio.ResumeLayout(false);
            this.panelContenedorDeDirectorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSearchLibreta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSearchLibreta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox btnAtras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabApuntes;
        private System.Windows.Forms.TabPage tabLibro;
        private FontAwesome.Sharp.IconButton btnGestionarContactos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridApunte;
        private System.Windows.Forms.Panel panelContenedorDeDirectorio;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox btSearchLibreta;
        private System.Windows.Forms.TextBox textSerachLibreta;
        private FontAwesome.Sharp.IconPictureBox btnCloseSearchLibreta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNota;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
    }
}