using EjercicioInterfaces;

Implementacion implementacion = new Implementacion();

Console.WriteLine("Ingrese el primer numero: ");
bool n1 = double.TryParse(Console.ReadLine(), out implementacion.numero1);
Console.WriteLine("Ingrese el segundo numero: ");
bool n2 = double.TryParse(Console.ReadLine(), out implementacion.numero2);
Console.WriteLine();

if (n1 && n2)
{
    if (implementacion.numero2 != 0 && implementacion.numero2 != 0)
    {
        implementacion.Imprimir();
    }
    else
    {
        Console.WriteLine("El primer y/o el segundo valor no puede ser cero");
    }
}
else
{
    Console.WriteLine("Uno de los valores ingresados no tiene el formato correcto");
}
