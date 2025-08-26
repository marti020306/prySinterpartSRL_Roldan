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
            cmdUsuario = new TextBox();
            cmdContraseña = new TextBox();
            cmdAceptar = new Button();
            cmdCancelar = new Button();
            lstModulo = new ComboBox();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(65, 78);
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
            lblModulo.Location = new Point(65, 246);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(61, 20);
            lblModulo.TabIndex = 2;
            lblModulo.Text = "Modulo";
            // 
            // cmdUsuario
            // 
            cmdUsuario.Location = new Point(201, 75);
            cmdUsuario.Name = "cmdUsuario";
            cmdUsuario.Size = new Size(178, 27);
            cmdUsuario.TabIndex = 3;
            // 
            // cmdContraseña
            // 
            cmdContraseña.Location = new Point(201, 161);
            cmdContraseña.Name = "cmdContraseña";
            cmdContraseña.Size = new Size(178, 27);
            cmdContraseña.TabIndex = 4;
            // 
            // cmdAceptar
            // 
            cmdAceptar.BackColor = SystemColors.ControlLightLight;
            cmdAceptar.Location = new Point(518, 102);
            cmdAceptar.Name = "cmdAceptar";
            cmdAceptar.Size = new Size(94, 29);
            cmdAceptar.TabIndex = 6;
            cmdAceptar.Text = "Aceptar";
            cmdAceptar.UseVisualStyleBackColor = false;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(518, 206);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(94, 29);
            cmdCancelar.TabIndex = 7;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // lstModulo
            // 
            lstModulo.FormattingEnabled = true;
            lstModulo.Items.AddRange(new object[] { "Administracion ", "Sistemas", "Compras", "Ventas" });
            lstModulo.Location = new Point(201, 238);
            lstModulo.Name = "lstModulo";
            lstModulo.Size = new Size(178, 28);
            lstModulo.TabIndex = 8;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(lstModulo);
            Controls.Add(cmdCancelar);
            Controls.Add(cmdAceptar);
            Controls.Add(cmdContraseña);
            Controls.Add(cmdUsuario);
            Controls.Add(lblModulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblModulo;
        private TextBox cmdUsuario;
        private TextBox cmdContraseña;
        private Button cmdAceptar;
        private Button cmdCancelar;
        private ComboBox lstModulo;
    }
}