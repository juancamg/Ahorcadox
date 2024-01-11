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
    public partial class Login : Form
    {
        public MySqlConnection Conexion;
        public MySqlCommand Comando;
        public MySqlDataReader Lector;
        public string cadenaConexion = $"server=127.0.0.1;user id=root;password=admin;database=ahorcadox";

        public Login()
        {
            InitializeComponent();
            button_login.FlatAppearance.BorderSize = 0;
            button_register.FlatAppearance.BorderSize = 0;
            button_cambiar.FlatAppearance.BorderSize = 0;

            Conexion = new MySqlConnection(cadenaConexion);
        }

        // Login
        private void button_enter_Click(object sender, EventArgs e)
        {
            String usuario = textBox_user_log.Text;
            String contrasenia1 = textBox_password1_log.Text;

            if (login(usuario, contrasenia1))
            {
                if (esAdmin(usuario))
                {
                    Administracion AdministracionForm = new Administracion();
                    AdministracionForm.Show();
                    this.Hide();

                    AdministracionForm.FormClosed += (s, args) => this.Show();
                } else
                {
                    Juego JuegoForm = new Juego(usuario);
                    JuegoForm.Show();
                    this.Hide();

                    JuegoForm.FormClosed += (s, args) => this.Show();
                }
            }
        }

        private void label_login_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::Ahorcadox.Properties.Resources.register_background;
            this.Text = "- REGISTRO -";
            panel_login.Visible = false;
            textBox_user_log.Text = "";
            textBox_password1_log.Text = "";
            panel_register.Visible = true;
        }

        private void label_forgotPassword_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::Ahorcadox.Properties.Resources.forgotPassword_background;
            this.Text = "- CONTRASEÑA OLVIDADA -";
            panel_login.Visible = false;
            textBox_user_pass.Text = textBox_user_log.Text;
            textBox_user_log.Text = "";
            textBox_password1_log.Text = "";
            panel_forgotPassword.Visible = true;

        }


        // Register
        private void label1_Click(object sender, EventArgs e)
        {
            registerToLogin();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            String usuario = textBox_user_reg.Text;
            String contrasenia1 = textBox_password1_reg.Text;
            String contrasenia2 = textBox_password2_reg.Text;

            textBox_user_log.Text = usuario;
            textBox_password1_log.Text = contrasenia1;

            if (!existeJugador(usuario))
            {
                if (contrasenia1.Equals(contrasenia2))
                {
                    aniadirJugador(usuario, contrasenia1, "usuario");
                    registerToLogin();
                } else
                {
                    label_aviso_reg.Text = "Las contraseñas no coinciden";
                }
                
            }
        }


        // Contraseña olvidada 
        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = textBox_user_pass.Text;
            String contrasenia1 = textBox_password1_pass.Text;
            String contrasenia2 = textBox_password2_pass.Text;

            if (existeJugador(usuario))
            {
                if (contrasenia1.Equals(contrasenia2))
                {
                    DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que quieres cambiar tu contraseña?", "Confirmar cambio de contraseña", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        textBox_user_log.Text = usuario;
                        textBox_password1_log.Text = contrasenia1;

                        cambiarContrasenia(usuario, contrasenia1);
                        forgotPasswordToLogin();
                    }
                }
                else
                {
                    label_aviso_pass.Text = "Las contraseñas no coinciden";
                }
            } else
            {
                label_aviso_pass.Text = "Usuario incorrecto";
            }
        }

        private void panel_volver_Click(object sender, EventArgs e)
        {
            forgotPasswordToLogin();
        }


        // Métodos
        public bool login(String usuario, String contrasenia)
        {
            bool loginCorrecto = false;
            string consultaLogin = $"SELECT COUNT(*) FROM usuarios WHERE Usuario = '{usuario}' AND Contrasenia = '{contrasenia}'";
            MySqlCommand comandoLogin = new MySqlCommand(consultaLogin, Conexion);

            Conexion.Open();
            int loginExiste = Convert.ToInt32(comandoLogin.ExecuteScalar());
            Conexion.Close();

            if (loginExiste > 0)
            {
                loginCorrecto = true;
                Console.WriteLine("El usuario " + usuario + " ha inciado sesión.");
            }
            else
            {
                Console.WriteLine("Intento de login para el usuario " + usuario + " fallido.");
                label_aviso_log.Text = " Usuario o contraseña incorrecto";
            }

            return loginCorrecto;
        }

        public bool existeJugador(String usuario)
        {
            bool existe = true;
            string consultaVerificarUsuario = $"SELECT COUNT(*) FROM usuarios WHERE Usuario = '{usuario}'";
            MySqlCommand comandoVerificar = new MySqlCommand(consultaVerificarUsuario, Conexion);

            Conexion.Open();
            int usuarioExiste = Convert.ToInt32(comandoVerificar.ExecuteScalar());
            Conexion.Close();

            if (usuarioExiste > 0)
            {
                existe = true;
                label_aviso_reg.Text = "Usuario ya existente";
            } else
            {
                existe = false;
            }

            return existe;
        }

        public bool esAdmin(String usuario)
        {
            bool esAdmin = false;
            string consultaVerificarRol = $"SELECT Rol FROM usuarios WHERE Usuario = '{usuario}'";
            MySqlCommand comandoVerificar = new MySqlCommand(consultaVerificarRol, Conexion);

            Conexion.Open();
            string rolUsuario = Convert.ToString(comandoVerificar.ExecuteScalar());
            Conexion.Close();

            if (rolUsuario == "admin")
            {
                esAdmin = true;
            }

            return esAdmin;
        }

        public void aniadirJugador(String usuario, String contrasenia, String rol)
        {
            string consultaAgregar_jugador = $"INSERT INTO usuarios (Usuario, Contrasenia, Rol) VALUES ('{usuario}', '{contrasenia}', '{rol}')";
            MySqlCommand Comando = new MySqlCommand(consultaAgregar_jugador, Conexion);

            Conexion.Open();
            Comando.ExecuteNonQuery();
            Conexion.Close();

            Console.WriteLine("Jugador '" + usuario + "' ha sido añadido correctamente");
        }

        public void cambiarContrasenia(String usuario, String contrasenia)
        {
            string consultaCambiarContrasenia = $"UPDATE usuarios SET Contrasenia = '{contrasenia}' WHERE Usuario = '{usuario}'";
            MySqlCommand Comando = new MySqlCommand(consultaCambiarContrasenia, Conexion);

            Conexion.Open();
            Comando.ExecuteNonQuery();
            Conexion.Close();

            Console.WriteLine("La contraseña del jugador '" + usuario + "' ha sido cambiada correctamente");
        }

        public void comprobarBotonRegistro()
        {
            if (textBox_user_reg.Text.Length > 0 && textBox_password1_reg.Text.Length > 0 && textBox_password2_reg.Text.Length > 0)
            {
                button_register.Enabled = true;
            }
            else
            {
                button_register.Enabled = false;
            }
        }

        public void comprobarBotonLogin()
        {
            if (textBox_user_log.Text.Length > 0 && textBox_password1_log.Text.Length > 0)
            {
                button_login.Enabled = true;
            }
            else
            {
                button_login.Enabled = false;
            }

            label_aviso_log.Text = " ";
        }

        public void comprobarBotonLostPass()
        {
            if (textBox_user_pass.Text.Length > 0 && textBox_password1_pass.Text.Length > 0 && textBox_password2_pass.Text.Length > 0)
            {
                button_cambiar.Enabled = true;
            }
            else
            {
                button_cambiar.Enabled = false;
            }
        }

        public void registerToLogin()
        {
            this.BackgroundImage = global::Ahorcadox.Properties.Resources.login_background;
            this.Text = "- INICIO DE SESIÓN -";
            panel_login.Visible = true;
            panel_register.Visible = false;
            textBox_user_reg.Text = "";
            textBox_password1_reg.Text = "";
            textBox_password2_reg.Text = "";
        }

        public void forgotPasswordToLogin()
        {
            this.BackgroundImage = global::Ahorcadox.Properties.Resources.login_background;
            this.Text = "- INICIO DE SESIÓN -";
            panel_login.Visible = true;
            panel_forgotPassword.Visible = false;
            textBox_user_pass.Text = "";
            textBox_password1_pass.Text = "";
            textBox_password2_pass.Text = "";
        }


        // Decoraciones
        private void button_enter_MouseLeave(object sender, EventArgs e)
        {
            button_login.BackColor = Color.Transparent;
        }

        private void button_enter_MouseEnter(object sender, EventArgs e)
        {
            button_login.BackColor = Color.FromArgb(23, 170, 255);
        }

        private void button_cambiar_MouseLeave(object sender, EventArgs e)
        {
            button_login.BackColor = Color.Transparent;
        }

        private void button_cambiar_MouseEnter(object sender, EventArgs e)
        {
            button_cambiar.BackColor = Color.FromArgb(23, 170, 255);

        }

        private void button_register_MouseLeave(object sender, EventArgs e)
        {
            button_register.BackColor = Color.Transparent;
        }

        private void button_register_MouseEnter(object sender, EventArgs e)
        {
            button_register.BackColor = Color.FromArgb(23, 170, 255);
        }

        private void textBox_user_reg_TextChanged(object sender, EventArgs e)
        {
            comprobarBotonRegistro();
        }

        private void textBox_password1_reg_TextChanged(object sender, EventArgs e)
        {
            comprobarBotonRegistro();
        }

        private void textBox_password2_reg_TextChanged(object sender, EventArgs e)
        {
            comprobarBotonRegistro();
        }

        private void textBox_user_log_TextChanged(object sender, EventArgs e)
        {
            comprobarBotonLogin();
        }

        private void textBox_password1_log_TextChanged(object sender, EventArgs e)
        {
            comprobarBotonLogin();
        }

        private void textBox_user_pass_TextChanged(object sender, EventArgs e)
        {
            comprobarBotonLostPass();
        }

        private void textBox_password1_pass_TextChanged(object sender, EventArgs e)
        {
            comprobarBotonLostPass();
        }

        private void textBox_password2_pass_TextChanged(object sender, EventArgs e)
        {
            comprobarBotonLostPass();
        }
    }
}
