

namespace Models
{
   public class Caderno
    {
		private int quantidadeFolha;
        private int quantidadeMateria;
        private string marca;
		public int QuantidadeFolha
		{
			get { return quantidadeFolha; }
			set { quantidadeFolha = value; }
		}
		

		public int QuantidadeMateria
		{
			get { return quantidadeMateria; }
			set { quantidadeMateria = value; }
		}
		

		public string Marca
		{
			get { return marca; }
			set { marca = value; }
		}

		public Caderno(int _quantidadeFolha, int _quantidadeMateria, string _marca)
		{
			QuantidadeFolha = _quantidadeFolha;
			QuantidadeMateria = _quantidadeMateria;
			Marca = _marca;
			
		}

		public void RasgaFolha()
		{
			if (quantidadeFolha > 0)
			{
				QuantidadeFolha = quantidadeFolha - 1;
                return;
            }
			if (quantidadeMateria <= 0)
			{
				Console.WriteLine("O seu caderno esta sem folha :(");
                return;
            }
		}

	}
}
