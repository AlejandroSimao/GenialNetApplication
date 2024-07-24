using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenialNetApplication.Events.Validations.Supplier
{
    public class DataValidation
    {
        public static bool IsValidSupplier(string nome, string CPNJ, string Phone, string CEP, string Andress)
        {
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(CPNJ) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(CEP) || string.IsNullOrEmpty(Andress))
                return false;

            return true;
        }

        public static bool IsValidProduct(string name, string brand, string Description,decimal price, int SupplierId ) 
        {
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(Description) || price == 0 || SupplierId == -1)
                return false;

            return true;
        }
    }
}
