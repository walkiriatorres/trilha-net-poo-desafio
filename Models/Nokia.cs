namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        private double MemoriaDisponivel;      
        private List<string> AplicativosInstalados;

        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            MemoriaDisponivel = memoria;
            AplicativosInstalados = new List<string>();
        }
        public double GetMemoriaDisponivel()
        {
            return MemoriaDisponivel;
        }
        public List<string> GetAplicativosInstalados()
        {
            return AplicativosInstalados;
        }
        public override void InstalarAplicativo(string nomeApp, int tamanho)
        {
            try
            {
                if (MemoriaDisponivel >= tamanho){
                    Console.WriteLine($"Fazendo download do app {nomeApp} na PlayStore...");                    
                    AplicativosInstalados.Add(nomeApp);
                    MemoriaDisponivel -= tamanho;
                    Console.WriteLine($"Download realizado com sucesso. O app {nomeApp} está disponível para uso.");
                } else {
                    double espacoNecessario = tamanho - MemoriaDisponivel;
                    Console.Write($"Não há memória disponível suficiente. Libere {espacoNecessario} GB para realizar o download do {nomeApp}.");
                }
            }
            catch (Exception ex)
            {
                Console.Write($"Ocorreu um erro ao instalar aplicativo. {ex.Message}");
            }
        }
    }
}
