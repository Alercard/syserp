using business.security.login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Security.auth
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Authentication.validateCredentials(this.txtEmail.Text, this.txtPassword.Text))
            {
                MessageBox.Show("Usuario Valido");
            }
            else
            {
                MessageBox.Show("Usuario Invalido!!!");
            }
        }
    }
}
