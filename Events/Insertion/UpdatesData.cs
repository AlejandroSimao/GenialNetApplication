using GenialNetApplication.Events.Searchs;
using GenialNetApplication.Models;
using GenialNetApplication.Models.Enums;
using GenialNetApplication.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenialNetApplication.Events.Insertion
{
    public class UpdatesData
    {
        public async static Task<bool> UpdateProduct(int id,string columnName, string newvalue)
        {
            try
            {

                using (var context = new ApplicationDbContext())
                {
                    var product = context.Products.Find(id);
                    if (product != null)
                    {
                        switch (columnName)
                        {
                            case "Nome do produto":
                                product.Name = newvalue;
                                break;
                            case "Preço do produto":
                                product.Price = Convert.ToDecimal(newvalue);
                                break;
                            case "Marca do produto":
                                product.Brand = newvalue;
                                break;
                            case "Descrição do produto":
                                product.Description = newvalue;
                                break;
                            case "Unidade de medida do produto":
                                product.UnitMeasurement = (UnitMeasurement)Enum.Parse(typeof(UnitMeasurement), newvalue);
                                break;
                        }
                            context.Products.Update(product);
                        await context.SaveChangesAsync();

                        return true;
                    }
                    MessageBox.Show("Falha ao atualizar");
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
