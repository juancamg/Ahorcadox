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
    public partial class Juego : Form
    {
        public MySqlConnection Conexion;
        public MySqlCommand Comando;
        public MySqlDataReader Lector;
        public string cadenaConexion = $"server=127.0.0.1;user id=root;password=admin;database=ahorcadox";
        Login LoginForm = new Login();

        String jugador1;
        bool dosJugadores = false;

        public Juego(String usuario)
        {
            InitializeComponent();

            jugador1 = usuario;
            inicializarJuego();
        }

        // Inicializar juego
        private void inicializarJuego()
        {
            this.Width = 1024;
            this.Height = 768;

            // Si el jugador no tiene avatar, se abre menú de selección de avatar
            obtenerAvatar(jugador1);

            // Mostramos el panel de selección de juego
            inicializarMenuPrincipal();

            // Colocar todos los paneles en sus posiciones iniciales
            panel_elegirAvatar.Location = new Point(12, 12);
            panel_informacion.Location = new Point(12, 12);
        }

        private int obtenerAvatar(string usuario)
        {

            // Consulta que lee el campo "Avatar" del usuario
            string consulta = "SELECT Avatar FROM usuarios WHERE  Usuario = @usuario";

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", usuario);

                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read() && !lector.IsDBNull(0))
                        {
                            int numAvatar = lector.GetInt32(0);
                            return numAvatar;
                        }
                        else
                        {
                            // El campo "Avatar" del usuario es nulo
                            panel_elegirAvatar.Visible = true;
                            return 1;
                        }
                    }
                }
            }
        }

        // Eventos de los pictureBox de los avatares
        private void pictureBox_avatar1_Click(object sender, EventArgs e)
        {
           asignarAvatar(1);
        }

        private void pictureBox_avatar2_Click(object sender, EventArgs e)
        {
           asignarAvatar(2);
        }

        private void pictureBox_avatar3_Click(object sender, EventArgs e)
        {
           asignarAvatar(3);
        }

        private void pictureBox_avatar4_Click(object sender, EventArgs e)
        {
            asignarAvatar(4);
        }

        private void pictureBox_avatar5_Click(object sender, EventArgs e)
        {
            asignarAvatar(5);
        }

        private void pictureBox_avatar6_Click(object sender, EventArgs e)
        {
            asignarAvatar(6);
        }

        private void pictureBox_avatar7_Click(object sender, EventArgs e)
        {
            asignarAvatar(7);
        }

        private void asignarAvatar(int avatar)
        {
            // Consulta que actualiza el campo "Avatar" del usuario
            string consulta = "UPDATE usuarios SET Avatar = @avatar WHERE Usuario = @usuario";

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@avatar", avatar);
                    comando.Parameters.AddWithValue("@usuario", jugador1);

                    comando.ExecuteNonQuery();
                }
            }

            panel_elegirAvatar.Visible = false;
            inicializarMenuPrincipal();
        }

        private void inicializarMenuPrincipal()
        {
            panel_seleccion_juego.Visible = true;
            int avatar = obtenerAvatar(jugador1);

            // Mostramos el avatar del jugador
            pictureBox_avatarJugador1.Image = Image.FromFile($"../../Resources/Avatar{avatar}.png");
        }

        // Animación de botones (seleccion_de_juego)
        private void pictureBox_1Jugador_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_1Jugador.Width = 410;
            pictureBox_1Jugador.Height = 103;
        }

        private void pictureBox_1Jugador_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_1Jugador.Width = 383;
            pictureBox_1Jugador.Height = 98;
        }

        private void pictureBox_2Jugadores_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_2Jugadores.Width = 469;
            pictureBox_2Jugadores.Height = 103;
        }

        private void pictureBox_2Jugadores_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_2Jugadores.Width = 442;
            pictureBox_2Jugadores.Height = 98;
        }

        private void pictureBox_estadisticas_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_informacion.Width = 469;
            pictureBox_informacion.Height = 103;
        }

        private void pictureBox_estadisticas_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_informacion.Width = 442;
            pictureBox_informacion.Height = 98;
        }

        // 1 Jugador
        private void pictureBox_1Jugador_Click(object sender, EventArgs e)
        {
            inicializar1Jugador();
        }

        // 2 Jugadores
        private void pictureBox_2Jugadores_Click(object sender, EventArgs e)
        {
            panel_seleccion_juego.Visible = false;
        }

        // Información
        private void pictureBox_informacion_Click(object sender, EventArgs e)
        {
            panel_seleccion_juego.Visible = false;
            panel_informacion.Visible = true;
        }

        // Animación de botones (Información)
        private void pictureBox_BotonCambiarContrasenia_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_BotonCambiarContrasenia.Width = 385;
            pictureBox_BotonCambiarContrasenia.Height = 97;
        }

        private void pictureBox_BotonCambiarContrasenia_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_BotonCambiarContrasenia.Width = 383;
            pictureBox_BotonCambiarContrasenia.Height = 93;
        }

        private void pictureBox_BotonCambiarAvatar_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_BotonCambiarAvatar.Width = 387;
            pictureBox_BotonCambiarAvatar.Height = 80;
        }

        private void pictureBox_BotonCambiarAvatar_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_BotonCambiarAvatar.Width = 383;
            pictureBox_BotonCambiarAvatar.Height = 75;
        }

        private void pictureBox_BotonEstadisticas_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_BotonEstadisticas.Width = 387;
            pictureBox_BotonEstadisticas.Height = 80;
        }

        private void pictureBox_BotonEstadisticas_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_BotonEstadisticas.Width = 383;
            pictureBox_BotonEstadisticas.Height = 75;
        }

        // Cambio contraseña
        private void pictureBox_BotonCambiarContrasenia_Click(object sender, EventArgs e)
        {
            panel_cambiarContrasenia.Visible = true;
        }
        private void button_aceptarCambioContrasenia_Click(object sender, EventArgs e)
        {
            cambiarContrasenia();
        }
        private void cambiarContrasenia()
        {
            if (textBox_nuevaContrasenia1.Text.ToString() == textBox_nuevaContrasenia2.Text.ToString())
            {
                // Crea un diálogo que pregunta si se quiere cambiar la contraseña
                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que quieres cambiar la contraseña?", "Cambiar contraseña", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    LoginForm.cambiarContrasenia(jugador1, textBox_nuevaContrasenia1.Text.ToString());
                }
                limpiarCambioContrasenia();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }
        private void button_cancelarCambioContrasenia_Click(object sender, EventArgs e)
        {
            limpiarCambioContrasenia();
        }
        private void limpiarCambioContrasenia()
        {
            textBox_nuevaContrasenia1.Text = "";
            textBox_nuevaContrasenia2.Text = "";
            panel_cambiarContrasenia.Visible = false;
        }

        // Cambio avatar
        private void pictureBox_BotonCambiarAvatar_Click(object sender, EventArgs e)
        {
            panel_elegirAvatar.Visible = true;
            panel_informacion.Visible = false;
        }

        // Estadísticas
        private void pictureBox_BotonEstadisticas_Click(object sender, EventArgs e)
        {
            panel_estadisticas.Visible = true;
            mostrarEstadisticas();
        }
        private void mostrarEstadisticas()
        {
            int numDerrotas = 0;
            int numVictorias = 0;
            int score = 0;

            // Recogemos los datos de la base de datos
            string consulta = "SELECT COUNT(Victoria) FROM partidas WHERE Nombre = @usuario AND Victoria = 'N'";
            string consulta2 = "SELECT COUNT(Victoria) FROM partidas WHERE Nombre = @usuario AND Victoria = 'Y'";
            string consulta3 = "SELECT Score FROM partidas WHERE Nombre = @usuario";

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", jugador1);

                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read() && !lector.IsDBNull(0))
                        {
                            numDerrotas = lector.GetInt32(0);
                        }
                    }
                }
                using (MySqlCommand comando = new MySqlCommand(consulta2, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", jugador1);

                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read() && !lector.IsDBNull(0))
                        {
                            numVictorias = lector.GetInt32(0);
                        }
                    }
                }
                using (MySqlCommand comando = new MySqlCommand(consulta3, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", jugador1);

                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read() && !lector.IsDBNull(0))
                        {
                            score += lector.GetInt32(0);
                        }
                    }
                }
            }

            // Mostramos los datos en pantalla
            label_partidasJugadas.Text = "Partidas jugadas: " + (numVictorias + numDerrotas).ToString();
            label_partidasGanadas.Text = "Victorias: " + numVictorias.ToString();
            label_partidasPerdidas.Text = "Derrotas: " + numDerrotas.ToString();
            label_puntuacionTotal.Text = "Puntuación total: " + score.ToString();
        }
        private void button_cerrarEstadisticas_Click(object sender, EventArgs e)
        {
            panel_estadisticas.Visible = false;
        }

        // Modo 1 jugador
        private void inicializar1Jugador()
        {
            // Ocultamos el panel de selección de juego
            panel_seleccion_juego.Visible = false;

            // Mostramos el panel de juego
           // panel_juego.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_informacion.Visible = false;
            panel_seleccion_juego.Visible = true;
        }

        
    }
}
