using System;
using Abstractions.QrCode;
using Wrapper.QrCodeGenerator;

namespace Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new QrCoderGeneratorGenerator() as IGenerator;
            Console.WriteLine(generator.GenerateSvg("www.lovepop.com"));
        }
    }
}
