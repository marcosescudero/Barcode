﻿namespace Barcode.Interface
{
    using System.Threading.Tasks;
    public interface IQrCodeScanningService
    {
        Task<string> ScanAsync();
    }

}