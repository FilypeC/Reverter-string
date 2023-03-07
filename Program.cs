using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe a palavra a ser invertida:");
        string entrada = Console.ReadLine();
        char[] invert = entrada.ToCharArray();
        int inicio = 0;
        int final = invert.Length;
        final = final - 1;
        char temp;

        while (inicio<= final) {
        temp = invert[inicio];
        invert[inicio] = invert[final];
        invert[final] = temp;
        inicio++;
        final--;

        }
        Console.WriteLine(invert);
    }
}
