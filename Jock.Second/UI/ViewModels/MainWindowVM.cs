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

        /// <summary>
        /// Использовать выделение в cерых тонах.
        /// </summary>
        private bool _isUseGrayScale;

        /// <summary>
        /// Использовать выделение в cерых тонах.
        /// </summary>
        public bool IsUseGrayScale
        {
            get => _isUseGrayScale;
            set
            {
                _isUseGrayScale = value;
                OnPropertyChanged();
            }
        }

        #region Выборы методов

        /// <summary>
        /// Выбор метода Канни.
        /// </summary>
        private bool _isCannyMethod;

        /// <summary>
        /// Выбор метода Канни.
        /// </summary>
        public bool IsCannyMethod
        {
            get => _isCannyMethod;
            set
            {
                _isCannyMethod = value;

                if (value == true)
                {
                    _isLaplass = false;
                    _isRoberts = false;
                    _isSobel = false;
                    _isUseGrayScale = false;

                    OnPropertyChanged(nameof(IsLaplass));
                    OnPropertyChanged(nameof(IsRoberts));
                    OnPropertyChanged(nameof(IsSobel));
                    OnPropertyChanged(nameof(IsUseGrayScale));
                }

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Выбор метода Лапласса.
        /// </summary>
        private bool _isLaplass;

        /// <summary>
        /// Выбор метода Лапласса.
        /// </summary>
        public bool IsLaplass
        {
            get => _isLaplass;
            set
            {
                _isLaplass = value;

                if (value == true)
                {
                    _isRoberts = false;
                    OnPropertyChanged(nameof(IsRoberts));

                    _isSobel = false;
                    OnPropertyChanged(nameof(IsSobel));

                    _isCannyMethod = false;
                    OnPropertyChanged(nameof(IsCannyMethod));
                }

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Выбор метода Робертса.
        /// </summary>
        private bool _isRoberts;

        /// <summary>
        /// Выбор метода Робертса.
        /// </summary>
        public bool IsRoberts
        {
            get => _isRoberts;
            set
            {
                _isRoberts = value;

                if (value == true)
                {
                    _isLaplass = false;
                    OnPropertyChanged(nameof(IsLaplass));

                    _isSobel = false;
                    OnPropertyChanged(nameof(IsSobel));

                    _isCannyMethod = false;
                    OnPropertyChanged(nameof(IsCannyMethod));
                }

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Выбор метода Собеля.
        /// </summary>
        private bool _isSobel;

        /// <summary>
        /// Выбор метода Собеля.
        /// </summary>
        public bool IsSobel
        {
            get => _isSobel;
            set
            {
                _isSobel = value;

                if (value == true)
                {
                    _isLaplass = false;
                    OnPropertyChanged(nameof(IsLaplass));

                    _isRoberts = false;
                    OnPropertyChanged(nameof(IsRoberts));

                    _isCannyMethod = false;
                    OnPropertyChanged(nameof(IsCannyMethod));
                }

                OnPropertyChanged();
            }
        }

        #endregion

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
