using System.Globalization;

namespace Calculator_App
{
    

    public class CalculatorEngine
    {
        // Левый операнд для бинарных операций
        private double? _leftOperand;

        // Текущая операция
        private string? _operation;

        // Флаг начала нового ввода
        private bool _isNewInput;

        // Флаг ошибки (деление на ноль)
        private bool _hasError;

        // Текущее отображаемое значение
        public string Display { get; private set; } = "0";

        // Назначение: обработка ввода цифр
        public void InputNumber(string number)
        {
            if (_hasError)
            {
                Reset();
            }

            if (_isNewInput || Display == "0")
            {
                Display = number;
                _isNewInput = false;
            }
            else
            {
                Display += number;
            }
        }

        // Назначение: добавление десятичной точки
        public void AddDecimalPoint()
        {
            if (_hasError)
                return;

            if (!Display.Contains('.'))
            {
                Display += ".";
            }
        }

        // Назначение: установка операции
        public void SetOperation(string operation)
        {
            if (_hasError)
                return;

            _leftOperand = Parse(Display);
            _operation = operation;
            _isNewInput = true;
        }

        // Назначение: выполнение вычисления
        public void Calculate()
        {
            if (_hasError || _operation == null || _leftOperand == null)
                return;

            double rightOperand = Parse(Display);

            try
            {
                double result = _operation switch
                {
                    "+" => _leftOperand.Value + rightOperand,
                    "-" => _leftOperand.Value - rightOperand,
                    "×" => _leftOperand.Value * rightOperand,
                    "÷" => rightOperand == 0
                        ? throw new DivideByZeroException()
                        : _leftOperand.Value / rightOperand,
                    _ => rightOperand
                };

                Display = Format(result);
                _leftOperand = result;
                _isNewInput = true;
            }
            catch
            {
                Display = "Error";
                _hasError = true;
            }
        }

        // Назначение: полный сброс калькулятора
        public void Clear()
        {
            Reset();
            Display = "0";
        }

        // Назначение: удаление последнего символа
        public void Backspace()
        {
            if (_hasError)
                return;

            if (Display.Length > 1)
            {
                Display = Display[..^1];
            }
            else
            {
                Display = "0";
            }
        }

        // Назначение: вычисление процентов
        public void Percent()
        {
            if (_hasError)
                return;

            double value = Parse(Display);
            Display = Format(value / 100);
        }

        // Назначение: возведение числа в квадрат
        public void Square()
        {
            if (_hasError)
                return;

            double value = Parse(Display);
            Display = Format(value * value);
            _isNewInput = true;
        }

        private void Reset()
        {
            _leftOperand = null;
            _operation = null;
            _isNewInput = false;
            _hasError = false;
        }

        private static double Parse(string value) =>
            double.Parse(value, CultureInfo.InvariantCulture);

        private static string Format(double value) =>
            value.ToString(CultureInfo.InvariantCulture);
    }

}
