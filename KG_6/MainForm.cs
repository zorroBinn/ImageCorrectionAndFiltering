using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KG_6
{
    public partial class MainForm : Form
    {
        private Image originalImage;

        public MainForm()
        {
            InitializeComponent();
        }

        private void uploadFile_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image loadedImage = new Bitmap(openFileDialog.FileName);
                        originalImage = (Image)loadedImage.Clone();
                        pictureBox_image.Image = loadedImage;
                        ResetImageState();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка при загрузке изображения.");
                    }
                }
            }
        }

        private void ResetImageState()
        {
            if (originalImage != null) pictureBox_image.Image = (Image)originalImage.Clone();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            ResetImageState();
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            if (originalImage == null || comboBox_sigma.SelectedItem == null || comboBox_Gauss_n.SelectedItem == null) { return; }
            ApplyGaussianBlur(int.Parse(comboBox_Gauss_n.SelectedItem.ToString()), double.Parse(comboBox_sigma.SelectedItem.ToString()));
        }

        private void ApplyGaussianBlur(int filterSize, double sigma)
        {
            Bitmap source = new Bitmap(pictureBox_image.Image);
            Bitmap result = new Bitmap(source.Width, source.Height);

            double[,] filter = CreateGaussianKernel(filterSize, sigma);

            //Радиус фильтра
            int r = filterSize / 2;

            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    double red = 0.0, green = 0.0, blue = 0.0;

                    for (int fy = 0; fy < filterSize; fy++)
                    {
                        for (int fx = 0; fx < filterSize; fx++)
                        {
                            // Вычисляем координаты соседнего пикселя с учетом отзеркаливания
                            int imageX = x + fx - r;
                            int imageY = y + fy - r;

                            if (imageX < 0) imageX = -imageX;
                            if (imageX >= source.Width) imageX = 2 * source.Width - imageX - 1;
                            if (imageY < 0) imageY = -imageY;
                            if (imageY >= source.Height) imageY = 2 * source.Height - imageY - 1;

                            // Получаем цвет пикселя и добавляем взвешенные значения
                            Color pixelColor = source.GetPixel(imageX, imageY);

                            red += pixelColor.R * filter[fy, fx];
                            green += pixelColor.G * filter[fy, fx];
                            blue += pixelColor.B * filter[fy, fx];
                        }
                    }

                    int rValue = Math.Min(Math.Max((int)Math.Round(red), 0), 255);
                    int gValue = Math.Min(Math.Max((int)Math.Round(green), 0), 255);
                    int bValue = Math.Min(Math.Max((int)Math.Round(blue), 0), 255);

                    result.SetPixel(x, y, Color.FromArgb(rValue, gValue, bValue));
                }
            }
            pictureBox_image.Image = result;
        }

        private double[,] CreateGaussianKernel(int size, double sigma)
        {
            double[,] kernel = new double[size, size];
            int r = size / 2;
            double sigma2 = sigma * sigma;
            double normalizationFactor = 0.0;

            for (int y = -r; y <= r; y++)
            {
                for (int x = -r; x <= r; x++)
                {
                    double value = Math.Exp(-(x * x + y * y) / (2 * sigma2));
                    kernel[y + r, x + r] = value;
                    normalizationFactor += value;
                }
            }

            //Нормализация ядра, чтобы сумма элементов фильтра равнялась 1.
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    kernel[y, x] /= normalizationFactor;
                }
            }
            return kernel;
        }

        private void button_saltAndPaper_noise_Click(object sender, EventArgs e)
        {
            if (originalImage == null || comboBox_noise_chance.SelectedItem == null) { return; }

            Bitmap noisyImage = new Bitmap(pictureBox_image.Image);
            double noiseProbability = double.Parse(comboBox_noise_chance.SelectedItem.ToString());
            Random random = new Random();

            for (int y = 0; y < noisyImage.Height; y++)
            {
                for (int x = 0; x < noisyImage.Width; x++)
                {
                    //Генерируем случайное число и решаем, будет ли этот пиксель "шумным"
                    double randomValue = random.NextDouble();
                    if (randomValue < noiseProbability)
                    {
                        //Случайно выбираем между "солью" и "перцем"
                        bool isSalt = random.Next(2) == 0;
                        noisyImage.SetPixel(x, y, isSalt ? Color.White : Color.Black);
                    }
                }
            }

            pictureBox_image.Image = noisyImage;

        }

        private void button_lines_noise_Click(object sender, EventArgs e)
        {
            if (originalImage == null) { return; }

            Bitmap noisyImage = new Bitmap(pictureBox_image.Image);
            Random random = new Random();

            int lineCount = (int)numericUpDown_number_of_lines.Value; //Количество линий
            int minLineLength = 10; //Минимальная длина линии
            int maxLineLength = 100; //Максимальная длина линии
            int minLineWidth = 1; //Минимальная толщина линии
            int maxLineWidth = 5; //Максимальная толщина линии

            using (Graphics g = Graphics.FromImage(noisyImage))
            {
                for (int i = 0; i < lineCount; i++)
                {
                    //Генерация случайных начальных координат
                    int startX = random.Next(noisyImage.Width);
                    int startY = random.Next(noisyImage.Height);

                    //Генерация случайной длины и направления линии
                    int lineLength = random.Next(minLineLength, maxLineLength + 1);
                    int angle = random.Next(0, 360); //Угол в градусах

                    //Конечные координаты линии с учетом длины и угла
                    int endX = startX + (int)(lineLength * Math.Cos(angle * Math.PI / 180));
                    int endY = startY + (int)(lineLength * Math.Sin(angle * Math.PI / 180));

                    Color lineColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)); //Случайный цвет

                    int lineWidth = random.Next(minLineWidth, maxLineWidth + 1); //Случайная толщина

                    using (Pen pen = new Pen(lineColor, lineWidth))
                    {
                        g.DrawLine(pen, startX, startY, endX, endY);
                    }
                }
            }

            pictureBox_image.Image = noisyImage;
        }

        private void button_circles_noise_Click(object sender, EventArgs e)
        {
            if (originalImage == null) { return; }

            Bitmap noisyImage = new Bitmap(pictureBox_image.Image);
            Random random = new Random();

            int circleCount = (int)numericUpDown_number_of_circles.Value;

            int minRadius = 5; //Минимальный радиус окружности
            int maxRadius = 30; //Максимальный радиус окружности

            using (Graphics g = Graphics.FromImage(noisyImage))
            {
                for (int i = 0; i < circleCount; i++)
                {
                    //Случайные координаты центра окружности
                    int centerX = random.Next(noisyImage.Width);
                    int centerY = random.Next(noisyImage.Height);
                    int radius = random.Next(minRadius, maxRadius + 1); //Случайный радиус окружности
                    int lineWidth = random.Next(1, 4); //Случайная толщина линии окружности

                    Color circleColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)); //Случайный цвет окружности

                    using (Pen pen = new Pen(circleColor, lineWidth))
                    {
                        g.DrawEllipse(pen, centerX - radius, centerY - radius, radius * 2, radius * 2);
                    }
                }
            }

            pictureBox_image.Image = noisyImage;
        }

        private void button_linear_filter_Click(object sender, EventArgs e)
        {
            if (originalImage == null || comboBox_linear_n.SelectedItem == null || comboBox_linear_m.SelectedItem == null) { return; }
            ApplyUniformFilter(int.Parse(comboBox_linear_n.SelectedItem.ToString()), int.Parse(comboBox_linear_m.SelectedItem.ToString()));

        }

        private void ApplyUniformFilter(int filterWidth, int filterHeight)
        {
            Bitmap source = new Bitmap(pictureBox_image.Image);
            Bitmap result = new Bitmap(source.Width, source.Height);

            double[,] filter = CreateUniformKernel(filterWidth, filterHeight);

            //Радиусы фильтра
            int rX = filterWidth / 2;
            int rY = filterHeight / 2;

            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    double red = 0.0, green = 0.0, blue = 0.0;

                    for (int fy = 0; fy < filterHeight; fy++)
                    {
                        for (int fx = 0; fx < filterWidth; fx++)
                        {
                            //Вычисляем координаты соседнего пикселя с учетом отзеркаливания
                            int imageX = x + fx - rX;
                            int imageY = y + fy - rY;

                            if (imageX < 0) imageX = -imageX;
                            if (imageX >= source.Width) imageX = 2 * source.Width - imageX - 1;
                            if (imageY < 0) imageY = -imageY;
                            if (imageY >= source.Height) imageY = 2 * source.Height - imageY - 1;

                            //Получаем цвет пикселя и добавляем взвешенные значения
                            Color pixelColor = source.GetPixel(imageX, imageY);

                            red += pixelColor.R * filter[fy, fx];
                            green += pixelColor.G * filter[fy, fx];
                            blue += pixelColor.B * filter[fy, fx];
                        }
                    }

                    int rValue = Math.Min(Math.Max((int)Math.Round(red), 0), 255);
                    int gValue = Math.Min(Math.Max((int)Math.Round(green), 0), 255);
                    int bValue = Math.Min(Math.Max((int)Math.Round(blue), 0), 255);

                    result.SetPixel(x, y, Color.FromArgb(rValue, gValue, bValue));
                }
            }
            pictureBox_image.Image = result;
        }

        private double[,] CreateUniformKernel(int width, int height)
        {
            double[,] kernel = new double[height, width];
            double value = 1.0 / (width * height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    kernel[y, x] = value;
                }
            }

            return kernel;
        }

        private void button_sharpen_Click(object sender, EventArgs e)
        {
            if (originalImage == null) { return; }
            ApplySharpenFilter((int)numericUpDown_sharpen_n.Value, (int)numericUpDown_sharpen_k.Value);
        }

        private void ApplySharpenFilter(int filterSize, int k)
        {
            Bitmap source = new Bitmap(pictureBox_image.Image);
            Bitmap result = new Bitmap(source.Width, source.Height);

            //Создаём ядро фильтра резкости
            double[,] kernel = CreateSharpenKernel(filterSize, k);

            //Радиус фильтра (половина размера ядра)
            int radius = filterSize / 2;

            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    double red = 0.0, green = 0.0, blue = 0.0;

                    for (int fy = 0; fy < filterSize; fy++)
                    {
                        for (int fx = 0; fx < filterSize; fx++)
                        {
                            //Вычисляем координаты соседнего пикселя с учётом отзеркаливания
                            int imageX = x + fx - radius;
                            int imageY = y + fy - radius;

                            if (imageX < 0) imageX = -imageX;
                            if (imageX >= source.Width) imageX = 2 * source.Width - imageX - 1;
                            if (imageY < 0) imageY = -imageY;
                            if (imageY >= source.Height) imageY = 2 * source.Height - imageY - 1;

                            Color pixelColor = source.GetPixel(imageX, imageY);

                            red += pixelColor.R * kernel[fy, fx];
                            green += pixelColor.G * kernel[fy, fx];
                            blue += pixelColor.B * kernel[fy, fx];
                        }
                    }

                    int r = Math.Min(Math.Max((int)Math.Round(red), 0), 255);
                    int g = Math.Min(Math.Max((int)Math.Round(green), 0), 255);
                    int b = Math.Min(Math.Max((int)Math.Round(blue), 0), 255);

                    result.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            pictureBox_image.Image = result;
        }

        private double[,] CreateSharpenKernel(int size, int k)
        {
            //Создание ядра размером size x size
            double[,] kernel = new double[size, size];
            //Значение для всех отрицательных коэффициентов
            double negativeValue = -k / (double)((size * size) - 1);

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    kernel[y, x] = negativeValue;
                }
            }

            int center = size / 2;
            kernel[center, center] = k + 1;
            return kernel;
        }

        private void numericUpDown_sharpen_n_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_sharpen_k.Maximum = numericUpDown_sharpen_n.Value * numericUpDown_sharpen_n.Value - 1;
            if (numericUpDown_sharpen_k.Value > numericUpDown_sharpen_k.Maximum) numericUpDown_sharpen_k.Value = numericUpDown_sharpen_k.Maximum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (originalImage == null) { return; }

        }
    }
}
