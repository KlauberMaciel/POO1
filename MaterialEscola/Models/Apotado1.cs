
namespace Models
{
    public class Apotado1
    {
		private bool lamina;
         private string  marca;
         private string cor;

        public bool Lamina
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

		public Apotado1 ( string _marca, string _cor)
		{
			lamina = true;
			Marca = _marca;
			Cor = _cor;
		
		}

		public void Afiar()
		{

			if (lamina)
			{
                Console.WriteLine("Lapis apontado ;)");

                return;
			}
        }
		public void LaminaVelha()
		{
			lamina = !lamina;
			Console.WriteLine("A Ponta esta velha ");
           
        }

		public void Mostra()
		{
			Console.WriteLine("Lamina: "+ lamina);
			Console.WriteLine("Cor:"+ cor);
			Console.WriteLine("Marca: "+ marca);
		}
	}
}
