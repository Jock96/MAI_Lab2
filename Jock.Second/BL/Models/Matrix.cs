namespace BL.Models
{
    /// <summary>
    /// Матрицы выделения границ по типу.
    /// </summary>
    public static class Matrix
    {
        /// <summary>
        /// Матрица Лапласса.
        /// </summary>
        public static double[,] Laplacian3x3
        {
            get => new double[,]  
                { { -1, -1, -1,  }, 
                  { -1,  8, -1,  }, 
                  { -1, -1, -1,  }, };
        }

        /// <summary>
        /// Горизонтальная матрица Собеля.
        /// </summary>
        public static double[,] Sobel3x3Horizontal
        {
            get => new double[,] 
                { { -1,  0,  1, }, 
                  { -2,  0,  2, }, 
                  { -1,  0,  1, }, };
        }

        /// <summary>
        /// Вертикальная матрица Собеля.
        /// </summary>
        public static double[,] Sobel3x3Vertical
        {
            get => new double[,] 
                { {  1,  2,  1, }, 
                  {  0,  0,  0, }, 
                  { -1, -2, -1, }, };
        }
    }
}
