using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMVC
{
    internal class CalculatorModel
    {
        double firstOperand;
        double secondOperand;
        double result;

        public double LeftOp
        {
            set { firstOperand = value; }
        }

        public double SecondOp
        {
            set { secondOperand = value; }
        }

        public double Result
        {
            get { return result; }
        }

        public void setFirstOperand(double value)
        {
            firstOperand = value;
        }

        public void setSecondOperand(double value)
        {
            secondOperand = value;
        }

        public void PerformAddition()
        {
            result = firstOperand + secondOperand;
        }

        public void PerformSubtraction()
        {
            result = firstOperand - secondOperand;
        }

        public void PerformMultiplication()
        {
            result = firstOperand * secondOperand;
        }

        public void PerformDivition()
        {
            if(secondOperand == 0)
            {
                throw new DivideByZeroException();
            }

            result = firstOperand / secondOperand;
        }
    }
}
