using Abstractions.QrCode;
using QRCoder;

namespace Wrapper.QrCoder
{
    public class QrCoderGenerator : IGenerator
    {
        public string GenerateSvg(string input)
        {
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new SvgQRCode(qrCodeData);
            return qrCode.GetGraphic(20);
        }
    }
}