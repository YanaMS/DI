using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    class GenericModel<TParameter,KParameter>
    {
        public string Message { get; set; }
        public TParameter WorkElement { get; set; }
        public KParameter OtherElement { get; set; }


    }
}
