using NewTalents;

namespace TestNewTalents
{
    public class UnitTest1
    {
         public Calculadora ContruirClasse()
        {
            string data = "16/05/2024";
            var calc = new Calculadora(data);

            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int num1, int num2, int resultado)
        {
            Calculadora calc = ContruirClasse();

            int resultadoCalculadora = calc.Somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int num1, int num2, int resultado)
        {
            Calculadora calc = ContruirClasse();

            int resultadoCalculadora = calc.Multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(6, 5, 1)]
        public void TesteSubtrair(int num1, int num2, int resultado)
        {
            Calculadora calc = ContruirClasse();

            int resultadoCalculadora = calc.Subtrair(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int num1, int num2, int resultado)
        {
            Calculadora calc = ContruirClasse();

            int resultadoCalculadora = calc.Dividir(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TesteDivisaoPorZero()
        {
            Calculadora calc = ContruirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TesteHistorico()
        {
            Calculadora calc = ContruirClasse();

            calc.Somar(2, 2);
            calc.Somar(3, 2);
            calc.Somar(10, 8);
            calc.Somar(23, 7);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}