using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Inmobiliaria.PropertyTypes
{
    internal class Commercial : Property
    {
        public Commercial(string type, string sellerName, string clientName, string address) : base(type, sellerName, clientName, address)
        {
            switch (type)
            {
                case "Torreon":
                    saleAmount = 765000m;
                    break;
                case "Gomez Palacio":
                    saleAmount = 589.098m;
                    break;
                default:
                    throw new ArgumentException("Tipo de bien no existente.");
            }
        }

        public Commercial(string type, string sellerName, string clientName, string address, int months) : base(type, sellerName, clientName, address)
        {
            switch (type)
            {
                case "Torreon":
                    rentAmount = 8500m * months;
                    break;
                case "Gomez Palacio":
                    rentAmount = 4500m * months;
                    break;
                default:
                    throw new ArgumentException("Tipo de bien no existente.");
            }
        }
    }
}
