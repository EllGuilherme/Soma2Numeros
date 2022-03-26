int primeiron, segundon, soma;

Console.WriteLine("Cálculo da soma entre dois números.\n");

Console.WriteLine("digite seu primeiro numero: ");
primeiron = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("digite seu segundo numero.: ");
segundon =  Convert.ToInt32(Console.ReadLine());

soma = primeiron + segundon;


Console.WriteLine($"\nSoma: {soma}");