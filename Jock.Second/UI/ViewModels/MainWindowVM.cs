namespace UI.ViewModels
{
    using System.Drawing;
    using System.Windows.Media;

    using UI.Commands;

    /// <summary>
    /// Вью-модель окна.
    /// </summary>
    public class MainWindowVM : BaseVM
    {
        /// <summary>
        /// Вью-модель окна.
        /// </summary>
        public MainWindowVM()
        {
            LoadCommand = new LoadCommand();
            GetEdgesCommand = new GetEdgesCommand();
        }

        #region Данные изображения.

        /// <summary>
        /// Текущее изображение.
        /// </summary>
        public Bitmap CurrentBitmap { get; set; }

        /// <summary>
        /// Изображение.
        /// </summary>
        private ImageSource _imageSource;

        /// <summary>
        /// Изображение.
        /// </summary>
        public ImageSource ImageSource
        {
            get => _imageSource;
            set
            {
                _imageSource = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Команды.

        /// <summary>
        /// Команда загрузки.
        /// </summary>
        public LoadCommand LoadCommand { get; set; }

        /// <summary>
        /// Команда получения границ.
        /// </summary>
        public GetEdgesCommand GetEdgesCommand { get; set; }

        #endregion
    }
}
