using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Inmobiliaria
{
    internal class Property
    {
        public string Type { get; set; }
        public string SellerName { get; set; }
        public string ClientName { get; set; }
        public string Address { get; set; }

        protected decimal saleAmount;
        protected decimal rentAmount;

        public Property(string type, string sellerName, string clientName, string address)
        {
            Type = type;
            SellerName = sellerName;
            ClientName = clientName;
            Address = address;
        }

        // Funciones flecha, asi lo empezare a hacer en proyectos que apliquen
        public decimal CalculateSale() => saleAmount;
        public decimal CalculateRent() => rentAmount;
    }
}
