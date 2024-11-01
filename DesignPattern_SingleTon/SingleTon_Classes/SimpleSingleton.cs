using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_SingleTon.SingleTon_Classes
{
    /// <summary>
    /// not Thread-Safe (it doesn't supprt multi thread programs)
    /// </summary>
    public class SimpleSingleton
    {
        private static SimpleSingleton _instance;

        public SimpleSingleton() { }

        public static SimpleSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SimpleSingleton();
            }

            return _instance;
        }
    }
}
