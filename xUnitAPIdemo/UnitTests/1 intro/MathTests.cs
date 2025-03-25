using Xunit;
using xUnitAPIdemo.BusinessLogic;
public class MathTests
{
    Mathematics math = new Mathematics();

    [Fact]
    public void ShouldAddTwoNumbers()
    {
        // Arrange
        int a = 3;
        int b = 5;

        // Act
        int result = a + b;

        // Assert
        Assert.Equal(8, result); // Check if the result is as expected
    }

    [Fact]
    public void ShouldAddTwoDoubleNumbers()
    {
        double a = 4.5;
        double b = 5.5;

        double result = math.AddTwoDoubleNumbers(a, b);

        // Assert
        Assert.Equal(10, result); // Check if the result is as expected
    }

    [Fact]
    public void ShouldAddDoubleAndIntNumbers()
    {
        double a = 4.5;
        int b = 5;

        double result = math.AddDoubleAndInt(a, b);

        // Assert
        Assert.Equal(9.5, result); // Check if the result is as expected
    }

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-1, 1, 0)]
    [InlineData(10, 20, 30)]
    public void Add_ShouldReturnCorrectSum(int a, int b, int expected)
    {
        // Arrange
        var calculator = new Mathematics();

        // Act
        var result = calculator.AddTwoIntNumbers(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}

