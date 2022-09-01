using Wrapper.QrCodeGenerator;

var generator = new QrCoderGeneratorGenerator();
Console.WriteLine(generator.GenerateSvg("www.lovepop.com"));