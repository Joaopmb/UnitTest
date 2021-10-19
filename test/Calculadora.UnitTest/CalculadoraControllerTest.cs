using Calculadora.WebApi.Controllers;
using Calculadora.WebApi.Model;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Calculadora.UnitTest
{
    public class CalculadoraControllerTest
    {
        public CalculadoraControllerTest() { }

        private CalculadoraController CreateController()
        {
            return new CalculadoraController();
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(50, 30, 80)]
        [InlineData(10, -3, 7)]
        [InlineData(-50, -5, -55)]
        public void Soma_CalculoDeSomatoria_ReturnaSomaComSucesso(int numero1, int numero2, int resultado)
        {
            //Arrange
            Operacao.Request request = new()
            {
                Numero1 = numero1,
                Numero2 = numero2,
            };
            var controller = CreateController();

            //Act
            var actionResult = controller.Soma(request);

            //Assert
            var okObjectResult = actionResult as OkObjectResult;
            Assert.NotNull(okObjectResult);

            Assert.IsType<int>(okObjectResult.Value);
            Assert.Equal(resultado, okObjectResult.Value);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(50, 30, 20)]
        [InlineData(10, -3, 13)]
        [InlineData(-50, -5, -45)]
        public void Soma_CalculoDeSubtracao_ReturnaSubtracaoComSucesso(int numero1, int numero2, int resultado)
        {
            //Arrange
            Operacao.Request request = new()
            {
                Numero1 = numero1,
                Numero2 = numero2,
            };
            var controller = CreateController();

            //Act
            var actionResult = controller.Subtracao(request);

            //Assert
            var okObjectResult = actionResult as OkObjectResult;
            Assert.NotNull(okObjectResult);

            Assert.IsType<int>(okObjectResult.Value);
            Assert.Equal(resultado, okObjectResult.Value);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(50, 30, 1500)]
        [InlineData(10, -3, -30)]
        [InlineData(-50, -5, 250)]
        public void Soma_CalculoDeMultiplicacao_ReturnaMultiplicacaoComSucesso(int numero1, int numero2, int resultado)
        {
            //Arrange
            Operacao.Request request = new()
            {
                Numero1 = numero1,
                Numero2 = numero2,
            };
            var controller = CreateController();

            //Act
            var actionResult = controller.Multiplicacao(request);

            //Assert
            var okObjectResult = actionResult as OkObjectResult;
            Assert.NotNull(okObjectResult);

            Assert.IsType<int>(okObjectResult.Value);
            Assert.Equal(resultado, okObjectResult.Value);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(50, 10, 5)]
        [InlineData(10, -2, -5)]
        [InlineData(-50, -5, 10)]
        public void Soma_CalculoDeDivisao_ReturnaDivisaoComSucesso(int numero1, int numero2, int resultado)
        {
            //Arrange
            Operacao.Request request = new()
            {
                Numero1 = numero1,
                Numero2 = numero2,
            };
            var controller = CreateController();

            //Act
            var actionResult = controller.Divisao(request);

            //Assert
            var okObjectResult = actionResult as OkObjectResult;
            Assert.NotNull(okObjectResult);

            Assert.IsType<int>(okObjectResult.Value);
            Assert.Equal(resultado, okObjectResult.Value);
        }
    }
}
