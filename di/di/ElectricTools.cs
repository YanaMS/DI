using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    class ElectricTools
    {
        private readonly Keys _keys = new Keys();
        public void DoWork(string name)
        {
            Console.WriteLine($"{name} has cut!");
        }


    }
}
