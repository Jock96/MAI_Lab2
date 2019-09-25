namespace UI
{
    using System.Windows;

    using UI.ViewModels;

    /// <summary>
    /// Code-behind главного окна.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Code-behind главного окна.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowVM();
        }
    }
}
