using System;
using Xunit;
using calculadora.lib;

namespace calculadora.tests
{
    public class CalculadoraTestes
    {
        [Fact]
        public void Soma_Calculadora_RetornarValorInteiroPositivoCorreto()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();
            //Act
            int resultadoSoma = calculadora.Soma(5,2);
            //Assert
            Assert.Equal(7, resultadoSoma);
        }

        [Theory]
        [InlineData(1,9)]
        [InlineData(8,2)]
        [InlineData(5,5)]
        public void Soma_Calculadora_RetornarValor10InteiroPositivo(int primeiroValor, int segundoValor)
        {
            //Arrange
            Calculadora calculadora = new Calculadora();
            //Act
            int resultadoSoma = calculadora.Soma(primeiroValor, segundoValor);
            //Assert
            Assert.Equal(10, resultadoSoma);
        }
    }
}
