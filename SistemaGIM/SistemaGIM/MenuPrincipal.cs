﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGIM
{
    public partial class MenuPrincipal : Form
    {
        public int IdUsuario { get; set; }

        public string NombreCompleto { get; set; }

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //CERRAR TODO Y MANDARME AL LOGIN
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text = this.NombreCompleto;
        }

        private void btnBoceto_Click(object sender, EventArgs e)
        {
            BocetoCatalogo bc = new BocetoCatalogo();
            bc.ShowDialog();
        }
    }
}
