//Ejercicio 2

Console.WriteLine("Ingrese la primera cadena:");
string Cadena1 = Console.ReadLine();

Console.WriteLine("Ingrese la segunda cadena:");
string Cadena2 = Console.ReadLine();

int ResCompareTo = Cadena1.CompareTo(Cadena2);

if (ResCompareTo == 0)
{
    Console.WriteLine("Las cadenas son iguales.");
}
else if (ResCompareTo < 0)
{
    Console.WriteLine("La primera cadena es menor que la segunda.");
}
else
{
    Console.WriteLine("La primera cadena es mayor que la segunda.");
}

bool Iguales = Cadena1.Equals(Cadena2);

if (Iguales)
{
    Console.WriteLine("Las cadenas son iguales.");
}
else
{
    Console.WriteLine("Las cadenas no son iguales.");
}