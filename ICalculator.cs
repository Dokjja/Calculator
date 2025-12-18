using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App
{
    public interface ICalculator
    {
        string Display { get; }

        void PressNumber(string number);
        void PressOperation(string operation);
        void AddDecimalPoint();
        void Calculate();
        void Clear();
        void Backspace();
        void Percent();
        void Square();
    }

}
