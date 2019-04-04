using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    class ElectricVasya: BaseElectric
    {
        public override void CutWires()
        {
            DoWork("Vasya");
        }
    }
}
