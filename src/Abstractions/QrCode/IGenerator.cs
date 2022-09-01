namespace Abstractions.QrCode
{
    public interface IGenerator
    {
        string GenerateSvg(string input);
    }
}

