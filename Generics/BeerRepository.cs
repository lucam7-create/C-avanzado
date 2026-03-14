using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class BeerRepository: IRepository<string>
    {
        private string[] _beers;
        private int _index;
        private const int QUANTITY = 10;
        public BeerRepository()
        {
            _beers = new string[QUANTITY];
            _index = 0;
        }
        /// <summary>
        /// Este metodo se encarga de agregar una cerveza al repositorio. Recibe un parámetro 
        /// de tipo string que representa el nombre de la cerveza a agregar.
        /// </summary>
        /// <param name="beer"></param>
        public void Add(string beer)//al deifinir una variable dentro de un metodo, esta variable es local a ese método, lo que significa que solo existe y es accesible dentro de ese método.
        {
            /// <summary>
            /// este if se encarga de verificar si el índice actual es menor que la cantidad 
            /// máxima de cervezas permitidas en el repositorio (QUANTITY).
            /// Y si se cumple la condición, se agrega la cerveza al arreglo _beers en la posición indicada 
            /// por _index, y luego se incrementa el índice para la próxima adición.
            /// Como _index se incrementa después de agregar la cerveza, el próximo elemento se agregará en la siguiente posición del arreglo, 
            /// asegurando que no se sobrescriban las cervezas ya almacenadas y que no se exceda la capacidad del repositorio.
            /// <summary>
            if (_index < QUANTITY)
            {
                _beers[_index++] = beer;

            }
        }
        /// <summary>
        /// Este método se encarga de devolver todas las cervezas almacenadas en el repositorio.
        /// Muestra el uso de la interfaz IEnumerable<string>, que permite iterar sobre la colección
        /// de cervezas almacenadas en el arreglo _beers.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetAll()=> _beers;
    }
}
