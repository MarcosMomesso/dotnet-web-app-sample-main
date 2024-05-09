using FluentAssertions;
using webapisample.Domain;
using Xunit;

namespace web_app_sample_tests
{
    public class PromotestatusTest
    {

        [Fact]
        public static void ClassificaTargeScore()
        {
            var resultado = promotestatus.GetTargetstatus(90,7);
            resultado.Should().BeGreaterThanOrEqualTo(10);
        }
    }
}