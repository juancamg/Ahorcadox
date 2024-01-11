
namespace Ahorcadox
{
    partial class Administracion
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
            this.label_tittle_administracion = new System.Windows.Forms.Label();
            this.button_gest_usuarios = new System.Windows.Forms.Button();
            this.button_gest_palabras = new System.Windows.Forms.Button();
            this.panel_administrador = new System.Windows.Forms.Panel();
            this.panel_agregar2 = new System.Windows.Forms.Panel();
            this.checkBox1_nuevaCategoria = new System.Windows.Forms.CheckBox();
            this.label_agregar2_aviso = new System.Windows.Forms.Label();
            this.button_agregar2_cancelar = new System.Windows.Forms.Button();
            this.button_agregar2_aceptar = new System.Windows.Forms.Button();
            this.comboBox_agregar2_categorias = new System.Windows.Forms.ComboBox();
            this.label_selectCategoria = new System.Windows.Forms.Label();
            this.label_palabra = new System.Windows.Forms.Label();
            this.textBox_agregar2_palabra = new System.Windows.Forms.TextBox();
            this.panel_agregar1 = new System.Windows.Forms.Panel();
            this.label_agregar1_aviso = new System.Windows.Forms.Label();
            this.button_agregar1_cancelar = new System.Windows.Forms.Button();
            this.button_agregar1_aceptar = new System.Windows.Forms.Button();
            this.comboBox_agregar1_rol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_contrasenia = new System.Windows.Forms.Label();
            this.textBox_agregar1_contrasenia = new System.Windows.Forms.TextBox();
            this.label_usuario = new System.Windows.Forms.Label();
            this.textBox_agregar1_usuario = new System.Windows.Forms.TextBox();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_buscador = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_salir = new System.Windows.Forms.Button();
            this.panel_administrador.SuspendLayout();
            this.panel_agregar2.SuspendLayout();
            this.panel_agregar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_tittle_administracion
            // 
            this.label_tittle_administracion.AutoSize = true;
            this.label_tittle_administracion.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tittle_administracion.Location = new System.Drawing.Point(29, 28);
            this.label_tittle_administracion.Name = "label_tittle_administracion";
            this.label_tittle_administracion.Size = new System.Drawing.Size(409, 61);
            this.label_tittle_administracion.TabIndex = 0;
            this.label_tittle_administracion.Text = "ADMINISTRACIÓN";
            // 
            // button_gest_usuarios
            // 
            this.button_gest_usuarios.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gest_usuarios.Location = new System.Drawing.Point(40, 92);
            this.button_gest_usuarios.Name = "button_gest_usuarios";
            this.button_gest_usuarios.Size = new System.Drawing.Size(184, 46);
            this.button_gest_usuarios.TabIndex = 1;
            this.button_gest_usuarios.Text = "Gestionar usuarios";
            this.button_gest_usuarios.UseVisualStyleBackColor = true;
            this.button_gest_usuarios.Click += new System.EventHandler(this.button_gest_usuarios_Click);
            // 
            // button_gest_palabras
            // 
            this.button_gest_palabras.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gest_palabras.Location = new System.Drawing.Point(40, 158);
            this.button_gest_palabras.Name = "button_gest_palabras";
            this.button_gest_palabras.Size = new System.Drawing.Size(184, 46);
            this.button_gest_palabras.TabIndex = 2;
            this.button_gest_palabras.Text = "Gestionar palabras";
            this.button_gest_palabras.UseVisualStyleBackColor = true;
            this.button_gest_palabras.Click += new System.EventHandler(this.button_gest_palabras_Click);
            // 
            // panel_administrador
            // 
            this.panel_administrador.Controls.Add(this.panel_agregar2);
            this.panel_administrador.Controls.Add(this.panel_agregar1);
            this.panel_administrador.Controls.Add(this.button_eliminar);
            this.panel_administrador.Controls.Add(this.button_modificar);
            this.panel_administrador.Controls.Add(this.button_agregar);
            this.panel_administrador.Controls.Add(this.label1);
            this.panel_administrador.Controls.Add(this.textBox_buscador);
            this.panel_administrador.Controls.Add(this.dataGridView1);
            this.panel_administrador.Location = new System.Drawing.Point(230, 92);
            this.panel_administrador.Name = "panel_administrador";
            this.panel_administrador.Size = new System.Drawing.Size(515, 536);
            this.panel_administrador.TabIndex = 3;
            this.panel_administrador.Visible = false;
            // 
            // panel_agregar2
            // 
            this.panel_agregar2.Controls.Add(this.checkBox1_nuevaCategoria);
            this.panel_agregar2.Controls.Add(this.label_agregar2_aviso);
            this.panel_agregar2.Controls.Add(this.button_agregar2_cancelar);
            this.panel_agregar2.Controls.Add(this.button_agregar2_aceptar);
            this.panel_agregar2.Controls.Add(this.comboBox_agregar2_categorias);
            this.panel_agregar2.Controls.Add(this.label_selectCategoria);
            this.panel_agregar2.Controls.Add(this.label_palabra);
            this.panel_agregar2.Controls.Add(this.textBox_agregar2_palabra);
            this.panel_agregar2.Location = new System.Drawing.Point(3, 406);
            this.panel_agregar2.Name = "panel_agregar2";
            this.panel_agregar2.Size = new System.Drawing.Size(484, 106);
            this.panel_agregar2.TabIndex = 13;
            // 
            // checkBox1_nuevaCategoria
            // 
            this.checkBox1_nuevaCategoria.AutoSize = true;
            this.checkBox1_nuevaCategoria.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1_nuevaCategoria.Location = new System.Drawing.Point(331, 45);
            this.checkBox1_nuevaCategoria.Name = "checkBox1_nuevaCategoria";
            this.checkBox1_nuevaCategoria.Size = new System.Drawing.Size(117, 21);
            this.checkBox1_nuevaCategoria.TabIndex = 18;
            this.checkBox1_nuevaCategoria.Text = "Nueva categoría";
            this.checkBox1_nuevaCategoria.UseVisualStyleBackColor = true;
            this.checkBox1_nuevaCategoria.CheckedChanged += new System.EventHandler(this.checkBox_nuevaCategoria_CheckedChanged_1);
            // 
            // label_agregar2_aviso
            // 
            this.label_agregar2_aviso.AutoSize = true;
            this.label_agregar2_aviso.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_agregar2_aviso.ForeColor = System.Drawing.Color.Red;
            this.label_agregar2_aviso.Location = new System.Drawing.Point(250, 60);
            this.label_agregar2_aviso.Name = "label_agregar2_aviso";
            this.label_agregar2_aviso.Size = new System.Drawing.Size(11, 17);
            this.label_agregar2_aviso.TabIndex = 14;
            this.label_agregar2_aviso.Text = " ";
            // 
            // button_agregar2_cancelar
            // 
            this.button_agregar2_cancelar.BackColor = System.Drawing.Color.LightPink;
            this.button_agregar2_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_agregar2_cancelar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar2_cancelar.Location = new System.Drawing.Point(128, 51);
            this.button_agregar2_cancelar.Name = "button_agregar2_cancelar";
            this.button_agregar2_cancelar.Size = new System.Drawing.Size(103, 29);
            this.button_agregar2_cancelar.TabIndex = 17;
            this.button_agregar2_cancelar.Text = "CANCELAR";
            this.button_agregar2_cancelar.UseVisualStyleBackColor = false;
            this.button_agregar2_cancelar.Click += new System.EventHandler(this.button_agregar2_cancelar_Click);
            // 
            // button_agregar2_aceptar
            // 
            this.button_agregar2_aceptar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_agregar2_aceptar.Enabled = false;
            this.button_agregar2_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_agregar2_aceptar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar2_aceptar.Location = new System.Drawing.Point(19, 51);
            this.button_agregar2_aceptar.Name = "button_agregar2_aceptar";
            this.button_agregar2_aceptar.Size = new System.Drawing.Size(103, 29);
            this.button_agregar2_aceptar.TabIndex = 13;
            this.button_agregar2_aceptar.Text = "ACEPTAR";
            this.button_agregar2_aceptar.UseVisualStyleBackColor = false;
            this.button_agregar2_aceptar.Click += new System.EventHandler(this.button_agregar2_aceptar_Click);
            // 
            // comboBox_agregar2_categorias
            // 
            this.comboBox_agregar2_categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_agregar2_categorias.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_agregar2_categorias.FormattingEnabled = true;
            this.comboBox_agregar2_categorias.Location = new System.Drawing.Point(330, 10);
            this.comboBox_agregar2_categorias.Name = "comboBox_agregar2_categorias";
            this.comboBox_agregar2_categorias.Size = new System.Drawing.Size(128, 29);
            this.comboBox_agregar2_categorias.TabIndex = 16;
            this.comboBox_agregar2_categorias.SelectedIndexChanged += new System.EventHandler(this.comboBox_agregar2_categorias_SelectedIndexChanged);
            // 
            // label_selectCategoria
            // 
            this.label_selectCategoria.AutoSize = true;
            this.label_selectCategoria.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selectCategoria.Location = new System.Drawing.Point(249, 16);
            this.label_selectCategoria.Name = "label_selectCategoria";
            this.label_selectCategoria.Size = new System.Drawing.Size(75, 21);
            this.label_selectCategoria.TabIndex = 15;
            this.label_selectCategoria.Text = "Categoría";
            // 
            // label_palabra
            // 
            this.label_palabra.AutoSize = true;
            this.label_palabra.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_palabra.Location = new System.Drawing.Point(19, 16);
            this.label_palabra.Name = "label_palabra";
            this.label_palabra.Size = new System.Drawing.Size(65, 21);
            this.label_palabra.TabIndex = 12;
            this.label_palabra.Text = "Palabra";
            // 
            // textBox_agregar2_palabra
            // 
            this.textBox_agregar2_palabra.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_agregar2_palabra.Location = new System.Drawing.Point(101, 13);
            this.textBox_agregar2_palabra.MaxLength = 25;
            this.textBox_agregar2_palabra.Name = "textBox_agregar2_palabra";
            this.textBox_agregar2_palabra.Size = new System.Drawing.Size(128, 26);
            this.textBox_agregar2_palabra.TabIndex = 11;
            this.textBox_agregar2_palabra.TextChanged += new System.EventHandler(this.textBox_agregar2_palabra_TextChanged);
            // 
            // panel_agregar1
            // 
            this.panel_agregar1.Controls.Add(this.label_agregar1_aviso);
            this.panel_agregar1.Controls.Add(this.button_agregar1_cancelar);
            this.panel_agregar1.Controls.Add(this.button_agregar1_aceptar);
            this.panel_agregar1.Controls.Add(this.comboBox_agregar1_rol);
            this.panel_agregar1.Controls.Add(this.label3);
            this.panel_agregar1.Controls.Add(this.label_contrasenia);
            this.panel_agregar1.Controls.Add(this.textBox_agregar1_contrasenia);
            this.panel_agregar1.Controls.Add(this.label_usuario);
            this.panel_agregar1.Controls.Add(this.textBox_agregar1_usuario);
            this.panel_agregar1.Location = new System.Drawing.Point(3, 408);
            this.panel_agregar1.Name = "panel_agregar1";
            this.panel_agregar1.Size = new System.Drawing.Size(484, 118);
            this.panel_agregar1.TabIndex = 12;
            this.panel_agregar1.Visible = false;
            // 
            // label_agregar1_aviso
            // 
            this.label_agregar1_aviso.AutoSize = true;
            this.label_agregar1_aviso.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_agregar1_aviso.ForeColor = System.Drawing.Color.Red;
            this.label_agregar1_aviso.Location = new System.Drawing.Point(30, 90);
            this.label_agregar1_aviso.Name = "label_agregar1_aviso";
            this.label_agregar1_aviso.Size = new System.Drawing.Size(11, 17);
            this.label_agregar1_aviso.TabIndex = 13;
            this.label_agregar1_aviso.Text = " ";
            // 
            // button_agregar1_cancelar
            // 
            this.button_agregar1_cancelar.BackColor = System.Drawing.Color.LightPink;
            this.button_agregar1_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_agregar1_cancelar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar1_cancelar.Location = new System.Drawing.Point(355, 51);
            this.button_agregar1_cancelar.Name = "button_agregar1_cancelar";
            this.button_agregar1_cancelar.Size = new System.Drawing.Size(103, 29);
            this.button_agregar1_cancelar.TabIndex = 17;
            this.button_agregar1_cancelar.Text = "CANCELAR";
            this.button_agregar1_cancelar.UseVisualStyleBackColor = false;
            this.button_agregar1_cancelar.Click += new System.EventHandler(this.button_agregar1_cancelar_Click);
            // 
            // button_agregar1_aceptar
            // 
            this.button_agregar1_aceptar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_agregar1_aceptar.Enabled = false;
            this.button_agregar1_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_agregar1_aceptar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar1_aceptar.Location = new System.Drawing.Point(240, 52);
            this.button_agregar1_aceptar.Name = "button_agregar1_aceptar";
            this.button_agregar1_aceptar.Size = new System.Drawing.Size(103, 29);
            this.button_agregar1_aceptar.TabIndex = 13;
            this.button_agregar1_aceptar.Text = "ACEPTAR";
            this.button_agregar1_aceptar.UseVisualStyleBackColor = false;
            this.button_agregar1_aceptar.Click += new System.EventHandler(this.button_agregar1_aceptar_Click);
            // 
            // comboBox_agregar1_rol
            // 
            this.comboBox_agregar1_rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_agregar1_rol.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_agregar1_rol.FormattingEnabled = true;
            this.comboBox_agregar1_rol.Location = new System.Drawing.Point(87, 52);
            this.comboBox_agregar1_rol.Name = "comboBox_agregar1_rol";
            this.comboBox_agregar1_rol.Size = new System.Drawing.Size(128, 29);
            this.comboBox_agregar1_rol.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Rol";
            // 
            // label_contrasenia
            // 
            this.label_contrasenia.AutoSize = true;
            this.label_contrasenia.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contrasenia.Location = new System.Drawing.Point(236, 15);
            this.label_contrasenia.Name = "label_contrasenia";
            this.label_contrasenia.Size = new System.Drawing.Size(88, 21);
            this.label_contrasenia.TabIndex = 14;
            this.label_contrasenia.Text = "Contraseña";
            // 
            // textBox_agregar1_contrasenia
            // 
            this.textBox_agregar1_contrasenia.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_agregar1_contrasenia.Location = new System.Drawing.Point(330, 12);
            this.textBox_agregar1_contrasenia.MaxLength = 25;
            this.textBox_agregar1_contrasenia.Name = "textBox_agregar1_contrasenia";
            this.textBox_agregar1_contrasenia.Size = new System.Drawing.Size(128, 26);
            this.textBox_agregar1_contrasenia.TabIndex = 13;
            this.textBox_agregar1_contrasenia.TextChanged += new System.EventHandler(this.textBox_agregar1_contrasenia_TextChanged);
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.Location = new System.Drawing.Point(19, 16);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(62, 21);
            this.label_usuario.TabIndex = 12;
            this.label_usuario.Text = "Usuario";
            // 
            // textBox_agregar1_usuario
            // 
            this.textBox_agregar1_usuario.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_agregar1_usuario.Location = new System.Drawing.Point(87, 13);
            this.textBox_agregar1_usuario.MaxLength = 25;
            this.textBox_agregar1_usuario.Name = "textBox_agregar1_usuario";
            this.textBox_agregar1_usuario.Size = new System.Drawing.Size(128, 26);
            this.textBox_agregar1_usuario.TabIndex = 11;
            this.textBox_agregar1_usuario.TextChanged += new System.EventHandler(this.textBox_agregar1_usuario_TextChanged);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.Color.LightPink;
            this.button_eliminar.Enabled = false;
            this.button_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eliminar.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.Location = new System.Drawing.Point(352, 353);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(118, 40);
            this.button_eliminar.TabIndex = 9;
            this.button_eliminar.Text = "ELIMINAR";
            this.button_eliminar.UseVisualStyleBackColor = false;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_modificar
            // 
            this.button_modificar.BackColor = System.Drawing.Color.Khaki;
            this.button_modificar.Enabled = false;
            this.button_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modificar.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificar.Location = new System.Drawing.Point(188, 353);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(118, 40);
            this.button_modificar.TabIndex = 8;
            this.button_modificar.Text = "MODIFICAR";
            this.button_modificar.UseVisualStyleBackColor = false;
            this.button_modificar.Click += new System.EventHandler(this.button_modificar_Click);
            // 
            // button_agregar
            // 
            this.button_agregar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_agregar.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar.Location = new System.Drawing.Point(23, 353);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(118, 40);
            this.button_agregar.TabIndex = 7;
            this.button_agregar.Text = "AGREGAR";
            this.button_agregar.UseVisualStyleBackColor = false;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // textBox_buscador
            // 
            this.textBox_buscador.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_buscador.Location = new System.Drawing.Point(263, 15);
            this.textBox_buscador.MaxLength = 50;
            this.textBox_buscador.Name = "textBox_buscador";
            this.textBox_buscador.Size = new System.Drawing.Size(207, 31);
            this.textBox_buscador.TabIndex = 5;
            this.textBox_buscador.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(447, 272);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // button_salir
            // 
            this.button_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salir.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salir.Location = new System.Drawing.Point(40, 220);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(184, 46);
            this.button_salir.TabIndex = 4;
            this.button_salir.Text = "VOLVER";
            this.button_salir.UseVisualStyleBackColor = false;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 637);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.panel_administrador);
            this.Controls.Add(this.button_gest_palabras);
            this.Controls.Add(this.button_gest_usuarios);
            this.Controls.Add(this.label_tittle_administracion);
            this.Name = "Administracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración";
            this.panel_administrador.ResumeLayout(false);
            this.panel_administrador.PerformLayout();
            this.panel_agregar2.ResumeLayout(false);
            this.panel_agregar2.PerformLayout();
            this.panel_agregar1.ResumeLayout(false);
            this.panel_agregar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tittle_administracion;
        private System.Windows.Forms.Button button_gest_usuarios;
        private System.Windows.Forms.Button button_gest_palabras;
        private System.Windows.Forms.Panel panel_administrador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_buscador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.TextBox textBox_agregar1_usuario;
        private System.Windows.Forms.Panel panel_agregar1;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.ComboBox comboBox_agregar1_rol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_contrasenia;
        private System.Windows.Forms.TextBox textBox_agregar1_contrasenia;
        private System.Windows.Forms.Button button_agregar1_cancelar;
        private System.Windows.Forms.Button button_agregar1_aceptar;
        private System.Windows.Forms.Label label_agregar1_aviso;
        private System.Windows.Forms.Button button_agregar2_cancelar;
        private System.Windows.Forms.Button button_agregar2_aceptar;
        private System.Windows.Forms.ComboBox comboBox_agregar2_categorias;
        private System.Windows.Forms.Label label_selectCategoria;
        private System.Windows.Forms.Label label_palabra;
        private System.Windows.Forms.TextBox textBox_agregar2_palabra;
        private System.Windows.Forms.Label label_agregar2_aviso;
        private System.Windows.Forms.CheckBox checkBox_nuevaCategoria;
        private System.Windows.Forms.Panel panel_agregar2;
        private System.Windows.Forms.CheckBox checkBox1_nuevaCategoria;
    }
}