using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_SingleTon.SingleTon_Classes
{
    /// <summary>
    /// seald: inheritance is not allowed, it is only instantiated
    /// </summary>
    public sealed class ThreadSafeSingleton 
    {
        private static volatile ThreadSafeSingleton _instance;
        private static object _lock = new object();

        // Private constructor to prevent direct instantiation
        private ThreadSafeSingleton() { }

        public static ThreadSafeSingleton GetInstance()
        {
            if (_instance == null)// this outer condition is for next threads that don't need to lock.(optional)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ThreadSafeSingleton();
                    }
                }
            }

            return _instance;
        }

        public string NameProperty { get; set; }    
    }
}
