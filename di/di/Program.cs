using System;
using System.Collections.Generic;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            //var calculator = new Calculator();
            //var example1 = new GenericModel<int,int>();
            //calculator
            //    .Add(example1.WorkElement, example1.OtherElement);
            //var example2 = new GenericModel<string,string>();
            //calculator
            //    .Concat(example2.OtherElement, example2.WorkElement);
            ElectricTools tools = new ElectricTools(); 
            Cleaner clean = new Cleaner();

            List<IElectric> electrics = new List<IElectric>()
            {
                new ElectricPetr(tools, clean),
                new ElectricVasya(tools, true)
            };
            foreach (var electric in electrics)
            {
                electric.CutWires();
               
            }
            List<ICleaner> cleaners = new List<ICleaner>()
            {
                new ElectricPetr(tools,clean),
                new TiotiaLena(clean)
            };
            foreach (var item in cleaners)
            {
                item.CleanFloor();
            }

        }
    }
}
