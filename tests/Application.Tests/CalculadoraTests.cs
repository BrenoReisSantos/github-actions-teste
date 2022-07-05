namespace Application.Tests;

public class CalculadoraTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(1, 1, 2)]
    [TestCase(2, 2, 4)]
    [TestCase(5, 5, 10)]
    [TestCase(0, 0, 0)]
    [TestCase(0, 10, 10)]
    [TestCase(-10, 10, 0)]
    [TestCase(-10, 5, -5)]
    public void SomaShouldReturnExpected(int aTest, int bTest, int expectedResult)
    {
        var result = Calculadora.soma(aTest, bTest);
        result.Should().Be(expectedResult);
    }

    [TestCase(1, 1, 1)]
    [TestCase(2, 1, 2)]
    [TestCase(3, 5, 15)]
    [TestCase(0, 0, 0)]
    [TestCase(0, 10, 0)]
    [TestCase(-10, 10, -100)]
    [TestCase(-10, 5, -50)]
    [TestCase(-5, -5, 25)]
    public void MultiplicaShouldReturnExpected(int aTest, int bTest, int expectedResult)
    {
        var result = Calculadora.multiplica(aTest, bTest);
        result.Should().Be(expectedResult);
    }

    [TestCase(1, 1, 0)]
    [TestCase(2, 1, 1)]
    [TestCase(3, 5, -2)]
    [TestCase(0, 0, 0)]
    [TestCase(0, 10, -10)]
    [TestCase(-10, 10, -20)]
    [TestCase(-10, 5, -15)]
    public void SubtraiShouldReturnExpected(int aTest, int bTest, int expectedResult)
    {
        var result = Calculadora.subtrai(aTest, bTest);
        result.Should().Be(expectedResult);
    }

    [TestCase(1, 1, 1)]
    [TestCase(2, 1, 2)]
    [TestCase(3, 5, 0.6)]
    [TestCase(0, 10, 0)]
    [TestCase(0, -10, 0)]
    [TestCase(-10, 5, -2)]
    [TestCase(10, -5, -2)]
    [TestCase(10, 5, 2)]
    [TestCase(1, 3, 0.33)]
    public void DivideShouldReturnExpected(double aTest, double bTest, double expectedResult)
    {
        var result = Calculadora.divide(aTest, bTest);
        result.Should().BeApproximately(expectedResult, 0.01);
    }

    public void DivisionByZeroShouldReturnPositiveInfinity()
    {
        var result = Calculadora.divide(1000, 0);
        result.Should().Be(double.PositiveInfinity);
    }

    public void DivisionByZeroShouldReturnNegativeInfinity()
    {
        var result = Calculadora.divide(-1000, 0);
        result.Should().Be(double.NegativeInfinity);
    }
}
