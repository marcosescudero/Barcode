using Xamarin.Forms;

[assembly: Dependency(typeof(Barcode.Droid.Implementations.QrCodeScanningService))]
namespace Barcode.Droid.Implementations
{
    using System.Threading.Tasks;
    using Barcode.Interface;
    using ZXing.Mobile;

    public class QrCodeScanningService : IQrCodeScanningService
    {

        public async Task<string> ScanAsync()
        {
            var options = new MobileBarcodeScanningOptions();
            var scanner = new MobileBarcodeScanner();
            var scanResults = await scanner.Scan(options);
            return scanResults.Text;
        }
    }

}