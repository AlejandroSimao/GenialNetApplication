using GenialNetApplication.Events.Searchs;
using GenialNetApplication.Models;
using GenialNetApplication.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenialNetApplication.Events.Insertion
{
    public class InsertionData
    {
        public async static Task<bool> InsertDataSupplier(Supplier supplier)
        {
            try
            {
                var retorno = await SearchData.IsExistSupplierCPNJ(supplier.CNPJ);
                if (retorno == false)
                {
                    using (var context = new ApplicationDbContext())
                    {
                        await context.Suppliers.AddAsync(supplier);
                        await context.SaveChangesAsync();

                        return true;
                    }
                }
                else 
                {
                    MessageBox.Show("Já existe dados com esse cadastro de CNPJ");
                    return false;
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Falha na inserção de dados" + ex.Message);
                return false;
            }
         
        }
        public async static Task<bool> InsertDataProduct(Product product)
        {
            try
            {
                var retorno = await SearchData.IsExistProduct(product);
                if (retorno == false)
                {
                    using (var context = new ApplicationDbContext())
                    {
                        await context.Products.AddAsync(product);
                        await context.SaveChangesAsync();

                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Já existe produtos com esses dados");
                    return false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha na inserção de dados" + ex.Message);
                return false;
            }

        }

    }
}
