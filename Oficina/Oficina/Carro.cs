
namespace Oficina
{
    public class Carro
    {
		private int tanque;
		private bool ligado;
		private int odomento;
		private string marca;
		private int velocidadeAtual;
		private string modelo;
	
	

		public string Modelo

		{
			get { return modelo; }
			set { modelo = value; }
		}


		public int VelocidadeAtual

		{
			get { return velocidadeAtual; }
			set { velocidadeAtual = value; }
		}


		public string Marca

		{
			get { return marca; }
			set { marca = value; }
		}


		public int Odomento
        {
			get { return odomento; }
			set { odomento = value; }
		}

		public bool Ligado

		{
			get { return ligado; }
			set { ligado = value; }
		}


		public int Tanque
		{
			get { return tanque; }
			set { tanque = value; }
		}

	}
}
