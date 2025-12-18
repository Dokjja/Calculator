using Calculator;
using System.Windows.Forms;

namespace Calculator_App;

public partial class CalculatorForm : Form
{
    private readonly ICalculator _calculator;

    public CalculatorForm()
    {
        InitializeComponent();

        _calculator = new Calculator();

        BindButtons();
        UpdateDisplay();
    }

    // Назначение: привязка кнопок к обработчикам
    private void BindButtons()
    {
        btnZero.Click += (_, _) => PressNumber("0");
        btnOne.Click += (_, _) => PressNumber("1");
        btnTwo.Click += (_, _) => PressNumber("2");
        btnThree.Click += (_, _) => PressNumber("3");
        btnFour.Click += (_, _) => PressNumber("4");
        btnFive.Click += (_, _) => PressNumber("5");
        btnSix.Click += (_, _) => PressNumber("6");
        btnSeven.Click += (_, _) => PressNumber("7");
        btnEight.Click += (_, _) => PressNumber("8");
        btnNine.Click += (_, _) => PressNumber("9");

        btnAdd.Click += (_, _) => PressOperation("+");
        btnSub.Click += (_, _) => PressOperation("-");
        btnMultiply.Click += (_, _) => PressOperation("×");
        btnDevide.Click += (_, _) => PressOperation("÷");

        btnEqual.Click += (_, _) =>
        {
            _calculator.Calculate();
            UpdateDisplay();
        };

        btnColumn.Click += (_, _) =>
        {
            _calculator.AddDecimalPoint();
            UpdateDisplay();
        };

        btnClearAll.Click += (_, _) =>
        {
            _calculator.Clear();
            UpdateDisplay();
        };

        btnDelete.Click += (_, _) =>
        {
            _calculator.Backspace();
            UpdateDisplay();
        };

        btnPercent.Click += (_, _) =>
        {
            _calculator.Percent();
            UpdateDisplay();
        };

        btnPower.Click += (_, _) =>
        {
            _calculator.Square();
            UpdateDisplay();
        };
    }

    // Назначение: ввод цифры
    private void PressNumber(string number)
    {
        _calculator.PressNumber(number);
        UpdateDisplay();
    }

    // Назначение: ввод операции
    private void PressOperation(string operation)
    {
        _calculator.PressOperation(operation);
        UpdateDisplay();
    }

    // Назначение: обновление экрана
    private void UpdateDisplay()
    {
        richTextBox1.Text = _calculator.Display;
    }
}
