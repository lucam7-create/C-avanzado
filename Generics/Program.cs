using Generics;
var box = new Box<int>(42);
Console.WriteLine(box.GetContent());
var box2 = new Box<string>("Hello, Generics!");
Console.WriteLine(box2.GetContent());
var box3 = new Box<bool>(false);
Console.WriteLine(box3.GetContent());
/// <summary>
/// No hace falta definir el generic ya que estas usando BeerRepository que ya implementa IRepository<string>, por 
/// lo que el tipo de dato se infiere automáticamente como string.
/// </summary>
var beerRepository = new BeerRepository();
beerRepository.Add("Corona");
beerRepository.Add("Heineken");
ShowRepository(beerRepository);
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
///un valor y acepta uno o más parámetros. En este caso, se especifica que el parámetro es de tipo IRepository<string>, lo 
///que significa que el delegado s puede almacenar una referencia a cualquier método que acepte un IRepository<string> como 
///argumento y no devuelva ningún valor. Al asignar ShowRepository a s, se está indicando que s ahora puede ser utilizado para 
///llamar al método ShowRepository con un IRepository<string> como argumento.
///</summary>
Action<IRepository<string>> s = ShowRepository;//
s(beerRepository);
Console.WriteLine("delegate double: "+doubleAdd(1.2,2.5));
Console.WriteLine("delegate int: "+sum(1,2));
Console.WriteLine("delegate string: "+stringConcat("Hello","World"));

delegate T Operation<T>(T element1, T element2);