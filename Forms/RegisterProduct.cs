using GenialNetApplication.Events.Insertion;
using GenialNetApplication.Events.Searchs;
using GenialNetApplication.Events.Validations.Supplier;
using GenialNetApplication.Models;
using GenialNetApplication.Models.Enums;
using GenialNetApplication.Settings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GenialNetApplication.Forms
{
    public partial class RegisterProduct : Form
    {
        public RegisterProduct()
        {
            InitializeComponent();
            LoadDataSupplierCombo();
            LoadDataUNCombo();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string productName = txtNameProduct.Text;
            string BrandProduct = txtBrand.Text;
            string DescriptionProduct = txtDescription.Text;
            decimal PriceProduct = Convert.ToDecimal(textBox1.Text ?? "0");
            int SupplierId = cbxSuppiler.SelectedIndex == -1 ? cbxSuppiler.SelectedIndex : cbxSuppiler.SelectedIndex  + 1;
            var unit = cbxUnit.SelectedIndex;
            var isValid = DataValidation.IsValidProduct(productName, BrandProduct, DescriptionProduct, PriceProduct, SupplierId);

            if (isValid)
            {
                Product product = new Product();
                product.Name = productName;
                product.Brand = BrandProduct;
                product.Description = DescriptionProduct;
                product.Price = PriceProduct;
                product.UnitMeasurement = (UnitMeasurement)unit;
                product.SuplierId = SupplierId;

                var retorno = await InsertionData.InsertDataProduct(product);
                if (retorno)
                {
                    MessageBox.Show("Dados inseridos com sucesso");
                    txtNameProduct.Text = "";
                    txtBrand.Text = "";
                    txtDescription.Text = "";
                    textBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Dados incorretos para inserção");
            }

        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox tb = sender as System.Windows.Forms.TextBox;

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
            System.Windows.Forms.TextBox tb = sender as System.Windows.Forms.TextBox;
            if (decimal.TryParse(tb.Text, out decimal value))
            {
                tb.Text = value.ToString("F2"); // Formatar com duas casas decimais
            }
            else
            {
                tb.Text = "0.00"; // Definir um valor padrão caso a entrada não seja válida
            }
        }


        private void LoadDataSupplierCombo()
        {

            var suppliers = SearchData.GetSupplier();
            cbxSuppiler.DataSource = suppliers;
            cbxSuppiler.DisplayMember = "Name";
            cbxSuppiler.ValueMember = "ID";
        }

        private void LoadDataUNCombo()
        {
            cbxUnit.DataSource = Enum.GetValues(typeof(UnitMeasurement)).Cast<UnitMeasurement>();
        }
    }
}
