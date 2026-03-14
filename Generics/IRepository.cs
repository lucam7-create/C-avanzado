using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public interface IRepository<T>
    {
        /// <summary>
        /// model representa el objeto que se va a agregar al repositorio, es de tipo T, lo
        /// que significa que puede ser cualquier tipo de dato que se especifique al implementar
        /// la interfaz. Este método se encarga de agregar el modelo al repositorio, permitiendo así almacenar 
        /// y gestionar datos de manera genérica.
        /// </summary>
        /// <param name="model"></param>
        void Add(T model);
        /// <summary>
        /// IEnumerable<T> es una interfaz que representa una colección de elementos de tipo T que se pueden enumerar.
        /// Su funcion es proporcionar una forma de iterar sobre una colección de objetos de tipo T, permitiendo acceder 
        /// a cada elemento de la colección de manera secuencial.
        /// Este metodo se encarga de devolver todos los elementos almacenados en el repositorio, lo que permite 
        /// obtener una lista completa de los objetos gestionados por la implementación de la interfaz.
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
    }
}
