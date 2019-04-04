using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    class ElectricPetr: BaseElectric
    {
        public override void CutWires()
        {
            DoWork("Petr");
        }

        public override void CleanFloor()
        {
            CleanFloor("Petr");
        }
    }
}
