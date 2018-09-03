using Xamarin.Forms;

[assembly: Dependency(typeof(Barcode.UWP.Implementations.QrCodeScanningService))]
namespace Barcode.UWP.Implementations
{
    using Barcode.Interface;
    using System.Threading.Tasks;
    using ZXing.Mobile;

    public class QrCodeScanningService : IQrCodeScanningService
    {
        public async Task<string> ScanAsync()
        {
            var scanner = new MobileBarcodeScanner();
            var scanResults = await scanner.Scan();
            return scanResults.Text;
        }
    }
}
