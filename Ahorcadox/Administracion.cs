using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcadox
{
    public partial class Administracion : Form
    {
        public MySqlConnection Conexion;
        public MySqlCommand Comando;
        public MySqlDataReader Lector;
        public string cadenaConexion = $"server=127.0.0.1;user id=root;password=admin;database=ahorcadox";
        Login LoginForm = new Login();

        int mode = 0;
        bool edicion;
        int id;
        bool editPalabra;

        public Administracion()
        {
            InitializeComponent();
            Conexion = new MySqlConnection(cadenaConexion);


            button_gest_usuarios.Left = 136;
            button_gest_usuarios.Top = 92;
            button_gest_palabras.Left = 136;
            button_gest_palabras.Top = 158;
            button_salir.Left = 136;
            button_salir.Top = 220;

            this.Height = 349;
            this.Width = 471;
        }

        private void button_gest_usuarios_Click(object sender, EventArgs e)
        {
            mode = 1;
            adaptarVentana();
            mostrarUsuarios();
            cargarComboUsuarios();
        }

        private void button_gest_palabras_Click(object sender, EventArgs e)
        {
            mode = 2;
            adaptarVentana();
            mostrarPalabras();
            cargarComboCategorias();
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Eventos generales
        private void button_agregar_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                panel_agregar1.Visible = true;
                edicion = false;
            }
            else
            {
                limpiarAgregar2();
                panel_agregar2.Visible = true;
                edicion = false;
                checkBox1_nuevaCategoria.Visible = true;
            }
        }

        private void button_modificar_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                mandarDatosUsuario();
            }
            else
            {
                mandarDatosPalabras();
            }
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                eliminarUsuario();
            }
            else
            {
                eliminarPalabra();

            }
        }


        // Eventos usuarios

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            limpiarAgregar1();
            limpiarAgregar2();
        }

        private void button_agregar1_aceptar_Click(object sender, EventArgs e)
        {
            if (!edicion)
            {
                agregarUsuario();
            }
            else
            {
                modificarUsuario(id);
            }
        }

        private void button_agregar1_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que quieres cancelar la operación?", "Cancelar operación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                limpiarAgregar1();
            }
        }

        private void textBox_agregar1_usuario_TextChanged(object sender, EventArgs e)
        {
            comprobarAgregar1Aceptar();
        }

        private void textBox_agregar1_contrasenia_TextChanged(object sender, EventArgs e)
        {
            comprobarAgregar1Aceptar();
        }


        // Eventos palabras

        private void checkBox_nuevaCategoria_CheckedChanged_1(object sender, EventArgs e)
        {
            // Permite escribir en el checkbox si está seleccionado
            if (checkBox1_nuevaCategoria.Checked)
            {
                comboBox_agregar2_categorias.DropDownStyle = ComboBoxStyle.DropDown;
            }
            else
            {
                comboBox_agregar2_categorias.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void textBox_agregar2_palabra_TextChanged(object sender, EventArgs e)
        {
            button_agregar2_aceptar.Enabled = textBox_agregar2_palabra.Text.Length > 0;
        }

        private void comboBox_agregar2_categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_agregar2_aceptar.Enabled = textBox_agregar2_palabra.Text.Length > 0;
        }

        private void button_agregar2_aceptar_Click(object sender, EventArgs e)
        {
            if (!edicion)
            {
                agregarPalabra();
            }
            else
            {
                if (editPalabra)
                {
                    modificarPalabra(id);
                }
                else
                {
                    modificarCategoria(textBox_agregar2_palabra.Text, dataGridView1.SelectedCells[0].Value.ToString());
                }
            }

            mostrarPalabras();
        }

        private void button_agregar2_cancelar_Click(object sender, EventArgs e)
        {
            limpiarAgregar2();
        }


        // Métodos
        private void adaptarVentana()
        {
            this.Height = 676;
            this.Width = 768;

            this.StartPosition = FormStartPosition.Manual;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            button_gest_usuarios.Left = 40;
            button_gest_usuarios.Top = 115;
            button_gest_palabras.Left = 40;
            button_gest_palabras.Top = 179;

            button_salir.Left = 40;
            button_salir.Top = 569;
            panel_administrador.Visible = true;
        }

        private void habilitarBotones()
        {
            if (dataGridView1.RowCount == 0)
            {
                button_modificar.Enabled = false;
                button_eliminar.Enabled = false;
            }
            else
            {
                button_modificar.Enabled = true;
                button_eliminar.Enabled = true;
            }
        }


        // Métodos usuarios
        private void mostrarUsuarios()
        {
            try
            {
                Conexion.Open();

                string consulta = "SELECT ID, Usuario, Contrasenia, Score, Rol FROM usuarios ORDER BY ID";
                Comando = new MySqlCommand(consulta, Conexion);

                Lector = Comando.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(Lector);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los usuarios: " + ex.Message);
            }
            finally
            {
                if (Lector != null)
                    Lector.Close();

                if (Conexion != null)
                    Conexion.Close();
            }

            habilitarBotones();
            Console.WriteLine("Usuarios mostrados correctamente.");
        }

        private void mostrarUsuarios(String usuario)
        {
            try
            {
                Conexion.Open();

                string consulta = $"SELECT ID, Usuario, Contrasenia, Score, Rol FROM usuarios WHERE Usuario LIKE '%{usuario}%' ORDER BY ID";
                Comando = new MySqlCommand(consulta, Conexion);

                Lector = Comando.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(Lector);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los usuarios: " + ex.Message);
            }
            finally
            {
                if (Lector != null)
                    Lector.Close();

                if (Conexion != null)
                    Conexion.Close();
            }

            habilitarBotones();
        }

        private void cargarComboUsuarios()
        {
            try
            {
                Conexion.Open();

                string consulta = "SELECT DISTINCT Rol FROM usuarios";
                Comando = new MySqlCommand(consulta, Conexion);

                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    string rol = Lector["Rol"].ToString();
                    comboBox_agregar1_rol.Items.Add(rol);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los roles: " + ex.Message);
            }
            finally
            {
                if (Lector != null)
                    Lector.Close();

                if (Conexion != null)
                    Conexion.Close();
            }
        }

        private void agregarUsuario()
        {
            String usuario = textBox_agregar1_usuario.Text;
            String contrasenia = textBox_agregar1_contrasenia.Text;
            String rol = "";

            if (comboBox_agregar1_rol.SelectedIndex != -1)
            {
                rol = comboBox_agregar1_rol.SelectedItem.ToString();

                if (!LoginForm.existeJugador(usuario))
                {
                    LoginForm.aniadirJugador(usuario, contrasenia, rol);
                }
                else
                {
                    label_agregar1_aviso.Text = "Usuario ya existente.";
                }

                mostrarUsuarios();
                limpiarAgregar1();
            }
            else
            {
                label_agregar1_aviso.Text = "Debes seleccionar un rol.";
            }
        }

        private void mandarDatosUsuario()
        {
            panel_agregar1.Visible = true;
            edicion = true;

            // Selecciona la fila completa
            int rowIndex = 0;
            if (dataGridView1.SelectedCells.Count == 1)
            {
                rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[rowIndex].Selected = true;
            }

            // Introduce los datos de la fila en los campos especificos
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                id = int.Parse(dataGridView1.Rows[index].Cells["ID"].Value.ToString());
                textBox_agregar1_usuario.Text = dataGridView1.Rows[index].Cells["Usuario"].Value.ToString();
                textBox_agregar1_contrasenia.Text = dataGridView1.Rows[index].Cells["Contrasenia"].Value.ToString();
                string rol = dataGridView1.Rows[index].Cells["Rol"].Value.ToString();
                comboBox_agregar1_rol.SelectedItem = rol;
            }

        }

        private void modificarUsuario(int id)
        {
            String usuario = textBox_agregar1_usuario.Text;
            String contrasenia = textBox_agregar1_contrasenia.Text;
            String rol = "";

            if (comboBox_agregar1_rol.SelectedIndex != -1)
            {
                rol = comboBox_agregar1_rol.SelectedItem.ToString();

                string consultaModificar_jugador = $"UPDATE usuarios SET Usuario = '{usuario}', Contrasenia = '{contrasenia}', Rol = '{rol}' WHERE Id = {id}";
                MySqlCommand Comando = new MySqlCommand(consultaModificar_jugador, Conexion);

                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();

                Console.WriteLine("Jugador con ID " + id + " ha sido modificado correctamente");


                mostrarUsuarios();
                limpiarAgregar1();
            }
            else
            {
                label_agregar1_aviso.Text = "Debes seleccionar un rol.";
            }
        }

        private void eliminarUsuario()
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que quieres eliminar este usuario?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                // Selecciona la fila completa
                int rowIndex = 0;
                if (dataGridView1.SelectedCells.Count == 1)
                {
                    rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowIndex].Selected = true;
                }

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    id = int.Parse(dataGridView1.Rows[index].Cells["ID"].Value.ToString());

                    string consultaEliminar_jugador = $"DELETE FROM usuarios WHERE Id = {id}";
                    MySqlCommand comando = new MySqlCommand(consultaEliminar_jugador, Conexion);

                    Conexion.Open();
                    comando.ExecuteNonQuery();
                    Conexion.Close();

                    Console.WriteLine("Jugador con ID " + id + " ha sido eliminado correctamente");

                }
            }
            mostrarUsuarios();
        }

        private void comprobarAgregar1Aceptar()
        {
            if (textBox_agregar1_usuario.Text.Length > 0 && textBox_agregar1_contrasenia.Text.Length > 0)
            {
                button_agregar1_aceptar.Enabled = true;
            }
            else
            {
                button_agregar1_aceptar.Enabled = false;
            }
        }

        private void limpiarAgregar1()
        {
            textBox_agregar1_usuario.Text = "";
            textBox_agregar1_contrasenia.Text = "";
            comboBox_agregar1_rol.SelectedIndex = -1;
            label_agregar1_aviso.Text = "";
            panel_agregar1.Visible = false;
        }


        // Métodos palabras
        private void mostrarPalabras()
        {
            try
            {
                Conexion.Open();

                string consulta = "SELECT * FROM palabras ORDER BY Categoria, ID";
                Comando = new MySqlCommand(consulta, Conexion);

                Lector = Comando.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(Lector);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar las palabras: " + ex.Message);
            }
            finally
            {
                if (Lector != null)
                    Lector.Close();

                if (Conexion != null)
                    Conexion.Close();
            }

            habilitarBotones();
            Console.WriteLine("Palabras mostradas correctamente.");
        }

        private void mostrarPalabras(String palabra)
        {
            try
            {
                Conexion.Open();

                string consulta = $"SELECT * FROM palabras WHERE Palabra LIKE '%{palabra}%' ORDER BY Categoria, ID";
                Comando = new MySqlCommand(consulta, Conexion);

                Lector = Comando.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(Lector);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar las palabras: " + ex.Message);
            }
            finally
            {
                if (Lector != null)
                    Lector.Close();

                if (Conexion != null)
                    Conexion.Close();
            }

            habilitarBotones();
        }

        private void cargarComboCategorias()
        {
            try
            {
                Conexion.Open();

                string consulta = "SELECT DISTINCT Categoria FROM palabras";
                Comando = new MySqlCommand(consulta, Conexion);

                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    string rol = Lector["Categoria"].ToString();
                    comboBox_agregar2_categorias.Items.Add(rol);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message);
            }
            finally
            {
                if (Lector != null)
                    Lector.Close();

                if (Conexion != null)
                    Conexion.Close();
            }
        }

        private void agregarPalabra()
        {
            // Si el checkbox está seleccionado, se añade la nueva categoría al checkbox y se selecciona automáticamente
            if (checkBox1_nuevaCategoria.Checked)
            {
                string nuevaCategoria = comboBox_agregar2_categorias.Text;
                comboBox_agregar2_categorias.Items.Add(nuevaCategoria);
                comboBox_agregar2_categorias.SelectedItem = nuevaCategoria;
            }

            String palabra = textBox_agregar2_palabra.Text;
            String categoria = comboBox_agregar2_categorias.SelectedItem.ToString();

            if (!existePalabra(palabra))
            {
                string consultaAgregar_palabra = $"INSERT INTO palabras (Palabra, Categoria) VALUES ('{palabra}', '{categoria}')";
                MySqlCommand Comando = new MySqlCommand(consultaAgregar_palabra, Conexion);

                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();

                Console.WriteLine("La palabra '" + palabra + "' ha sido añadida correctamente");
            }

            mostrarPalabras();
            limpiarAgregar2();
        }

        private void limpiarAgregar2()
        {
            // Restablece el formulario
            label_palabra.Text = "Palabra";
            checkBox1_nuevaCategoria.Visible = true;
            comboBox_agregar2_categorias.DropDownStyle = ComboBoxStyle.DropDownList;
            label_selectCategoria.Visible = true;
            comboBox_agregar2_categorias.Visible = true;

            textBox_agregar2_palabra.Text = "";
            comboBox_agregar2_categorias.SelectedIndex = -1;
            checkBox1_nuevaCategoria.Checked = false;
            panel_agregar2.Visible = false;
        }

        public bool existePalabra(String palabra)
        {
            bool existe = false;
            string consultaVerificarPalabra = $"SELECT COUNT(*) FROM palabras WHERE Palabra = '{palabra}'";
            MySqlCommand comandoVerificar = new MySqlCommand(consultaVerificarPalabra, Conexion);

            Conexion.Open();
            int palabraExiste = Convert.ToInt32(comandoVerificar.ExecuteScalar());
            Conexion.Close();

            if (palabraExiste > 0)
            {
                existe = true;
                label_agregar2_aviso.Text = "Palabra ya existente";
            }
            else
            {
                existe = false;
            }

            return existe;
        }

        private void mandarDatosPalabras()
        {
            panel_agregar2.Visible = true;
            edicion = true;

            if (dataGridView1.SelectedCells.Count == 1)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                if (selectedCell.OwningColumn.Name == "Palabra")
                {
                    editPalabra = true;

                    // Modifica el formulario
                    label_palabra.Text = "Palabra";
                    checkBox1_nuevaCategoria.Visible = false;
                    comboBox_agregar2_categorias.DropDownStyle = ComboBoxStyle.DropDownList;
                    label_selectCategoria.Visible = true;
                    comboBox_agregar2_categorias.Visible = true;

                    // Pone los datos de la palabra en los campos
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowIndex].Selected = true;

                    int index = dataGridView1.SelectedRows[0].Index;
                    id = int.Parse(dataGridView1.Rows[index].Cells["ID"].Value.ToString());
                    textBox_agregar2_palabra.Text = dataGridView1.Rows[index].Cells["Palabra"].Value.ToString();
                    string categoria = dataGridView1.Rows[index].Cells["Categoria"].Value.ToString();
                    comboBox_agregar2_categorias.SelectedItem = categoria;
                }
                else if (selectedCell.OwningColumn.Name == "Categoria")
                {
                    editPalabra = false;

                    // Modifica el formulario
                    label_palabra.Text = "Categoría";
                    checkBox1_nuevaCategoria.Visible = false;
                    comboBox_agregar2_categorias.DropDownStyle = ComboBoxStyle.DropDownList;
                    label_selectCategoria.Visible = false;
                    comboBox_agregar2_categorias.Visible = false;

                    // Pone los datos de la categoría en los campos
                    textBox_agregar2_palabra.Text = dataGridView1.SelectedCells[0].Value.ToString();
                }
            }
        }

        private void modificarPalabra(int id)
        {
            try
            {
                String palabra = textBox_agregar2_palabra.Text;
                String categoria = comboBox_agregar2_categorias.SelectedItem.ToString();

                String consultaModificar_palabra = $"UPDATE palabras SET Palabra = '{palabra}', Categoria = '{categoria}' WHERE Id = {id}";
                MySqlCommand Comando = new MySqlCommand(consultaModificar_palabra, Conexion);

                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();

                Console.WriteLine("Palabra con ID " + id + " ha sido modificada correctamente");

                mostrarPalabras();
                limpiarAgregar2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar la palabra: " + ex.Message);
            }
        }

        private void modificarCategoria(string nuevaCategoria, string antiguaCategoria)
        {
            try
            {
                // Preguntar mensaje de confitmación
                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que quieres modificar la categoría?", "Modificar categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Conexion.Open();

                    string consulta = $"UPDATE palabras SET Categoria = '{nuevaCategoria}' WHERE Categoria = '{antiguaCategoria}'";
                    Comando = new MySqlCommand(consulta, Conexion);

                    Comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar las entradas: " + ex.Message);
            }
            finally
            {
                if (Conexion != null)
                    Conexion.Close();
            }
        }

        public void eliminarPalabra()
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que quieres eliminar esta palabra?", "Eliminar palabra", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                // Selecciona la fila completa
                int rowIndex = 0;
                if (dataGridView1.SelectedCells.Count == 1)
                {
                    rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowIndex].Selected = true;
                }

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    id = int.Parse(dataGridView1.Rows[index].Cells["ID"].Value.ToString());

                    string consultaEliminar_palabra = $"DELETE FROM palabras WHERE Id = {id}";
                    MySqlCommand comando = new MySqlCommand(consultaEliminar_palabra, Conexion);

                    Conexion.Open();
                    comando.ExecuteNonQuery();
                    Conexion.Close();

                    Console.WriteLine("La palabra ha sido eliminada correctamente");

                }
            }

            mostrarPalabras();

        }


        // Buscador
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1:
                    {
                        // Buscador de usuarios
                        if (textBox_buscador.Text == "")
                        {
                            mostrarUsuarios();
                        }
                        else
                        {
                            string texto = textBox_buscador.Text;
                            mostrarUsuarios(texto);
                        }

                        break;
                    }

                case 2:
                    {
                        // Buscador de palabras
                        if (textBox_buscador.Text == "")
                        {
                            mostrarPalabras();
                        }
                        else
                        {
                            string texto = textBox_buscador.Text;
                            mostrarPalabras(texto);
                        }

                        break;
                    }
            }

        }

    }
}
