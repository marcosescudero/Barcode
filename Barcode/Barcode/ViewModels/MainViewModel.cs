
namespace Barcode.ViewModels
{
    using ViewModels;
    public class MainViewModel
    {
        #region Properties
        public NewOrderViewModel OrderNew { get; set; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.OrderNew = new NewOrderViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance; // Atributo
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new MainViewModel();
            }

            return instance;
        }
        #endregion

    }

}
