using System;

Console.WriteLine("Digite o raio do círculo:");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo c1 = new Circulo (raio);

Console.WriteLine(c1.CalcularPerimetro);
Console.WriteLine (c1.CalcularArea);