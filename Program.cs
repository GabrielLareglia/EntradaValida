Console.WriteLine("Entrada Válida");
Console.WriteLine();

int numeroDigitado = -1;

while (numeroDigitado < 0 || numeroDigitado > 9)
{
    Console.Write("Digite um número entre 1 e 9 (ou digite 0 para cancelar): ");
    numeroDigitado = Convert.ToInt32(Console.ReadLine());
}

if (numeroDigitado == 0)
{
    Console.WriteLine("Operação cancelada.");
    Console.WriteLine();
}
else
{
    Console.WriteLine($"Número selecionado = {numeroDigitado}");
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Volte sempre!");
Console.ReadKey();

Console.Clear();