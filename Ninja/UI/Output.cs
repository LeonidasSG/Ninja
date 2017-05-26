using System;
using Ninja.Intefaces;

namespace Ninja.UI
{
    public class Output : IOutput
    {
        public void Dump(string data)
        {
            Console.WriteLine(data);
        }

        public void DumpInline(string data)
        {
            Console.Write(data);
        }
    }
}