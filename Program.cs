using System;

class Program
{
    static void Main(string[] args)
    {
        int contador = 5; 
        string separador = new string('=', 50);
        string nomeJogo = "Bem vindo ao programa Segredo\nVocê tem 5 tentativas pra adivinhar a palavra certa";
        Console.WriteLine(separador);
        Console.WriteLine(nomeJogo);
        
        
        while (contador > 0)
        {
            Console.WriteLine("Escreva a palavra secreta: ");
            string senha = Console.ReadLine();
            
            
            if (senha == "programador")
            {
                Console.WriteLine("Parabéns você acertou");
                break; 
            }
            else
            {
                Console.WriteLine("Tente novamente");
                contador--; 
                Console.WriteLine($"Você tem {contador} tentativas restantes");
            }
        }
        
        
        if (contador == 0)
        {
            Console.WriteLine("Suas tentativas acabaram. A palavra secreta era 'programador'.");
        }
    }
}