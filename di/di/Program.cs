using System;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var example1 = new GenericModel<int,int>();
            calculator
                .Add(example1.WorkElement, example1.OtherElement);
            var example2 = new GenericModel<string,string>();
            calculator
                .Concat(example2.OtherElement, example2.WorkElement);
        }
    }
}
