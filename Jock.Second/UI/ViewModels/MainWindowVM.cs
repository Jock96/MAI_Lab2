﻿namespace UI.ViewModels
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

        #region Выборы методов

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
