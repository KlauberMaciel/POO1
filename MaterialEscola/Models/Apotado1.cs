
namespace Models
{
    public class Apotado1
    {
		private int lamina;
         private string  marca;
         private string cor;

        public int Lamina
        {
			get { return lamina; }
			set { lamina = value; }
		}
		

		public string  Marca
		{
			get { return marca; }
			set { marca = value; }
		}

		

		public string Cor
		{
			get { return cor; }
			set { cor = value; }
		}

		public Apotado1 ( string _marca, string _cor,int _lamina)
		{
			Marca = _marca;
			Cor = _cor;
		    lamina = _lamina;
		}

		public void Afiar()
		{

			if (lamina>0)
			{
                Console.WriteLine("Lapis apontado ;)");
				lamina -= 2;
				
                return;
			}
        }
		public void LaminaVelha()
		{
			
				lamina = 0;
				Console.WriteLine("A Lamina esta velha ");
                return;
            
           
        }
		public void LaminaNova()
		{
			lamina = 100;
			Console.WriteLine("Lamina Nova. ");
            return;
        }

		public void MostraApo()
		{
			Console.WriteLine("Lamina: "+ lamina);
			Console.WriteLine("Cor:"+ cor);
			Console.WriteLine("Marca: "+ marca);
		}
	}
}
