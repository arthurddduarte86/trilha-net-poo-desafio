namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string _numero;
        private string _modelo;
        private string _imei;
        private int _memoria;
        public string Numero 
        {
            get
            {
                return _numero;
            }
            set
            {
                if (value != null)
                {
                    _numero = value;
                }
                else
                {
                    throw new ArgumentException("Numero não pode ser vazio.");
                }
            }
        }
        private string Modelo 
        {
            get
            {
                return _modelo;
            }
            set
            {
                if (value != null)
                {
                    _modelo = value;
                }
                else
                {
                    throw new Exception("Modelo não informado");
                }
            }
        }
        private string IMEI 
        {
            get
            {
                return _imei;
            }
            set
            {
                if (value != null)
                {
                    _imei = value;
                }
                else
                {
                    throw new Exception("Não foi informado o IMEI.");
                }
            } 
        }
        public int Memoria 
        {
            get
            {
                return _memoria;
            }
            set
            {
                if (Convert.ToInt32(value) > 0)
                {
                    _memoria = value;
                }
                else
                {
                    throw new Exception("Valor informado pra memoria?");
                }
            }
        }
        
        
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}