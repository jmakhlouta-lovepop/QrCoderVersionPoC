using QRCoder;

namespace Wrapper.QrCoder
{
    public class QrCoderGenerator
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