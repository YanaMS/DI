using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace DI
{
    class DIContainer
    {
        private readonly List<object> _objects = new List<object>();
        public T Register<T>()where T:new()
        {
            T instance = new T();
            return instance;
        }

        public Worker RegisterWorker()
        {
            Worker instance = new Worker();
            return instance;
        }

        public Singer RegisterSinger()
        {
            Singer instance = new Singer();
            return instance; 
        }
    }
}
