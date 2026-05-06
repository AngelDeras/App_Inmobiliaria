using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Inmobiliaria.PropertyTypes
{
    internal class Luxury : Property
    {
        public Luxury(string type, string sellerName, string clientName, string address) 
            : base(type, sellerName, clientName, address)
        {
            switch (type)
            {
                case "Cosmopolitan":
                    saleAmount = 1020090m;
                    break;
                case "Venecia":
                    saleAmount = 900050m;
                    break;
                default:
                    throw new ArgumentException("Tipo de bien no existente.");
            }
        }

        public Luxury(string type, string sellerName, string clientName, string address, int months)
            : base(type, sellerName, clientName, address)
        {
            switch (type)
            {
                case "Cosmopolitan":
                    rentAmount = 35000m * months;
                    break;
                case "Venecia":
                    rentAmount = 20500m * months;
                    break;
                default:
                    throw new ArgumentException("Tipo de bien no existente.");
            }
        }
    }
}
