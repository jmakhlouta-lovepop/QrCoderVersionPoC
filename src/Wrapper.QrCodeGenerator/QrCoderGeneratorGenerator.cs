using Abstractions.QrCode;
using Net.Codecrete.QrCodeGenerator;

namespace Wrapper.QrCodeGenerator
{
    public class QrCoderGeneratorGenerator : IGenerator
    {
        public string GenerateSvg(string input)
        {
            var qr = QrCode.EncodeText("Hello, world!", QrCode.Ecc.Medium);
            return qr.ToSvgString(4);
        }
    }
}