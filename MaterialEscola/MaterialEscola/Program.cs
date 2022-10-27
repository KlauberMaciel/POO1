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

        Models.Apotado1 op = new Models.Apotado1("oi", "azul", 100);
        op.Afiar();
       op.LaminaVelha();
        op.MostraApo();

       
    }
} //Models.Borracha oop = new Models.Borracha("Borracha", "azul", 100);
       //oop.Apagar();