using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    class TiotiaLena: ICleaner
    {
        private Cleaner _cleaner;

        public TiotiaLena(Cleaner cleaner)
        {
            _cleaner = cleaner;

        }

        public void CleanFloor()
        {
            Console.WriteLine("Tiotia Lena has clean!");
        }
    }
}
