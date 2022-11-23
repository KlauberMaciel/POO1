using Models;
using System.Runtime.ConstrainedExecution;

internal class Program
{
    static void Main(string[] args)
    {
        Pneu meupneu = new Pneu(16, "Top");

        Carro corcel = new Carro("Chevrolet", "2");
        corcel.LigarDesligar();
        
      

            corcel.Acelerar(500);
            corcel.Frear(500);

        corcel.LigarDesligar();

       corcel.PneuTrazeiroEsquerdo = meupneu;
        
        corcel.Acelerar(500);
        meupneu.Frear(10);
       
        corcel.Exibir();
     
    }
}