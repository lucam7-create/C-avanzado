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
void ShowRepository<T>(IRepository<T> repository)
{
    foreach (var item in repository.GetAll())
    {
        Console.WriteLine(item);
    }
}