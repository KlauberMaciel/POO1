using System.Reflection.PortableExecutable;

namespace Models
{
    public class Caneta
    {
        private string cor;
        private string marca;
        private int percentualCarga;
        private string material;
        private bool estourada;
        private bool caida;
        private bool tampada;


        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }


        public int PercentualCarga
        {
            get { return percentualCarga; }
            set { percentualCarga = value; }
        }

        public bool Caida
        {
            get { return caida; }
            set { caida = value; }
        }

        public bool Tampada
        {
            get { return tampada; }
            set { tampada = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public bool Estourada
        {
            get { return estourada; }
            set { estourada = value; }
        }
        public Caneta(string _cor, string _marca, string _material)
        {
            Cor = _cor;
            Marca = _marca;
            PercentualCarga = 100;
            Material = _material;
        }
        public void Escrever(string _texto)
        {
            if (this.Tampada)
            {
                Console.WriteLine("Você não pode escrever com a caneta tampada.");
                return;
            }

            if (this.Caida)
            {
                Console.WriteLine("Antes pegue a caneta do chão.");
                return;
            }

            if (this.Estourada)
            {
                Console.WriteLine("Acaneta está estourada :(");
                return;
            }

            Console.WriteLine(_texto);
            GastaTrinta();
        }
        private void GastaTrinta()
        {
            PercentualCarga -= 10;
        }



        public void Destampar()
        {
            this.Tampada = false;
        }

        public void Tampar()
        {
            this.Tampada = true;
        }

        public void Cair()
        {
            this.Caida = true;
        }

        public void PegarDoChao()
        {
            this.Caida = false;
        }

        public void Estourar()
        {
            this.Estourada = true;
        }



        public void Exibir()
        {
            Console.WriteLine("Cor: " + this.Cor);

            Console.WriteLine("Tampada: " + this.Tampada);
            Console.WriteLine("PercentualCarga: " + this.PercentualCarga);
            Console.WriteLine("Marca: " + this.Marca);
            Console.WriteLine("Material: " + this.Material);


            Console.WriteLine("Caida: " + this.Caida);
            Console.WriteLine("Estourada: " + this.Estourada);
        }
    }
}