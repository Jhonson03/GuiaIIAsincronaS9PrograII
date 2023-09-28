//Ejercicio 1

Console.Write("Ingrese una cadena de caracteres: ");
string cadena = Console.ReadLine();

if (cadena.Length < 25)
{
    cadena = new string('$', 25 - cadena.Length) + cadena;
}

Console.WriteLine($"Cadena resultante: {cadena}");