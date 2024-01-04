using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalculatorNumberVo
    {
        public decimal LastNumber { get; set; } = 0;
        public decimal ResultNumber { get; set; } = 0;

        public string ToStringResult()
        {
            return $"{ResultNumber}";
        }
    }
}
