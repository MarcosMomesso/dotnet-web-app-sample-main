namespace webapisample.Domain
{
    public class Cadastro
    {

        public static bool ValidaIdentidadeCliente(string dados) => dados.StartsWith("CodigoCliente");

        public static bool ValidaItegridadeDadosEstagio2(string dados) => string.IsNullOrWhiteSpace(dados);

        public static bool ValidaDadosRegraCVM3082(string dados) => int.TryParse(dados, out _);
    }
}

