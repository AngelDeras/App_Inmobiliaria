using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Inmobiliaria.PropertyTypes
{
    internal class Commercial : Property
    {
        public Commercial(string sellerName, string clientName, string address, string propertyModel) : base("Comerciales", sellerName, clientName, address)
        {
            switch (propertyModel)
            {
                case "Torreon":
                    saleAmount = 765000m;
                    break;
                case "Gomez Palacio":
                    saleAmount = 589098m;
                    break;
                default:
                    throw new ArgumentException($"Este modelo de propiedad es inexistente {propertyModel}.");
            }
        }

        public Commercial(string sellerName, string clientName, string address, string propertyModel, int months) : base("Comerciales", sellerName, clientName, address)
        {
            switch (propertyModel)
            {
                case "Torreon":
                    rentAmount = 8500m * months;
                    break;
                case "Gomez Palacio":
                    rentAmount = 4500m * months;
                    break;
                default:
                    throw new ArgumentException($"Este modelo de propiedad es inexistente {propertyModel}.");
            }
        }
    }
}
