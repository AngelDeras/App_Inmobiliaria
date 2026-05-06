using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Inmobiliaria.PropertyTypes
{
    internal class Luxury : Property
    {
        public Luxury(string sellerName, string clientName, string address, string propertyModel) 
            : base("Lujo", sellerName, clientName, address)
        {
            switch (propertyModel)
            {
                case "Cosmopolitan":
                    saleAmount = 1020090m;
                    break;
                case "Venecia":
                    saleAmount = 900050m;
                    break;
                default:
                    throw new ArgumentException($"Este modelo de propiedad es inexistente {propertyModel}.");
            }
        }

        public Luxury(string sellerName, string clientName, string address, string propertyModel, int months)
        : base("Lujo", sellerName, clientName, address)
        {
            switch (propertyModel)
            {
                case "Cosmopolitan":
                    rentAmount = 35000m * months;
                    break;
                case "Venecia":
                    rentAmount = 20500m * months;
                    break;
                default:
                    throw new ArgumentException($"Este modelo de propiedad es inexistente {propertyModel}.");
            }
        }
    }
}
