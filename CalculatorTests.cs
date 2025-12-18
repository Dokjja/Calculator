using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Calculator_App;
[TestClass]
public class CalculatorTests
{
    private Calculator calculator;

    [TestInitialize]
    public void TestInitialize()
    {
        calculator = new Calculator();
    }

    // Тесты для корректного отображения знаков и цифр
    [TestMethod]
    public void PressNumber_DisplaysCorrectNumber()
    {
        calculator.PressNumber("5");
        Assert.AreEqual("5", calculator.Display);
    }

    [TestMethod]
    public void PressMultipleNumbers_DisplaysCorrectSequence()
    {
        calculator.PressNumber("1");
        calculator.PressNumber("2");
        calculator.PressNumber("3");
        
        Assert.AreEqual("123", calculator.Display);
    }

    [TestMethod]
    public void AddDecimalPoint_AddsDecimalToNumber()
    {
        calculator.PressNumber("5");
        calculator.AddDecimalPoint();
        calculator.PressNumber("2");
        
        Assert.AreEqual("5.2", calculator.Display);
    }

    // Тесты для обработки ошибок
    [TestMethod]
    public void DivisionByZero_DisplaysError()
    {
        calculator.PressNumber("5");
        calculator.PressOperation("÷");
        calculator.PressNumber("0");
        calculator.Calculate();
        
        Assert.AreEqual("Error", calculator.Display);
    }

    [TestMethod]
    public void DivisionByZero_ResetsAfterError()
    {
        calculator.PressNumber("5");
        calculator.PressOperation("÷");
        calculator.PressNumber("0");
        calculator.Calculate();
        calculator.PressNumber("3");
        
        Assert.AreEqual("3", calculator.Display);
    }

    // Тесты для очистки поля
    [TestMethod]
    public void Clear_ResetsDisplayToZero()
    {
        calculator.PressNumber("123");
        
        calculator.Clear();
        
        Assert.AreEqual("0", calculator.Display);
    }

    [TestMethod]
    public void Backspace_RemovesLastDigit()
    {
        calculator.PressNumber("123");
        calculator.Backspace();
        Assert.AreEqual("12", calculator.Display);
    }

    [TestMethod]
    public void Backspace_WhenOneDigit_ReturnsZero()
    {
        calculator.PressNumber("5");
        
        calculator.Backspace();
      
        Assert.AreEqual("0", calculator.Display);
    }

    // Тесты для операций
    [TestMethod]
    public void Addition_CalculatesCorrectly()
    {
        calculator.PressNumber("5");
        calculator.PressOperation("+");
        calculator.PressNumber("3");
        calculator.Calculate();
      
        Assert.AreEqual("8", calculator.Display);
    }

    [TestMethod]
    public void Subtraction_CalculatesCorrectly()
    {
        // Arrange & Act
        calculator.PressNumber("10");
        calculator.PressOperation("-");
        calculator.PressNumber("3");
        calculator.Calculate();
        
        // Assert
        Assert.AreEqual("7", calculator.Display);
    }

    [TestMethod]
    public void Multiplication_CalculatesCorrectly()
    {
        // Arrange & Act
        calculator.PressNumber("5");
        calculator.PressOperation("×");
        calculator.PressNumber("3");
        calculator.Calculate();
        
        // Assert
        Assert.AreEqual("15", calculator.Display);
    }

    [TestMethod]
    public void Division_CalculatesCorrectly()
    {
        // Arrange & Act
        calculator.PressNumber("10");
        calculator.PressOperation("÷");
        calculator.PressNumber("2");
        calculator.Calculate();
        
        // Assert
        Assert.AreEqual("5", calculator.Display);
    }

    // Тесты для работы с дробями
    [TestMethod]
    public void DecimalNumbers_AdditionCalculatesCorrectly()
    {
        // Arrange & Act
        calculator.PressNumber("5");
        calculator.AddDecimalPoint();
        calculator.PressNumber("5");
        calculator.PressOperation("+");
        calculator.PressNumber("2");
        calculator.AddDecimalPoint();
        calculator.PressNumber("5");
        calculator.Calculate();
        
        // Assert
        Assert.AreEqual("8", calculator.Display);
    }

    [TestMethod]
    public void Division_WithDecimalResult()
    {
        // Arrange & Act
        calculator.PressNumber("1");
        calculator.PressOperation("÷");
        calculator.PressNumber("2");
        calculator.Calculate();
        
        // Assert
        Assert.AreEqual("0.5", calculator.Display);
    }

    // Тесты для работы с процентами
    [TestMethod]
    public void Percent_OfNumber()
    {
        // Arrange
        calculator.PressNumber("50");
        
        // Act
        calculator.Percent();
        
        // Assert
        Assert.AreEqual("0.5", calculator.Display);
    }

    [TestMethod]
    public void Percent_WithOperation()
    {
        // Arrange & Act
        calculator.PressNumber("100");
        calculator.PressOperation("+");
        calculator.PressNumber("10");
        calculator.Percent();
        calculator.Calculate();
        
        // Assert
        Assert.AreEqual("110", calculator.Display);
    }

    // Тесты для возведения в квадрат
    [TestMethod]
    public void Square_CalculatesCorrectly()
    {
        // Arrange
        calculator.PressNumber("5");
        
        // Act
        calculator.Square();
        
        // Assert
        Assert.AreEqual("25", calculator.Display);
    }

    [TestMethod]
    public void Square_OfDecimalNumber()
    {
        // Arrange
        calculator.PressNumber("2");
        calculator.AddDecimalPoint();
        calculator.PressNumber("5");
        
        // Act
        calculator.Square();
        
        // Assert
        Assert.AreEqual("6.25", calculator.Display);
    }

    // Интеграционные тесты
    [TestMethod]
    public void ComplexCalculation_MultipleOperations()
    {
        // Arrange & Act
        calculator.PressNumber("1");
        calculator.PressNumber("0");
        calculator.PressOperation("+");
        calculator.PressNumber("5");
        calculator.Calculate();
        calculator.PressOperation("×");
        calculator.PressNumber("2");
        calculator.Calculate();
        
        // Assert
        Assert.AreEqual("30", calculator.Display);
    }

    [TestMethod]
    public void SequentialCalculations_WorkCorrectly()
    {
        // Arrange & Act
        calculator.PressNumber("5");
        calculator.PressOperation("+");
        calculator.PressNumber("3");
        calculator.Calculate();
        calculator.PressOperation("×");
        calculator.PressNumber("2");
        calculator.Calculate();
        
        // Assert
        Assert.AreEqual("16", calculator.Display);
    }

    [TestMethod]
    public void MultipleDecimalPoints_PreventsDuplicatePoints()
    {
        // Arrange & Act
        calculator.PressNumber("5");
        calculator.AddDecimalPoint();
        calculator.PressNumber("2");
        calculator.AddDecimalPoint(); // Этот вызов должен игнорироваться
        calculator.PressNumber("5");
        
        // Assert
        Assert.AreEqual("5.25", calculator.Display);
    }
}
