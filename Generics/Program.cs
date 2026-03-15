using Generics;
var box = new Box<int>(42);
//Console.WriteLine(box.GetContent());
var box2 = new Box<string>("Hello, Generics!");
//Console.WriteLine(box2.GetContent());
var box3 = new Box<bool>(false);
//Console.WriteLine(box3.GetContent());
/// <summary>
/// No hace falta definir el generic ya que estas usando BeerRepository que ya implementa IRepository<string>, por 
/// lo que el tipo de dato se infiere automáticamente como string.
/// </summary>
var beerRepository = new BeerRepository();
beerRepository.Add("Corona");
beerRepository.Add("Heineken");
//ShowRepository(beerRepository);
/// <summary>
/// Este método se encarga de mostrar el contenido de un repositorio genérico. Recibe un parámetro de tipo IRepository<T>
/// </summary>
void ShowRepository<T>(IRepository<T> repository)//coidgo 1
{
    foreach (var item in repository.GetAll())
    {
        Console.WriteLine(item);
    }
}
/// <summary>
/// Creamos una funcion que restrinja su generic a la clase Drink, solamente los
/// generics pueden ser de la clase Drink o sus derivados, esto
/// se logra con la palabra reservada where T : Drink
/// </summary>
void ShowQuantity<T>(T drink) where T : Drink
{ 
        Console.WriteLine(drink.Quantity);
    
}
void ShowInfo<T>(T element) where T : IInfo
{
    Console.WriteLine(element.GetInfo());
}

/// <summary>
/// Este proceso se encarga de definir una función lambda que realiza una operación de suma entre dos números enteros.
/// El delegate Operation<T> es un tipo de delegado genérico que acepta dos parámetros del mismo tipo T y devuelve un 
/// valor del mismo tipo T. En este caso, se especifica que el tipo T es int, lo que significa que la función lambda 
/// toma dos enteros como entrada y devuelve un entero como resultado de la suma. Finalmente, se llama a la función lambda
/// con los valores 1 y 2, y se imprime el resultado en la consola, que será 3.
///</summary>
Operation<int> sum = (a, b) => a + b;
Operation<double> doubleAdd = (a, b) => a + b;
Operation<string> stringConcat = (a, b) => a +" "+ b;
///<summary>
///Esto es igual al codigo 1, ya que Action es un tipo de delegado que representa un método que no devuelve 
///un valor y acepta uno o más parámetros. En este caso, se espe cifica que el parámetro es de tipo IRepository<string>, lo 
///que significa que el delegado s puede almacenar una referencia a cualquier método que acepte un IRepository<string> como 
///argumento y no devuelva ningún valor. Al asignar ShowRepository a s, se está indicando que s ahora puede ser utilizado para 
///llamar al método ShowRepository con un IRepository<string> como argumento.
///</summary>
Action<IRepository<string>> s = ShowRepository;//
//s(beerRepository);
//Console.WriteLine("delegate double: "+doubleAdd(1.2,2.5));
//Console.WriteLine("delegate int: "+sum(1,2));
//Console.WriteLine("delegate string: "+stringConcat("Hello","World"));

var drink = new Drink(500);
var beer = new Beer("Corona", 330);
/// <summary>
/// drink es un candidato ya que procede la clase Drink, por lo que se puede usar como argumento para el método ShowQuantity, que 
/// espera un tipo genérico T restringido a la clase Drink o sus derivados. Al pasar drink como argumento, se
/// cumple la restricción y se puede acceder a la propiedad Quantity dentro del método ShowQuantity 
/// para mostrar su valor en la consola.
/// </summary>
ShowQuantity(drink);
/// <summary>
/// Como Beer deriva de Drink, también es un candidato válido para el método ShowQuantity. 
/// Al pasar beer como argumento, se cumple la restricción
/// </summary>
ShowQuantity(beer);
/// <summary>
/// beer es un candidato válido para el método ShowInfo, ya que implementa la interfaz IInfo. 
/// Al pasar beer como argumento, se cumple la restricción.
/// Recordemos las reglas de la restriccion where T : IInfo, que establece que el tipo 
/// genérico T debe implementar la interfaz IInfo y como beer
/// implementa esa interfaz, se puede usar como argumento para el método ShowInfo, lo
/// que permite acceder al método GetInfo() definido en la interfaz y mostrar la información de la cerveza en la consola.
/// </summary>

ShowInfo(beer);

delegate T Operation<T>(T element1, T element2);
