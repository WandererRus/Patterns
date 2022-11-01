using System.Text;
using System.Threading;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IPirog pirog;
            PirogCherry pirogCherry = new PirogCherry();
            PirogStrawberry ps = new PirogStrawberry();
            pirog = pirogCherry;
            pirog.AddNachinka();
            pirog = ps;
            pirog.AddNachinka();
        }
    }
    interface IPirog 
    {
        void AddNachinka();
    }
    class PirogCherry : IPirog
    {
        public PirogCherry() 
        {
        }
        public void AddNachinka()
        {
            Console.WriteLine("В пирог добавлена вишня");
        }
    }
    class PirogStrawberry : IPirog
    {
        public PirogStrawberry()
        {
        }
        public void AddNachinka()
        {
            Console.WriteLine("В пирог добавлена клубника");
        }
    }
}