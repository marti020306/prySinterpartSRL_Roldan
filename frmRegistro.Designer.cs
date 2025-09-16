namespace prySinterpartSRL_Roldan
{
    partial class frmLogin
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
            lblUsuario = new Label();
            lblContraseña = new Label();
            lblModulo = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            cmdAceptar = new Button();
            cmdCancelar = new Button();
            cmbModulo = new ComboBox();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(65, 77);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario ";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(65, 164);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(87, 20);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña ";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Location = new Point(65, 245);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(61, 20);
            lblModulo.TabIndex = 2;
            lblModulo.Text = "Modulo";
            // 
            // txtUsuario
            // 
            txtUsuario.ForeColor = Color.FromArgb(0, 0, 64);
            txtUsuario.Location = new Point(201, 75);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(178, 27);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextChanged += cmdUsuario_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Location = new Point(201, 161);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '•';
            txtContraseña.Size = new Size(178, 27);
            txtContraseña.TabIndex = 4;
            // 
            // cmdAceptar
            // 
            cmdAceptar.BackColor = SystemColors.ActiveBorder;
            cmdAceptar.Location = new Point(107, 331);
            cmdAceptar.Name = "cmdAceptar";
            cmdAceptar.Size = new Size(94, 29);
            cmdAceptar.TabIndex = 6;
            cmdAceptar.Text = "Aceptar";
            cmdAceptar.UseVisualStyleBackColor = false;
            cmdAceptar.Click += cmdAceptar_Click;
            // 
            // cmdCancelar
            // 
            cmdCancelar.BackColor = SystemColors.ControlDark;
            cmdCancelar.Location = new Point(328, 331);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(94, 29);
            cmdCancelar.TabIndex = 7;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = false;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // cmbModulo
            // 
            cmbModulo.FormattingEnabled = true;
            cmbModulo.Items.AddRange(new object[] { "ADM", "SIST", "COM ", "VTA" });
            cmbModulo.Location = new Point(201, 237);
            cmbModulo.Name = "cmbModulo";
            cmbModulo.Size = new Size(178, 28);
            cmbModulo.TabIndex = 8;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(551, 451);
            Controls.Add(cmbModulo);
            Controls.Add(cmdCancelar);
            Controls.Add(cmdAceptar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblModulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Name = "frmLogin";
            Text = "Login";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblModulo;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button cmdAceptar;
        private Button cmdCancelar;
        private ComboBox cmbModulo;
    }
}