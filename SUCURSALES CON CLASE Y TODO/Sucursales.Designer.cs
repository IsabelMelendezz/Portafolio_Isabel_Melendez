namespace SistemaReparto
{
    partial class Sucursales
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
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pic_Sucur = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            comboBoxZona = new ComboBox();
            comboBoxMunicipio = new ComboBox();
            comboBoxDepartamento = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            label3 = new Label();
            labelIdSucursal = new Label();
            textBoxIdSucursal = new TextBox();
            labelNombre = new Label();
            textBoxNombre = new TextBox();
            labelDireccion = new Label();
            textBoxDireccion = new TextBox();
            labelTelefono = new Label();
            textBoxTelefono = new TextBox();
            labelCorreo = new Label();
            textBoxCorreo = new TextBox();
            panel4 = new Panel();
            label4 = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            panel5 = new Panel();
            label5 = new Label();
            labelBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dataGridView1 = new DataGridView();
            labelRegistros = new Label();
            btnAnterior = new Button();
            btnPag1 = new Button();
            btnSiguiente = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Sucur).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Indigo;
            panel1.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pic_Sucur);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1230, 176);
            panel1.TabIndex = 2;
            // 
            // pic_Sucur
            // 
            pic_Sucur.BackColor = Color.Transparent;
            pic_Sucur.Image = Properties.Resources.Sucu_ico;
            pic_Sucur.Location = new Point(38, 21);
            pic_Sucur.Margin = new Padding(2);
            pic_Sucur.Name = "pic_Sucur";
            pic_Sucur.Size = new Size(133, 123);
            pic_Sucur.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Sucur.TabIndex = 20;
            pic_Sucur.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(176, 55);
            label2.Name = "label2";
            label2.Size = new Size(203, 52);
            label2.TabIndex = 6;
            label2.Text = "Sucursales";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseCompatibleTextRendering = true;
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(906, 14);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.MaximumSize = new Size(1500, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 139);
            panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.patito1;
            pictureBox1.Location = new Point(66, -4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(comboBoxZona);
            panel3.Controls.Add(comboBoxMunicipio);
            panel3.Controls.Add(comboBoxDepartamento);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(labelIdSucursal);
            panel3.Controls.Add(textBoxIdSucursal);
            panel3.Controls.Add(labelNombre);
            panel3.Controls.Add(textBoxNombre);
            panel3.Controls.Add(labelDireccion);
            panel3.Controls.Add(textBoxDireccion);
            panel3.Controls.Add(labelTelefono);
            panel3.Controls.Add(textBoxTelefono);
            panel3.Controls.Add(labelCorreo);
            panel3.Controls.Add(textBoxCorreo);
            panel3.Location = new Point(22, 200);
            panel3.Name = "panel3";
            panel3.Size = new Size(871, 284);
            panel3.TabIndex = 5;
            // 
            // comboBoxZona
            // 
            comboBoxZona.FormattingEnabled = true;
            comboBoxZona.Location = new Point(707, 164);
            comboBoxZona.Name = "comboBoxZona";
            comboBoxZona.Size = new Size(137, 28);
            comboBoxZona.TabIndex = 18;
            // 
            // comboBoxMunicipio
            // 
            comboBoxMunicipio.FormattingEnabled = true;
            comboBoxMunicipio.Location = new Point(511, 163);
            comboBoxMunicipio.Name = "comboBoxMunicipio";
            comboBoxMunicipio.Size = new Size(167, 28);
            comboBoxMunicipio.TabIndex = 17;
            // 
            // comboBoxDepartamento
            // 
            comboBoxDepartamento.FormattingEnabled = true;
            comboBoxDepartamento.Location = new Point(302, 163);
            comboBoxDepartamento.Name = "comboBoxDepartamento";
            comboBoxDepartamento.Size = new Size(178, 28);
            comboBoxDepartamento.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(707, 137);
            label7.Name = "label7";
            label7.Size = new Size(62, 19);
            label7.TabIndex = 15;
            label7.Text = "Zona *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(511, 137);
            label6.Name = "label6";
            label6.Size = new Size(96, 19);
            label6.TabIndex = 13;
            label6.Text = "Municipio*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(302, 137);
            label1.Name = "label1";
            label1.Size = new Size(138, 19);
            label1.TabIndex = 11;
            label1.Text = "Departamento *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(15, 10);
            label3.Name = "label3";
            label3.Size = new Size(361, 32);
            label3.TabIndex = 0;
            label3.Text = "🏢 Información de la Sucursal";
            // 
            // labelIdSucursal
            // 
            labelIdSucursal.AutoSize = true;
            labelIdSucursal.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIdSucursal.ForeColor = Color.FromArgb(64, 64, 64);
            labelIdSucursal.Location = new Point(24, 57);
            labelIdSucursal.Name = "labelIdSucursal";
            labelIdSucursal.Size = new Size(99, 19);
            labelIdSucursal.TabIndex = 1;
            labelIdSucursal.Text = "ID Sucursal";
            // 
            // textBoxIdSucursal
            // 
            textBoxIdSucursal.BackColor = Color.FromArgb(237, 237, 237);
            textBoxIdSucursal.Location = new Point(22, 86);
            textBoxIdSucursal.Name = "textBoxIdSucursal";
            textBoxIdSucursal.PlaceholderText = "🔒 Autogenerado";
            textBoxIdSucursal.ReadOnly = true;
            textBoxIdSucursal.Size = new Size(190, 27);
            textBoxIdSucursal.TabIndex = 2;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.ForeColor = Color.FromArgb(64, 64, 64);
            labelNombre.Location = new Point(259, 57);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(208, 19);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Nombre de la Sucursal *";
            labelNombre.Click += labelNombre_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(259, 86);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Ingrese el nombre de la sucursal";
            textBoxNombre.Size = new Size(278, 27);
            textBoxNombre.TabIndex = 4;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDireccion.ForeColor = Color.FromArgb(64, 64, 64);
            labelDireccion.Location = new Point(22, 137);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(100, 19);
            labelDireccion.TabIndex = 5;
            labelDireccion.Text = "Dirección *";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDireccion.Location = new Point(24, 164);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.PlaceholderText = "Ingrese la dirección de la sucursal";
            textBoxDireccion.Size = new Size(232, 27);
            textBoxDireccion.TabIndex = 6;
            textBoxDireccion.TextChanged += textBoxDireccion_TextChanged;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTelefono.ForeColor = Color.FromArgb(64, 64, 64);
            labelTelefono.Location = new Point(559, 57);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(79, 19);
            labelTelefono.TabIndex = 7;
            labelTelefono.Text = "Teléfono";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(559, 86);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.PlaceholderText = "☎  Ingrese el teléfono de la sucursal";
            textBoxTelefono.Size = new Size(285, 27);
            textBoxTelefono.TabIndex = 8;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCorreo.ForeColor = Color.FromArgb(64, 64, 64);
            labelCorreo.Location = new Point(425, 209);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(161, 19);
            labelCorreo.TabIndex = 9;
            labelCorreo.Text = "Correo Electrónico";
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCorreo.Location = new Point(345, 238);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.PlaceholderText = "✉  Ingrese el correo electrónico";
            textBoxCorreo.Size = new Size(373, 27);
            textBoxCorreo.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(btnNuevo);
            panel4.Controls.Add(btnGuardar);
            panel4.Controls.Add(btnEditar);
            panel4.Controls.Add(btnEliminar);
            panel4.Controls.Add(btnLimpiar);
            panel4.Location = new Point(898, 200);
            panel4.Name = "panel4";
            panel4.Size = new Size(322, 284);
            panel4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(94, 0);
            label4.Name = "label4";
            label4.Size = new Size(157, 32);
            label4.TabIndex = 0;
            label4.Text = "⚙️ Acciones";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(21, 66, 143);
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(24, 34);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(283, 42);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "➕  Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(31, 145, 62);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(24, 86);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(283, 42);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "💾  Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(230, 129, 26);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(24, 137);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(283, 42);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "✏️  Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(205, 32, 32);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(24, 186);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(283, 42);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "🗑️  Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.Location = new Point(24, 238);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(283, 30);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "\U0001f9f9  Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(labelBuscar);
            panel5.Controls.Add(txtBuscar);
            panel5.Controls.Add(btnBuscar);
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(labelRegistros);
            panel5.Controls.Add(btnAnterior);
            panel5.Controls.Add(btnPag1);
            panel5.Controls.Add(btnSiguiente);
            panel5.Location = new Point(22, 490);
            panel5.Name = "panel5";
            panel5.Size = new Size(1199, 228);
            panel5.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(20, 4);
            label5.Name = "label5";
            label5.Size = new Size(299, 32);
            label5.TabIndex = 0;
            label5.Text = "📋 Listado de Sucursales";
            // 
            // labelBuscar
            // 
            labelBuscar.AutoSize = true;
            labelBuscar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBuscar.ForeColor = Color.FromArgb(64, 64, 64);
            labelBuscar.Location = new Point(24, 41);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Size = new Size(69, 19);
            labelBuscar.TabIndex = 1;
            labelBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(90, 37);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese nombre, dirección o teléfono...";
            txtBuscar.Size = new Size(420, 27);
            txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(21, 66, 143);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(1022, 26);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(150, 36);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "🔍  Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(13, 33, 82);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(24, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 20;
            dataGridView1.RowTemplate.Height = 34;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1148, 136);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelRegistros
            // 
            labelRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelRegistros.AutoSize = true;
            labelRegistros.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRegistros.ForeColor = Color.FromArgb(90, 90, 90);
            labelRegistros.Location = new Point(20, 636);
            labelRegistros.Name = "labelRegistros";
            labelRegistros.Size = new Size(288, 23);
            labelRegistros.TabIndex = 6;
            labelRegistros.Text = "📊  Mostrando 1 a 5 de 5 sucursales";
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnterior.BackColor = Color.White;
            btnAnterior.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.ForeColor = Color.FromArgb(64, 64, 64);
            btnAnterior.Location = new Point(2197, 628);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(38, 34);
            btnAnterior.TabIndex = 7;
            btnAnterior.Text = "‹";
            btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnPag1
            // 
            btnPag1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPag1.BackColor = Color.FromArgb(21, 66, 143);
            btnPag1.FlatAppearance.BorderSize = 0;
            btnPag1.FlatStyle = FlatStyle.Flat;
            btnPag1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPag1.ForeColor = Color.White;
            btnPag1.Location = new Point(2241, 628);
            btnPag1.Name = "btnPag1";
            btnPag1.Size = new Size(38, 34);
            btnPag1.TabIndex = 8;
            btnPag1.Text = "1";
            btnPag1.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiguiente.BackColor = Color.White;
            btnSiguiente.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.ForeColor = Color.FromArgb(64, 64, 64);
            btnSiguiente.Location = new Point(2285, 628);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(38, 34);
            btnSiguiente.TabIndex = 9;
            btnSiguiente.Text = "›";
            btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // Sucursales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 723);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Sucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Sucursales_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Sucur).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Panel panel3;
        private Label label3;
        private Label labelIdSucursal;
        private TextBox textBoxIdSucursal;
        private Label labelNombre;
        private TextBox textBoxNombre;
        private Label labelDireccion;
        private TextBox textBoxDireccion;
        private Label labelTelefono;
        private TextBox textBoxTelefono;
        private Label labelCorreo;
        private TextBox textBoxCorreo;
        private Panel panel4;
        private Label label4;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Panel panel5;
        private Label label5;
        private Label labelBuscar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView dataGridView1;
        private Label labelRegistros;
        private Button btnAnterior;
        private Button btnPag1;
        private Button btnSiguiente;
        private PictureBox pic_Sucur;
        private PictureBox pictureBox1;
        private ComboBox comboBoxZona;
        private ComboBox comboBoxMunicipio;
        private ComboBox comboBoxDepartamento;
        private Label label7;
        private Label label6;
        private Label label1;
    }
}