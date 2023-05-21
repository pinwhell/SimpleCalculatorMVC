using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace CalculatorMVC
{
    enum CalculatorInputState
    {
        FIRST_OPERAND,
        SECOND_OPERAND
    }

    internal class CalculatorController
    {
        CalculatorForm mView;
        CalculatorModel mModel;

        char opType;
        string leftOpAcum;
        string rightOpAcum;
        CalculatorInputState state;

        public CalculatorController(CalculatorForm view)
        {
            this.mView = view;
            this.mModel = new CalculatorModel();

            Reset();
        }

        public string getCurrentOperand()
        {
            return state == CalculatorInputState.FIRST_OPERAND ? leftOpAcum : rightOpAcum;
        }

        public void AppendToCurrentOperand(char what)
        {
            if (state == CalculatorInputState.FIRST_OPERAND)
                leftOpAcum += what;
            else 
                rightOpAcum += what;
        }

        public string ComputeFullOperation()
        {
            string fullOperand = leftOpAcum;

            if (opType != (char)0x0)
                fullOperand += opType;

            if (state == CalculatorInputState.FIRST_OPERAND)
                return fullOperand;

            fullOperand += rightOpAcum;

            return fullOperand;
        }

        public string ComputeFullResult()
        {
            return mModel.Result.ToString() + "=";
        }

        static bool IsValidDouble(string dbl)
        {
            double tmpRes;

            return Double.TryParse(dbl, System.Globalization.NumberStyles.AllowDecimalPoint, null, out tmpRes);
        }

        public void HandleReset()
        {
            Reset();
        }

        public void HandleOpTypeChange(char ipntOpType)
        {
            // Handle Edge Case where trying to finish the input to the first operand,
            // without having inputed a valid first operand
            // 1. Handling that the first operand is not empty
            // 2. Handling that the First Operand has a valid value(ex. user can put the precision point as input which is not valid)

            if (leftOpAcum.Equals("") || IsValidDouble(leftOpAcum) == false)
                return;

            opType = ipntOpType;
            state = CalculatorInputState.SECOND_OPERAND;
        }

        public void TryPerform()
        {
            if (leftOpAcum.Equals("") ||
                rightOpAcum.Equals(""))
                return;

            double leftOpVal;
            double rightOpVal;

            if (
                 !Double.TryParse(leftOpAcum, System.Globalization.NumberStyles.AllowDecimalPoint, null, out leftOpVal) ||
                 !Double.TryParse(rightOpAcum, System.Globalization.NumberStyles.AllowDecimalPoint, null, out rightOpVal)
                )
                return;

            mModel.LeftOp = leftOpVal;
            mModel.SecondOp = rightOpVal;

            switch(opType)
            {
                case '+': mModel.PerformAddition(); break;
                case '-': mModel.PerformSubtraction(); break;
                case 'X': mModel.PerformMultiplication(); break;
                case '/': mModel.PerformDivition(); break;

                // We should never get here
                default: return;
            }            
        }

        public void HandleTryAdd(char input)
        {
            if (input.Equals(".") && getCurrentOperand().Contains("."))
                return;

            AppendToCurrentOperand(input);
        }

        public void HandleInput(char input)
        {
            switch(input)
            {
                case 'C': HandleReset(); break;

                case '+':
                case '-':
                case 'X':
                case '/':
                    HandleOpTypeChange(input); 
                    break;

                case '=': TryPerform(); break;

                default: HandleTryAdd(input); break;
            }            
        }

        public void Reset()
        {
            state = CalculatorInputState.FIRST_OPERAND;
            opType = (char)0x0;
            leftOpAcum = "";
            rightOpAcum = "";
        }
    }
}
