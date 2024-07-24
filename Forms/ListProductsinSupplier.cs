using GenialNetApplication.Events.Insertion;
using GenialNetApplication.Events.Searchs;
using GenialNetApplication.Models;
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

namespace GenialNetApplication.Forms
{
    public partial class ListProductsinSupplier : Form
    {
        public ListProductsinSupplier()
        {
            InitializeComponent();
            LoadDataSupplierCombo();
        }

        private void LoadDataSupplierCombo()
        {
            var suppliers = SearchData.GetSupplier();
            cbxSupplier.DataSource = suppliers;
            cbxSupplier.DisplayMember = "Name";
            cbxSupplier.ValueMember = "ID";
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            int SupplierId = cbxSupplier.SelectedIndex == -1 ? cbxSupplier.SelectedIndex : cbxSupplier.SelectedIndex + 1;
            if (SupplierId > 0)
                await GetProductsWhithSupplier(SupplierId);
        }

        private async Task GetProductsWhithSupplier(int SupplierId)
        {
            using (var context = new ApplicationDbContext())
            {
                var query = from p in context.Products
                            join s in context.Suppliers on p.SuplierId equals s.ID
                            where p.SuplierId == SupplierId
                            select new
                            {
                                ProductId = p.ID,
                                ProductName = p.Name,
                                Price = p.Price,
                                Brand = p.Brand,
                                Description = p.Description,
                                Unit = p.UnitMeasurement,
                                NameSupplier = s.Name,
                            };

                var result = await query.ToListAsync();

                this.datagridProducts.DataSource = result;
                datagridProducts.Columns["ProductId"].Visible = false;
                datagridProducts.Columns["ProductName"].HeaderText = "Nome do produto";
                datagridProducts.Columns["Price"].HeaderText = "Preço do produto";
                datagridProducts.Columns["Brand"].HeaderText = "Marca do produto";
                datagridProducts.Columns["Unit"].HeaderText = "Unidade de medida do produto";
                datagridProducts.Columns["Description"].HeaderText = "Descrição do produto";
                datagridProducts.Columns["NameSupplier"].HeaderText = "Nome do fornecedor";
            }

        }


        private async void datagridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var rowIndex = e.RowIndex;
                var columnIndex = e.ColumnIndex;

                // Pegando o valor da célula clicada
                var cellValue = datagridProducts.Rows[rowIndex].Cells[columnIndex].Value;
                var columnName = datagridProducts.Columns[columnIndex].HeaderText;

                if (columnName != "Nome do fornecedor")
                {
                    var dialogResult = MessageBox.Show("Deseja alterar a coluna ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var retorno = Microsoft.VisualBasic.Interaction.InputBox("", "Alteração de dados", cellValue.ToString());

                        var cellId = datagridProducts.Rows[rowIndex].Cells[0].Value;

                        var isUpdate = await UpdatesData.UpdateProduct((int)cellId, columnName, retorno);

                        if (isUpdate)
                        {
                            MessageBox.Show("Atualizado com sucesso");
                            int SupplierId = cbxSupplier.SelectedIndex == -1 ? cbxSupplier.SelectedIndex : cbxSupplier.SelectedIndex + 1;
                            if (SupplierId > 0)
                                await GetProductsWhithSupplier(SupplierId);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Não é possivel alterar essa coluna");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = datagridProducts.CurrentCell.RowIndex;
            datagridProducts.Rows.RemoveAt(rowIndex);
        }
    }
}
