namespace MCD.test;

public class UnitTest1
{
    [Fact]
    public void CalcularMCD_12Y8_DebeRetornar4()
    {
        int result = MCDCalculator.CalculateMCD(12, 8);

        Assert.Equal(4, result);
    }

    [Fact]
    public void CalcularMCD_20Y15_DebeRetornar5()
    {
        int result = MCDCalculator.CalculateMCD(20, 15);

        Assert.Equal(5, result);
    }
}

