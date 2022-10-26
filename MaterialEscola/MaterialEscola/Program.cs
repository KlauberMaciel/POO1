using Models;

internal class Progran
{

   private static void Main(string[] args )
    {
        Models.Caneta caneta = new Models.Caneta("Azul","Fb","Madeira");
       caneta.Escrever("oi/");

        
        Lapis lapis = new Lapis("2B");
        lapis.QuebrarPonta();
        lapis.Apontar();
        lapis.Escrever("Teste");
        
    }
}