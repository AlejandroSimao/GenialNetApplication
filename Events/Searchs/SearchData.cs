using GenialNetApplication.Models;
using GenialNetApplication.Settings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenialNetApplication.Events.Searchs
{
    public class SearchData
    {
        public async static Task<bool> IsExistSupplierCPNJ(string CNPJ)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                   var retorno = await context.Suppliers.SingleOrDefaultAsync(f => f.CNPJ == CNPJ);
                    if (retorno != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha na procura de dados" + ex.Message);
                return false;
            }
            
        }

        public static IEnumerable<Supplier> GetSupplier()
        {
            using (var context = new ApplicationDbContext())
            {
                var suppliers = context.Suppliers.ToList();
                return suppliers;
            }
        }

        public async static Task<bool> IsExistProduct(Product product)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var retorno = await context.Products.SingleOrDefaultAsync(p => p.Name == product.Name 
                                                                              && p.SuplierId == product.SuplierId
                                                                              );
                    if (retorno != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha na procura de dados" + ex.Message);
                return false;
            }

        }
       

    }
}
