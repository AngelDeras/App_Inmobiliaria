using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Inmobiliaria.PropertyTypes
{
    internal class Land : Property
    {
        public Land(string sellerName, string clientName, string address, string propertyModel, double area) : base("Terrenos", sellerName, clientName, address)
        {
            switch (propertyModel)
            {
                case "Residencial":
                    saleAmount = (decimal)area * 1590m;
                    break;
                case "Comercial":
                    saleAmount = (decimal)area * 950m;
                    break;
                default:
                    throw new ArgumentException("Tipo de bien no existente.");
            }
        }

        public Land(string sellerName, string clientName, string address, string propertyModel, double area, decimal months) : base("Terrenos", sellerName, clientName, address)
        {
            switch (type)
            {
                case "Residencial":
                    saleAmount = (decimal)area * 890m * months;
                    break;
                case "Comercial":
                    saleAmount = (decimal)area * 569m * months;
                    break;
                default:
                    throw new ArgumentException("Tipo de bien no existente.");
            }
        }
    }
}
