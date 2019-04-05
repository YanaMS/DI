using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    class ElectricPetr: IElectric, ICleaner
    {
        public ElectricPetr(ElectricTools electric, Cleaner cleaner)
        {
            _electric = electric;
            _cleaner = cleaner;
        }
        private readonly Cleaner _cleaner;
        private readonly ElectricTools _electric;
        public void CutWires()
        {
            _electric.DoWork("Petr");
        }

        public void CleanFloor()
        {
            _cleaner.CleanFloor("Petr");
        }

    }
}
