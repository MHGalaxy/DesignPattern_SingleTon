using DesignPattern_SingleTon.SingleTon_Classes;

namespace DesignPattern_SingleTon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleSingleton simpleSigletonInstanse = SimpleSingleton.GetInstance();
        }
    }
}
