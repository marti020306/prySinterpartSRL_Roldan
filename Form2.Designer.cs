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
            lstModulo = new ComboBox();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(57, 58);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario ";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(57, 123);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(70, 15);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña ";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Location = new Point(57, 184);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(49, 15);
            lblModulo.TabIndex = 2;
            lblModulo.Text = "Modulo";
            // 
            // txtUsuario
            // 
            txtUsuario.ForeColor = Color.FromArgb(0, 0, 64);
            txtUsuario.Location = new Point(176, 56);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(156, 23);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextChanged += cmdUsuario_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(176, 121);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '•';
            txtContraseña.Size = new Size(156, 23);
            txtContraseña.TabIndex = 4;
            // 
            // cmdAceptar
            // 
            cmdAceptar.BackColor = SystemColors.ActiveBorder;
            cmdAceptar.Location = new Point(453, 76);
            cmdAceptar.Margin = new Padding(3, 2, 3, 2);
            cmdAceptar.Name = "cmdAceptar";
            cmdAceptar.Size = new Size(82, 22);
            cmdAceptar.TabIndex = 6;
            cmdAceptar.Text = "Aceptar";
            cmdAceptar.UseVisualStyleBackColor = false;
            cmdAceptar.Click += cmdAceptar_Click;
            // 
            // cmdCancelar
            // 
            cmdCancelar.BackColor = SystemColors.ControlDark;
            cmdCancelar.Location = new Point(453, 154);
            cmdCancelar.Margin = new Padding(3, 2, 3, 2);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(82, 22);
            cmdCancelar.TabIndex = 7;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = false;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // lstModulo
            // 
            lstModulo.FormattingEnabled = true;
            lstModulo.Items.AddRange(new object[] { "Administracion ", "Sistemas", "Compras", "Ventas" });
            lstModulo.Location = new Point(176, 178);
            lstModulo.Margin = new Padding(3, 2, 3, 2);
            lstModulo.Name = "lstModulo";
            lstModulo.Size = new Size(156, 23);
            lstModulo.TabIndex = 8;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(700, 338);
            Controls.Add(lstModulo);
            Controls.Add(cmdCancelar);
            Controls.Add(cmdAceptar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblModulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "Login";
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
        private ComboBox lstModulo;
    }
}