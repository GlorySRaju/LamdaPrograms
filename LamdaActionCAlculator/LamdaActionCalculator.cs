using System;

namespace LamdaActionCAlculator
{
    class LamdaActionCalculator
    {
        static void Main(string[] args)
        {
            Action<int, int> addNum = (firstNumber, secondNumber)=>
 
                Console.WriteLine(firstNumber + secondNumber);
           

            Action<int, int> subtractNum =  (firstNumber, secondNumber)=>
            
                Console.WriteLine(firstNumber - secondNumber);
            

            Action<int, int> productNum = (firstNumber, secondNumber)=>
            
                Console.WriteLine(firstNumber * secondNumber);
            

            Action<int, int> divisionNum = (firstNumber, secondNumber)=>
           
                Console.WriteLine(firstNumber / secondNumber);
            

            Calculator(addNum += subtractNum += productNum += divisionNum, 10, 3);


        }
        static void Calculator(Action<int, int> cal, int firstNumber, int secondNumber)
        {
            cal(firstNumber, secondNumber);
        }
    }
}
