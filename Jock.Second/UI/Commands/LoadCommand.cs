namespace UI.Commands
{
    using BL.Extensions;
    using BL.Helpers;

    using Microsoft.Win32;

    using System;
    using System.Drawing;
    using System.Windows;

    using UI.ViewModels;

    /// <summary>
    /// Команда загрузки.
    /// </summary>
    public class LoadCommand : BaseTCommand<MainWindowVM>
    {
        /// <summary>
        /// Выполнить.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        protected override void Execute(MainWindowVM parameter)
        {
            var fileDialog = new OpenFileDialog
            {
                Filter = @"(*.bmp)|*.bmp",
                InitialDirectory = PathHelper.GetResourcesPath()
            };

            var file = fileDialog.ShowDialog();

            if (!file.HasValue || string.Equals(string.Empty, fileDialog.FileName))
                return;

            try
            {
                using (var fileStream = fileDialog.OpenFile())
                {
                    var bitmap = new Bitmap(fileStream);

                    parameter.ImageSource = bitmap.ConvertToImageSource();
                    parameter.CurrentBitmap = bitmap;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Не удалось импортировать файл!" +
                    $"\nОшибка: {exception.ToString()}");
            }
        }
    }
}
