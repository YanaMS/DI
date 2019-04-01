using System;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new DIContainer().Register<Worker>();
            var b = new DIContainer().Register<Singer>();
        }
    }
}
