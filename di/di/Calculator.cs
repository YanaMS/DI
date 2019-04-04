using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI
{
    class Calculator
    {
        public GenericModel<int,int> Add(int x, int y)
        {
            var add = x + y;
            var multiply = x * y;
            return new GenericModel<int, int>
            {
                OtherElement = add,
                WorkElement = multiply
            };
        }

        public GenericModel<string,string> Concat(string a, string b)
        {
            var concat = a + b;
            var reverse = a.Reverse().ToString();
            return new GenericModel<string, string>
            {
                OtherElement = concat,
                WorkElement = reverse

            };
        }
    }
}
