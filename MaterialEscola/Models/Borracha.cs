



namespace Models
{
    public class Borracha
    {
		private string marca;
        private string cor;
        private  int  pecentualBorracha;

		public string Marca
		{
			get { return marca; }
			set { marca = value; }
		}
		

		public string Cor
		{
			get { return cor; }
			set { cor = value; }
		}

		

		public  int  PecentualBorracha 
		{
			get { return pecentualBorracha; }
			set { pecentualBorracha = value; }
		}

		public Borracha(string _marca, string _cor, int _pecentualBorracha)
		{
			Marca = _marca;
			Cor = _cor;
			PecentualBorracha = _pecentualBorracha;
		
		}

		public void Apagar()
		{
			if (pecentualBorracha >= 2)
			{
				Console.Clear();
				pecentualBorracha -= 2;
                return;
            }

			if(pecentualBorracha < 2)
			{
				Console.WriteLine("Não foi possível apagar, compre outa borracha. ");
				return;
			}
		}
			public void MostrarBorracha()
		{
			Console.WriteLine("Marca: " + marca);
			Console.WriteLine("Cor: "+ cor);
			Console.WriteLine("Pecentual Da Borracha"+ pecentualBorracha);
		}

	}
}
