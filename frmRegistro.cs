﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySinterpartSRL_Roldan
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdUsuario_TextChanged(object sender, EventArgs e)
        {
            cmdUsuario_TextChanged(sender, e, txtContraseña);
        }

        private void cmdUsuario_TextChanged(object sender, EventArgs e, TextBox txtContraseña)
        {
            if (txtUsuario.Text == "")
            {

                txtContraseña.Enabled = false;

            }
            else
            {
                txtContraseña.Enabled = true;
            }
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
           Calcular();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";

            cmbModulo.SelectedIndex = -1;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                cmdAceptar.Enabled = false;
            }
            else
            {
                cmdAceptar.Enabled = true;
            }
        }
        private void Calcular()
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string modulo = cmbModulo.SelectedItem.ToString();
            int intentosFallidos = 0;

            bool acceso = false;

            if (usuario == "adm" && contraseña == "@1a" && (modulo == "ADM" || modulo == "COM" || modulo == "VTA"))
            {
                acceso = true;
            }
            else if (usuario == "John" && contraseña == "*2b" && modulo == "SIST")
            {
                acceso = true;
            }
            else if (usuario == "Ceci" && contraseña == "@3c" && (modulo == "VTA" || modulo == "ADM"))
            {
                acceso = true;
            }
            else if (usuario == "God" && contraseña == "*@#4d")
            {
                acceso = true;
            }

            if (acceso)
            {
                intentosFallidos = 0;
                this.Hide();
                frmBienvenida frmBienvenida = new frmBienvenida();
                frmBienvenida.ShowDialog();
                this.Show();
            }
            else
            {
                intentosFallidos++;
                MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");

                if (intentosFallidos >= 2)
                {
                    this.Close();
                }
            }
        }
    }
}

