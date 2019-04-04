using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    abstract class BaseElectric
    {
        public abstract void CutWires();
        public abstract void CleanFloor();

        protected void DoWork(string name)
        {
            Console.WriteLine($"{name} has cut!");
        }

        protected void CleanFloor(string name)
        {
            Console.WriteLine($"{name} has clean!");
        }
    }
}
