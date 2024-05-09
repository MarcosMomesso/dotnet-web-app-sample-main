using FluentAssertions;
using webapisample.Domain;
using Xunit;

namespace web_app_sample_tests
{
    public class CadastroTest
    {
        [Fact]
        public void ConfirmaIdentidadeCliente()
        {
            var resultado = Cadastro.ValidaIdentidadeCliente("CodigoCliente e ou objeto a ser validado");
            resultado.Should().Be(true);
        }

        [Fact]
        public static void ConfirmaItegridadeDadosCliente()
        {
            var resultado = Cadastro.ValidaItegridadeDadosEstagio2("    ");
            resultado.Should().Be(true);
        }

         [Fact]
        public static void ConfirmaComplinceRegraCVM3082()
        {
            var resultado = Cadastro.ValidaDadosRegraCVM3082("123456");
            resultado.Should().Be(true);
        }
        
    }
}