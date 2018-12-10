using NUnit.Framework;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {       
        [TestFixture]
        public class CalculadoraSimplesTests {

            [Test]
            public void DeveAdicionarDoisNumeros()
            {
                var sut = new CalculadoraSimples();
                var resultado = sut.Adicionar(5, 5);
                Assert.That(resultado, Is.EqualTo(10));

            }

            [Test]
            public void DeveMultiplicarDoisNumeros()
            {
                var sut = new CalculadoraSimples();
                var resultado = sut.Multiplicar(3, 5);
                Assert.That(resultado, Is.EqualTo(15));

            }

            [Test]
            public void DeveDividirDoisNumeros()
            {
                var sut = new CalculadoraSimples();
                var resultado = sut.Dividir(25, 5);
                Assert.That(resultado, Is.EqualTo(5));
            }

            [Test]
            public void DeveDiminuirDoisNumeros()
            {
                var sut = new CalculadoraSimples();
                var resultado = sut.Diminuir(25, 5);
                Assert.That(resultado, Is.EqualTo(20));
            }

        }

    }
}
