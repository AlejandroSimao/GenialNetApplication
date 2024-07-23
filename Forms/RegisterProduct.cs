using GenialNetApplication.Models;
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
    public partial class RegisterProduct : Form
    {
        public RegisterProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            


           
        }

      

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            // Permitir números, o caractere de backspace e o ponto/virgula decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Permitir apenas um ponto ou vírgula decimal
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (tb.Text.IndexOf('.') > -1 || tb.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            // Verificar se existem mais de duas casas decimais
            if (char.IsDigit(e.KeyChar))
            {
                string[] parts = tb.Text.Split('.', ',');
                if (parts.Length > 1 && parts[1].Length >= 2)
                {
                    if (tb.SelectionStart > tb.Text.IndexOf('.') || tb.SelectionStart > tb.Text.IndexOf(','))
                    {
                        e.Handled = true;
                    }
                }
            }
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (decimal.TryParse(tb.Text, out decimal value))
            {
                tb.Text = value.ToString("F2"); // Formatar com duas casas decimais
            }
            else
            {
                tb.Text = "0.00"; // Definir um valor padrão caso a entrada não seja válida
            }
        }
    }
}
