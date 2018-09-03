namespace Barcode.ViewModels
{
    using System;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Barcode.Interface;
    using GalaSoft.MvvmLight.Command;
    using Xamarin.Forms;

    public class NewOrderViewModel : BaseViewModel
    {
        #region Attributes
        private string barCode;
        #endregion

        #region Properties
        public string BarCode
        {
            get { return this.barCode; }
            set { SetValue(ref this.barCode, value); }
        } 
        #endregion


        #region Commands
        public ICommand ScanCommand
        {
            get
            {
                return new RelayCommand(Scan);
            }
        }

        private async void Scan()
        {
            BarCode = await ScannerSKU();
        }

        public async Task<string> ScannerSKU()
        {
            try
            {
                var scanner = DependencyService.Get<IQrCodeScanningService>();
                var result = await scanner.ScanAsync();
                return result.ToString();
            }
            catch (Exception ex)
            {
                ex.ToString();
                return string.Empty;
            }
        } 
        #endregion
    }

}
