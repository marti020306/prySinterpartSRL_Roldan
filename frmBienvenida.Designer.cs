namespace prySinterpartSRL_Roldan
{
    partial class frmBienvenida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblbienvenido = new Label();
            lblSinterpartSRL = new Label();
            SuspendLayout();
            // 
            // lblbienvenido
            // 
            lblbienvenido.AutoSize = true;
            lblbienvenido.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblbienvenido.Location = new Point(248, 62);
            lblbienvenido.Name = "lblbienvenido";
            lblbienvenido.Size = new Size(269, 60);
            lblbienvenido.TabIndex = 0;
            lblbienvenido.Text = "Bienvenido!";
            // 
            // lblSinterpartSRL
            // 
            lblSinterpartSRL.AutoSize = true;
            lblSinterpartSRL.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSinterpartSRL.ForeColor = Color.FromArgb(192, 0, 0);
            lblSinterpartSRL.Location = new Point(175, 182);
            lblSinterpartSRL.Name = "lblSinterpartSRL";
            lblSinterpartSRL.Size = new Size(422, 81);
            lblSinterpartSRL.TabIndex = 1;
            lblSinterpartSRL.Text = "SinterpartSRL";
            // 
            // frmBienvenida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSinterpartSRL);
            Controls.Add(lblbienvenido);
            Name = "frmBienvenida";
            Text = "sinterpartSRL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblbienvenido;
        private Label lblSinterpartSRL;
    }
}
