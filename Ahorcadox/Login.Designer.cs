
namespace Ahorcadox
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textBox_user_log = new System.Windows.Forms.TextBox();
            this.textBox_password1_log = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label_login = new System.Windows.Forms.Label();
            this.panel_login = new System.Windows.Forms.Panel();
            this.label_aviso_log = new System.Windows.Forms.Label();
            this.label_forgotPassword = new System.Windows.Forms.Label();
            this.panel_register = new System.Windows.Forms.Panel();
            this.label_aviso_reg = new System.Windows.Forms.Label();
            this.textBox_password2_reg = new System.Windows.Forms.TextBox();
            this.label_register = new System.Windows.Forms.Label();
            this.button_register = new System.Windows.Forms.Button();
            this.textBox_user_reg = new System.Windows.Forms.TextBox();
            this.textBox_password1_reg = new System.Windows.Forms.TextBox();
            this.panel_forgotPassword = new System.Windows.Forms.Panel();
            this.panel_volver = new System.Windows.Forms.Panel();
            this.textBox_password2_pass = new System.Windows.Forms.TextBox();
            this.button_cambiar = new System.Windows.Forms.Button();
            this.textBox_user_pass = new System.Windows.Forms.TextBox();
            this.textBox_password1_pass = new System.Windows.Forms.TextBox();
            this.label_aviso_pass = new System.Windows.Forms.Label();
            this.panel_login.SuspendLayout();
            this.panel_register.SuspendLayout();
            this.panel_forgotPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_user_log
            // 
            this.textBox_user_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.textBox_user_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_user_log, "textBox_user_log");
            this.textBox_user_log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.textBox_user_log.Name = "textBox_user_log";
            this.textBox_user_log.TextChanged += new System.EventHandler(this.textBox_user_log_TextChanged);
            // 
            // textBox_password1_log
            // 
            this.textBox_password1_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.textBox_password1_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_password1_log, "textBox_password1_log");
            this.textBox_password1_log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.textBox_password1_log.Name = "textBox_password1_log";
            this.textBox_password1_log.TextChanged += new System.EventHandler(this.textBox_password1_log_TextChanged);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button_login, "button_login");
            this.button_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button_login.Name = "button_login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_enter_Click);
            this.button_login.MouseEnter += new System.EventHandler(this.button_enter_MouseEnter);
            this.button_login.MouseLeave += new System.EventHandler(this.button_enter_MouseLeave);
            // 
            // label_login
            // 
            resources.ApplyResources(this.label_login, "label_login");
            this.label_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_login.Name = "label_login";
            this.label_login.Click += new System.EventHandler(this.label_login_Click);
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.Transparent;
            this.panel_login.Controls.Add(this.label_aviso_log);
            this.panel_login.Controls.Add(this.label_forgotPassword);
            this.panel_login.Controls.Add(this.label_login);
            this.panel_login.Controls.Add(this.button_login);
            this.panel_login.Controls.Add(this.textBox_user_log);
            this.panel_login.Controls.Add(this.textBox_password1_log);
            resources.ApplyResources(this.panel_login, "panel_login");
            this.panel_login.Name = "panel_login";
            // 
            // label_aviso_log
            // 
            resources.ApplyResources(this.label_aviso_log, "label_aviso_log");
            this.label_aviso_log.BackColor = System.Drawing.Color.Transparent;
            this.label_aviso_log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_aviso_log.ForeColor = System.Drawing.Color.Firebrick;
            this.label_aviso_log.Name = "label_aviso_log";
            // 
            // label_forgotPassword
            // 
            resources.ApplyResources(this.label_forgotPassword, "label_forgotPassword");
            this.label_forgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_forgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.label_forgotPassword.Name = "label_forgotPassword";
            this.label_forgotPassword.Click += new System.EventHandler(this.label_forgotPassword_Click);
            // 
            // panel_register
            // 
            this.panel_register.BackColor = System.Drawing.Color.Transparent;
            this.panel_register.Controls.Add(this.label_aviso_reg);
            this.panel_register.Controls.Add(this.textBox_password2_reg);
            this.panel_register.Controls.Add(this.label_register);
            this.panel_register.Controls.Add(this.button_register);
            this.panel_register.Controls.Add(this.textBox_user_reg);
            this.panel_register.Controls.Add(this.textBox_password1_reg);
            resources.ApplyResources(this.panel_register, "panel_register");
            this.panel_register.Name = "panel_register";
            // 
            // label_aviso_reg
            // 
            resources.ApplyResources(this.label_aviso_reg, "label_aviso_reg");
            this.label_aviso_reg.BackColor = System.Drawing.Color.Transparent;
            this.label_aviso_reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_aviso_reg.ForeColor = System.Drawing.Color.Firebrick;
            this.label_aviso_reg.Name = "label_aviso_reg";
            // 
            // textBox_password2_reg
            // 
            this.textBox_password2_reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.textBox_password2_reg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_password2_reg, "textBox_password2_reg");
            this.textBox_password2_reg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.textBox_password2_reg.Name = "textBox_password2_reg";
            this.textBox_password2_reg.TextChanged += new System.EventHandler(this.textBox_password2_reg_TextChanged);
            // 
            // label_register
            // 
            resources.ApplyResources(this.label_register, "label_register");
            this.label_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_register.Name = "label_register";
            this.label_register.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.Transparent;
            this.button_register.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button_register, "button_register");
            this.button_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button_register.Name = "button_register";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            this.button_register.MouseEnter += new System.EventHandler(this.button_register_MouseEnter);
            this.button_register.MouseLeave += new System.EventHandler(this.button_register_MouseLeave);
            // 
            // textBox_user_reg
            // 
            this.textBox_user_reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.textBox_user_reg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_user_reg, "textBox_user_reg");
            this.textBox_user_reg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.textBox_user_reg.Name = "textBox_user_reg";
            this.textBox_user_reg.TextChanged += new System.EventHandler(this.textBox_user_reg_TextChanged);
            // 
            // textBox_password1_reg
            // 
            this.textBox_password1_reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.textBox_password1_reg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_password1_reg, "textBox_password1_reg");
            this.textBox_password1_reg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.textBox_password1_reg.Name = "textBox_password1_reg";
            this.textBox_password1_reg.TextChanged += new System.EventHandler(this.textBox_password1_reg_TextChanged);
            // 
            // panel_forgotPassword
            // 
            this.panel_forgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.panel_forgotPassword.Controls.Add(this.label_aviso_pass);
            this.panel_forgotPassword.Controls.Add(this.panel_volver);
            this.panel_forgotPassword.Controls.Add(this.textBox_password2_pass);
            this.panel_forgotPassword.Controls.Add(this.button_cambiar);
            this.panel_forgotPassword.Controls.Add(this.textBox_user_pass);
            this.panel_forgotPassword.Controls.Add(this.textBox_password1_pass);
            resources.ApplyResources(this.panel_forgotPassword, "panel_forgotPassword");
            this.panel_forgotPassword.Name = "panel_forgotPassword";
            // 
            // panel_volver
            // 
            this.panel_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.panel_volver, "panel_volver");
            this.panel_volver.Name = "panel_volver";
            this.panel_volver.Click += new System.EventHandler(this.panel_volver_Click);
            // 
            // textBox_password2_pass
            // 
            this.textBox_password2_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.textBox_password2_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_password2_pass, "textBox_password2_pass");
            this.textBox_password2_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.textBox_password2_pass.Name = "textBox_password2_pass";
            this.textBox_password2_pass.TextChanged += new System.EventHandler(this.textBox_password2_pass_TextChanged);
            // 
            // button_cambiar
            // 
            this.button_cambiar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button_cambiar, "button_cambiar");
            this.button_cambiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button_cambiar.Name = "button_cambiar";
            this.button_cambiar.UseVisualStyleBackColor = false;
            this.button_cambiar.Click += new System.EventHandler(this.button1_Click);
            this.button_cambiar.MouseEnter += new System.EventHandler(this.button_cambiar_MouseEnter);
            this.button_cambiar.MouseLeave += new System.EventHandler(this.button_cambiar_MouseLeave);
            // 
            // textBox_user_pass
            // 
            this.textBox_user_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.textBox_user_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_user_pass, "textBox_user_pass");
            this.textBox_user_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.textBox_user_pass.Name = "textBox_user_pass";
            this.textBox_user_pass.TextChanged += new System.EventHandler(this.textBox_user_pass_TextChanged);
            // 
            // textBox_password1_pass
            // 
            this.textBox_password1_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.textBox_password1_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_password1_pass, "textBox_password1_pass");
            this.textBox_password1_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.textBox_password1_pass.Name = "textBox_password1_pass";
            this.textBox_password1_pass.TextChanged += new System.EventHandler(this.textBox_password1_pass_TextChanged);
            // 
            // label_aviso_pass
            // 
            resources.ApplyResources(this.label_aviso_pass, "label_aviso_pass");
            this.label_aviso_pass.BackColor = System.Drawing.Color.Transparent;
            this.label_aviso_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_aviso_pass.ForeColor = System.Drawing.Color.Firebrick;
            this.label_aviso_pass.Name = "label_aviso_pass";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Ahorcadox.Properties.Resources.login_background;
            this.Controls.Add(this.panel_forgotPassword);
            this.Controls.Add(this.panel_register);
            this.Controls.Add(this.panel_login);
            this.Name = "Login";
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_register.ResumeLayout(false);
            this.panel_register.PerformLayout();
            this.panel_forgotPassword.ResumeLayout(false);
            this.panel_forgotPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_user_log;
        private System.Windows.Forms.TextBox textBox_password1_log;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Panel panel_register;
        private System.Windows.Forms.TextBox textBox_password2_reg;
        private System.Windows.Forms.Label label_register;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.TextBox textBox_user_reg;
        private System.Windows.Forms.TextBox textBox_password1_reg;
        private System.Windows.Forms.Label label_forgotPassword;
        private System.Windows.Forms.Panel panel_forgotPassword;
        private System.Windows.Forms.TextBox textBox_password2_pass;
        private System.Windows.Forms.Button button_cambiar;
        private System.Windows.Forms.TextBox textBox_user_pass;
        private System.Windows.Forms.TextBox textBox_password1_pass;
        private System.Windows.Forms.Panel panel_volver;
        private System.Windows.Forms.Label label_aviso_reg;
        private System.Windows.Forms.Label label_aviso_log;
        private System.Windows.Forms.Label label_aviso_pass;
    }
}

