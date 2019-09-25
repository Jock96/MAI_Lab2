namespace UI.Commands
{
    using System.Windows;

    using UI.ViewModels;

    using BL.Extensions;
    using System.Drawing;
    using System;

    /// <summary>
    /// Команда выделения границ.
    /// </summary>
    public class GetEdgesCommand : BaseTCommand<MainWindowVM>
    {
        /// <summary>
        /// Выполнить.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        protected override void Execute(MainWindowVM parameter)
        {
            var bitmap = parameter.CurrentBitmap;
            var isUseGrayScale = parameter.IsUseGrayScale;

            if (bitmap == null)
            {
                MessageBox.Show("Необходимо загрузить изображение для его обработки.");
                return;
            }

            Bitmap result = null;

            if (parameter.IsLaplass)
                result = bitmap.ConvertByLaplasianFilter(isUseGrayScale);

            if (parameter.IsSobel)
                result = bitmap.ConvertBySobelFilter(isUseGrayScale);

            if (parameter.IsRoberts)
                MessageBox.Show("Операция не реализована");

            if (result == null)
                return;

            try
            {
                parameter.ImageSource = result.ConvertToImageSource();
                //parameter.CurrentBitmap = result;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Не удалось обновить изображение!\n{exception}");
                throw;
            }
        }
    }
}
