using System.IO;
using ZXing;

namespace zxing_net_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var fmt = BarcodeFormat.QR_CODE;

            var writer = new BarcodeWriter
            {
                Format = fmt,
                Options = { Height = 300, Width = 300 }
            };

            var image = writer.Write("test");

            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                File.WriteAllBytes("qrcode.png", ms.ToArray());
            }
        }
    }
}
