using System;
using Wrapper.QrCoder;

namespace Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new QrCoderGenerator();
            Console.WriteLine(generator.GenerateSvg("www.lovepop.com"));
        }
    }
}
