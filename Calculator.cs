using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App
{
    public class Calculator : ICalculator
    {
        private readonly CalculatorEngine _engine = new();

        public string Display => _engine.Display;

        public void PressNumber(string number)
        {
            _engine.InputNumber(number);
        }

        public void PressOperation(string operation)
        {
            _engine.SetOperation(operation);
        }

        public void AddDecimalPoint()
        {
            _engine.AddDecimalPoint();
        }

        public void Calculate()
        {
            _engine.Calculate();
        }

        public void Clear()
        {
            _engine.Clear();
        }

        public void Backspace()
        {
            _engine.Backspace();
        }

        public void Percent()
        {
            _engine.Percent();
        }

        public void Square()
        {
            _engine.Square();
        }
    }

}
