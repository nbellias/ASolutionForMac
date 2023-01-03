using ASolutionForMac.MyClassLibrary;

namespace ASolutionForMac.MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyServices aService = new MyServices();
            aService.PrintHelloWorld();
        }
    }
}