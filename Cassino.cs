/******************************************************************************

Jovana Matos
PI04 - NST
16/01/2024 C#
TAREFA 3

*******************************************************************************/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int numeroDasorte = 0;
        int escolha = 0;
        int saldo = 100;
        int aposta = 0;
        string continuar = "S";
        Console.WriteLine("------------------------------------");
        Console.WriteLine("             CASSINO                ");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Você tem um saldo "+ saldo+"€ ");
        
        while (saldo > 0 && continuar.ToLower() == "s") //funçao altera letra para minuscula ou maiuscula
        {
            Console.WriteLine("Quanto quer apostar? ");
            aposta = Convert.ToInt32(Console.ReadLine());
            if (aposta > saldo)
            {
                Console.WriteLine("Não há saldo suficiente :(");
                Console.WriteLine("Seu saldo "+ saldo+"€ ");
            }
            else
            {
            Console.WriteLine("Escolha um numero de 0 - 5: ");
            escolha = Convert.ToInt32(Console.ReadLine());
            if (escolha >5)
            {
                Console.WriteLine("Numero invalido, digite um numero de 0 - 5: ");
            }
            else
            {
            numeroDasorte = rnd.Next(5);
            if (escolha == numeroDasorte)
           {
               saldo = saldo + aposta * 5;
               Console.WriteLine ("Sorteado:"+ numeroDasorte+ " / Aposta: "+ escolha);
               Console.WriteLine ("Parabens seu saldo atual é de "+ saldo+ "€");
        
           } else
           {
               saldo = saldo - aposta;
               Console.WriteLine ("Sorteado:"+ numeroDasorte+ " / Aposta: "+ escolha);
               Console.WriteLine ("Seu saldo atual : "+ saldo);
            if (saldo <1)
               {
                   continuar = "n";
            }else
            {
                    Console.WriteLine ("Quer continuar? [S/N] : ");
                    continuar = Console.ReadLine();
            }
           }
           }
           }
        }
        if (saldo == 0)
        {
            Console.WriteLine ("****************************");
            Console.WriteLine("   Você Perdeu tudo! Xau :("  );
            Console.WriteLine ("****************************");
        }
        else
        {
            Console.WriteLine ("****************************************");
            Console.WriteLine ("Seu "+ saldo + "€ Volte sempre!");
            Console.WriteLine ("****************************************");
        }
          
            
        
       
    }
}
     