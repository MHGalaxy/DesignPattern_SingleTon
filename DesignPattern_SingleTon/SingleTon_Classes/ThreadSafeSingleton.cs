using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_SingleTon.SingleTon_Classes
{
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance;
        

        public ThreadSafeSingleton() { }

        public static ThreadSafeSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ThreadSafeSingleton();
            }
            return _instance;
        }
    }
}
