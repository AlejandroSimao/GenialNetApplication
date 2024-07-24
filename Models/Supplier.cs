using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenialNetApplication.Models
{
    public class Supplier : Entity
    {
        public string Name { get; set; }


        public string Andress { get; set; }


        public string PhoneNumber { get; set; }

        public string CNPJ { get; set; }

        public string CEP { get; set; }
       // public int ProductId { get; set; }
    }
}
