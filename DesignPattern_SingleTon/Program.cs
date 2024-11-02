using DesignPattern_SingleTon.SingleTon_Classes;

namespace DesignPattern_SingleTon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleSingleton simpleSigletonInstanse = SimpleSingleton.GetInstance();

            ThreadSafeSingleton threadSafeSingleton = ThreadSafeSingleton.GetInstance();
            ThreadSafeSingleton threadSafeSingleton_2 = ThreadSafeSingleton.GetInstance();

            threadSafeSingleton.NameProperty = "MHGalaxy";
            Console.WriteLine(threadSafeSingleton_2.NameProperty); // It'll write "MHGalaxy"
        }
    }
}
