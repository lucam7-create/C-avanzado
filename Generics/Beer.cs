using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Beer: Drink, IInfo
    {
        private string _name;
        public string Name//Te permite obtener el valor de _name, pero no te permite modificarlo, ya que no tiene un setter
        {
            get => _name;
        }
        public Beer(string name, double quantity) : base(quantity)
        {
            _name = name;
        }
        public string GetInfo()
        {
            return $"La cerveza {Name} tiene una cantidad de {Quantity} ml.";
        }

    }
}
