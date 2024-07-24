using GenialNetApplication.Events.Insertion;
using GenialNetApplication.Events.Validations;
using GenialNetApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GenialNetApplication.Forms
{
    public partial class RegisterSupplier : Form
    {
        public RegisterSupplier()
        {
            InitializeComponent();
            btnSave.Enabled = false;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var validation = DataValidation.IsValidSupplier(txtNameSupplier.Text, txtCpnj.Text, txtPhone.Text, txtCEP.Text, txtAndress.Text);
            if (validation)
            {
                Supplier supplier = new Supplier();
                supplier.Name = txtNameSupplier.Text;
                supplier.CNPJ = txtCpnj.Text;
                supplier.PhoneNumber = txtPhone.Text;
                supplier.Andress = txtAndress.Text;
                supplier.CEP = txtCEP.Text;

                var retorno = await InsertionData.InsertDataSupplier(supplier);
                if (retorno)
                {
                    MessageBox.Show("Foi inserido com sucesso o fornecedor : " + supplier.Name);

                    txtNameSupplier.Text = "";
                    txtPhone.Text = "";
                    txtCEP.Text = "";
                    txtAndress.Text = "";
                    txtCpnj.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Todos os dados precisa está preenchidos");
            }
        }

        private async void txtCEP_Leave(object sender, EventArgs e)
        {
            string cep = txtCEP.Text.Trim();

            if (string.IsNullOrEmpty(cep) || cep.Length != 8)
            {
                MessageBox.Show("Por favor, insira um CEP válido.");
                return;
            }

            string url = $"https://viacep.com.br/ws/{cep}/json/";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic result = JsonConvert.DeserializeObject(responseBody);

                    if (result != null && result.erro == null)
                    {
                        string logradouro = result.logradouro;
                        string bairro = result.bairro;
                        if (!string.IsNullOrEmpty(logradouro) && !string.IsNullOrEmpty(bairro))
                            txtAndress.Text = $"{result.logradouro}, {result.bairro}, {result.localidade} - {result.uf}";
                        else
                            txtAndress.Text = $"{result.localidade} - {result.uf}";

                        btnSave.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("CEP não encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar o CEP: {ex.Message}");
            }
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCpnj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Formatação do cnpj

        private void txtCpnj_TextChanged(object sender, EventArgs e)
        {
            // Remove caracteres não numéricos
            var textBox = sender as System.Windows.Forms.TextBox;
            var cnpj = textBox.Text.Replace(".", "").Replace("/", "").Replace("-", "");

            // Aplica formatação
            if (cnpj.Length > 14)
                cnpj = cnpj.Substring(0, 14);

            if (cnpj.Length > 12)
                textBox.Text = string.Format("{0}.{1}.{2}/{3}-{4}",
                    cnpj.Substring(0, 2),
                    cnpj.Substring(2, 3),
                    cnpj.Substring(5, 3),
                    cnpj.Substring(8, 4),
                    cnpj.Substring(12, 2));
            else if (cnpj.Length > 8)
                textBox.Text = string.Format("{0}.{1}.{2}/{3}",
                    cnpj.Substring(0, 2),
                    cnpj.Substring(2, 3),
                    cnpj.Substring(5, 3),
                    cnpj.Substring(8));
            else if (cnpj.Length > 4)
                textBox.Text = string.Format("{0}.{1}.{2}",
                    cnpj.Substring(0, 2),
                    cnpj.Substring(2, 3),
                    cnpj.Substring(5));
            else if (cnpj.Length > 2)
                textBox.Text = string.Format("{0}.{1}",
                    cnpj.Substring(0, 2),
                    cnpj.Substring(2));
            else
                textBox.Text = cnpj;

            // Define o cursor na posição correta
            textBox.SelectionStart = textBox.Text.Length;
        }

        //Formatar numeros de celular
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as System.Windows.Forms.TextBox;
            var celular = textBox.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

            // Aplica formatação
            if (celular.Length > 11)
                celular = celular.Substring(0, 11);

            if (celular.Length > 6)
                textBox.Text = string.Format("({0}) {1}-{2}",
                    celular.Substring(0, 2),
                    celular.Substring(2, 5),
                    celular.Substring(7));
            else if (celular.Length > 2)
                textBox.Text = string.Format("({0}) {1}",
                    celular.Substring(0, 2),
                    celular.Substring(2));
            else
                textBox.Text = celular;

            // Define o cursor na posição correta
            textBox.SelectionStart = textBox.Text.Length;
        }
    }
}
