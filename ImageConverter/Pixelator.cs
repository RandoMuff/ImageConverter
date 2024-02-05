using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ImageConverter
{
    public class Pixelator : Image_Converter
    {
        #region --Свойства и переменные--
        private int onePixel;
        private int pixLevel;
        public int PixelSize
        {
            get => this.onePixel;
            set
            {
                onePixel = value;
                if (IsImgConverted && !IsFirstConvertation)
                    IsImgConverted = false;
            }
        }
        public int PixelationLevel
        {
            get => this.pixLevel;
            set
            {
                this.pixLevel = value;
                if (IsImgConverted && !IsFirstConvertation)
                    IsImgConverted = false;
            }
        }
        #endregion
        public Pixelator()
        {


            _openFileDialog = new OpenFileDialog
            {
                Filter = "Images| *.bmp; *.png; *.jpg; *.JPEG"
            };

            saveFileDialog = new SaveFileDialog
            {
                Filter = "PNG Image(*.png)|*.png|JPG Image(*.jpg)|*.jpg|BMP Image(*.bmp)|*.bmp",
                FileName = "Picture"

            };
        }

        public void Convert()
        {
            if (IsFirstConvertation) { IsFirstConvertation = false; } //если конвертации еще не было
            IsImgConverted = true;

            Bitmap BTemp = new Bitmap(this.targetImage);
            Bitmap targetBmp = BTemp.Clone(new Rectangle(0, 0, BTemp.Width, BTemp.Height), PixelFormat.Format32bppArgb); //Подходит только один формат


            using var getFrom = new BmpPixelSnoop(targetBmp);
            using var toChange = new BmpPixelSnoop(this.converted_bitmap);

            // int pixInH = height / PixelSize;
            // int pixInW = width / PixelSize;

            // Parallel.For(0, height, yPos =>
            for (int yPos = 0; yPos < imageHeight; yPos += PixelSize)
            {

                for (int xPos = 0; xPos < imageWidth; xPos += PixelSize)
                {
                    // Get a pixel from the input bitmap
                    var p1 = getFrom.GetPixel(xPos, yPos);

                    for (int yCurr = 0; yCurr < PixelSize && yCurr + yPos < imageHeight; yCurr++)
                    {
                        for (int xCurr = 0; xCurr < PixelSize && xCurr + xPos < imageWidth; xCurr++)
                        {
                            // Set it into the snooped bitmap
                            toChange.SetPixel(xCurr + xPos, yCurr + yPos, p1);
                        }


                    }
                }


            }

        }
        private int CalculateExtraPixCount(int extraPix, int max, int pixSize)
        {
            return max - PixelationLevel * pixSize;
        }
        private int CalculatePixSize(int max)
        {
            int pixCount = max / PixelationLevel;

            return max / pixCount;
        }

        public void ConvertWithPixLevel()
        {
            int PixelSizeW = CalculatePixSize(imageWidth);
            int PixelSizeH = CalculatePixSize(imageHeight);

            int exPixCountW = 0; //Количество лишних пикселей в ширине (которые не могут сформировать целый пиксель по заданным размерам)
            exPixCountW = imageWidth - PixelSizeW * (imageWidth / PixelationLevel);

            int exPixCountH = 0; //Лишние пиксели в высоте
            exPixCountH = imageHeight - PixelSizeH * (imageHeight / PixelationLevel);

            if (IsFirstConvertation) { IsFirstConvertation = false; } //если конвертации еще не было
            IsImgConverted = true;

            Bitmap BTemp = new Bitmap(this.targetImage);
            Bitmap targetBmp = BTemp.Clone(new Rectangle(0, 0, BTemp.Width, BTemp.Height), PixelFormat.Format32bppArgb); //Подходит только один формат

            using var getFrom = new BmpPixelSnoop(targetBmp);
            using var toChange = new BmpPixelSnoop(this.converted_bitmap);

            int indentW = -2; //Отступ для пикселя в ширину (делаем некоторые пиксели немного больше)
            int indentH = -2; //Отступ в высоту. -2 нужно для проверки, есть ли отступ 


            if (exPixCountW != 0)
            {
                PixelSizeW++;
                indentW = exPixCountW;
            }

            if (exPixCountH != 0)
            {
                PixelSizeH++;
                indentH = exPixCountH;
            }


            for (int yPos = 0; yPos < imageHeight; yPos += PixelSizeH)
            {

                for (int xPos = 0; xPos < imageWidth; xPos += PixelSizeW)
                {
                    if (indentW == 0)
                    {
                        PixelSizeW--;
                        indentW = -1;
                    }

                    if (indentH == 0)
                    {
                        PixelSizeH--;
                        indentH = -1;
                    }
                    // Get a pixel from the input bitmap
                    var p1 = getFrom.GetPixel(xPos, yPos);

                    for (int yCurr = 0; yCurr <= PixelSizeH && yCurr + yPos < imageHeight; yCurr++)
                    {
                        for (int xCurr = 0; xCurr <= PixelSizeW && xCurr + xPos < imageWidth; xCurr++)
                        {

                            // Set it into the snooped bitmap
                            toChange.SetPixel(xCurr + xPos, yCurr + yPos, p1);
                        }

                    }
                    if (indentW > 0)
                    {
                        indentW--;
                    }
                }
                if (indentH > 0)
                {
                    indentH--;
                }
                if (indentW != -2)
                {
                    indentW = exPixCountW;
                    PixelSizeW++;
                }

            }
            if (indentH != -2)
            {
                indentH = exPixCountH;
                PixelSizeH++;
            }

        }
    }
}
