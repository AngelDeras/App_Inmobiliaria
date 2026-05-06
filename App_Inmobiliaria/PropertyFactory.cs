using App_Inmobiliaria.PropertyTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Inmobiliaria
{
    internal static class PropertyFactory
    {
        public static Property Create(string type, string sellerName, string clientName, string address, string propertyModel, int months, double area, bool isSale)
        {
            switch (type)
            {
                case "Lujo":
                    return isSale ? new Luxury(sellerName, clientName, address, propertyModel) : new Luxury(sellerName, clientName, address, propertyModel, months);
                case "Comerciales":
                    return isSale ? new Commercial(sellerName, clientName, address, propertyModel) : new Commercial(sellerName, clientName, address, propertyModel, months);
                case "Terrenos":
                    return isSale ? new Land(sellerName, clientName, address, propertyModel, area) : new Land(sellerName, clientName, address, propertyModel, area, months);
                default: throw new ArgumentException($"Tipo de bien no existente {type}.");
            }
        }
    }
}
