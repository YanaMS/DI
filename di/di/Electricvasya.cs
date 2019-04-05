using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    class ElectricVasya: IElectric
    {
        public ElectricVasya(ElectricTools electric, bool isReady)
        {
            IsReady = isReady;
            _electric = electric;
            Smoke();
        }
        private int _workCount = 0;
        public bool IsReady { get;}
        private readonly ElectricTools _electric;
        public void CutWires()
        {
            _electric.DoWork("Vasya");
        }
        public void Smoke()
        {
            _workCount = _workCount++;
        }
    }
}
