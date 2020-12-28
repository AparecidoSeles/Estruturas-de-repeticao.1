using System;

namespace atividade._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

            

            Console.WriteLine("Digite sua nota de 0 a 10");
            int resposta = int.Parse(Console.ReadLine());
            
        //    if (resposta >0 && resposta <=10)
        //    {}
          while(resposta <0 || resposta >10)
          {
                Console.WriteLine("Digite sua nota novamente");
                resposta = int.Parse(Console.ReadLine());
           }
        }
    }
}
