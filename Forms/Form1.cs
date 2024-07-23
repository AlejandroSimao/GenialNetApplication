using GenialNetApplication.Settings.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenialNetApplication.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsVisibleFalse();
        }

        private void rbtnNot_CheckedChanged(object sender, EventArgs e)
        {
            IsVisibleFalse();
        }

        private void rbnYes_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            txtUser.Visible = true;
            label4.Visible = true;
            txtPassword.Visible = true;
        }

        private void IsVisibleFalse()
        {
            label2.Visible = false;
            txtUser.Visible = false;
            label4.Visible = false;
            txtPassword.Visible = false;
        }

        private void btnConect_Click(object sender, EventArgs e)
        {
            Validation(txtServer.Text, txtUser.Text, txtPassword.Text);

            string connectionString = "";
            
            if(!string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                ConectionModels conectionModels = new ConectionModels(txtUser.Text, txtPassword.Text, txtServer.Text);
                connectionString = $"Data Source={txtServer.Text};Persist Security Info=True;User ID={txtUser.Text};Password={txtPassword.Text};TrustServerCertificate=True";
                var isConnection = conectionModels.IsConnection(connectionString);
                if (isConnection)
                {
                    Main listProducts = new Main();
                    listProducts.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Os dados informados não estão corretos");
                }
            }
        }

        private bool Validation(string server, string user, string password)
        {
            if (string.IsNullOrEmpty(server))
            {
                MessageBox.Show("É obrigatório preencher o campo do servidor");

                return false;
            }

            return true;
        }
    }
}
