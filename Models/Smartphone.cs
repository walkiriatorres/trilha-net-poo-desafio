namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string Imei;
        private double Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }
        public double GetMemoria()
        {
            return Memoria;
        }
        public string GetModelo()
        {
            return Modelo;
        }
        public string GetImei()
        {
            return Imei;
        }
        public void Ligar(string numero)
        {
            try
            {
                if (!Numero.Equals(numero)) {
                Console.WriteLine($"Ligando para o número: {numero}...");
                } else {
                Console.WriteLine($"Não é possível ligar para o próprio número.");
                }
            }
            catch (Exception ex)
            {
                Console.Write($"Ocorreu um erro ao realizar chamada. {ex.Message}");
            }            
        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        public abstract void InstalarAplicativo(string nomeApp, int tamanho);
    }
}
