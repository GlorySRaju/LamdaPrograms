using System;

namespace LamdaFuncCalculator
{
    class LamdaUsingFun
    {
        static void Main(string[] args)
        {

            Func<int, int, int> addNum = (int firstNumber, int secondNumber)=>
           
                 firstNumber + secondNumber;
           

            Func<int, int, int> subtractNum = (int firstNumber, int secondNumber)=>

                 firstNumber - secondNumber;
            
            Func<int, int, int> productNum = (int firstNumber, int secondNumber)=>
          
                 firstNumber * secondNumber;
            

            Func<int, int, int> divisionNum = (int firstNumber, int secondNumber)=>
            
                 firstNumber / secondNumber;
            

            Calculator(addNum, 10, 3);

            Calculator(subtractNum, 10, 3);

            Calculator(productNum, 10, 3);

            Calculator(divisionNum, 10, 3);

        }
        static void Calculator(Func<int, int, int> cal, int firstNumber, int secondNumber)
        {
            Console.WriteLine(cal(firstNumber, secondNumber));
        }
    }
}
