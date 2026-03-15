using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Drink
    {
        private double _quantity;
        public double Quantity//propiedad Quantity que devuelve el valor de _quantity, solo te permite obtener el valor
        {
            get => _quantity;
        }
        /// <summary>
        /// Creamos un constructor que reciba ese Quantity en su creacion 
        /// </summary>
        public Drink(double quantity)
        {
            _quantity = quantity;
        }
    }
}
