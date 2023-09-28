//Ejercicio 3

string Frase = "MI MAMA ME MIMA, AMO A MI MAMA";

Frase = Frase.ToLower();

string[] Palabras = Frase.Split(' ');

string Resultado = "";

foreach (string i in Palabras)
{
    if (i.Length < 3)
    {
        Resultado += i + "% ";
    }
    else
    {
        Resultado += i + " ";
    }
}
Resultado = Resultado.Trim();

Console.WriteLine(Resultado);