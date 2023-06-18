using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace ImageConverter
{
    public class Image_Converter
    {
        protected Bitmap raw_bitmap;
        protected Bitmap converted_bitmap;
        protected OpenFileDialog _openFileDialog;
        protected SaveFileDialog saveFileDialog;
        protected int imageHeight;
        protected int imageWidth;
        public Bitmap targetImage;

        public bool IsImgConverted { get; protected set; } = true;

        public bool IsFirstConvertation { get; protected set; } = true;

        public void openFile()
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_openFileDialog.FileName != "")
                {
                    raw_bitmap = new Bitmap(_openFileDialog.FileName);
                  
                    targetImage = raw_bitmap;

                    imageHeight = raw_bitmap.Height;
                    imageWidth = raw_bitmap.Width;

                    converted_bitmap = new Bitmap(this.imageWidth, this.imageHeight);

                    IsImgConverted = false;
                }
            }
        }

        public void saveFile()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = saveFileDialog.FileName;

                    System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog.OpenFile();
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            targetImage.Save(fs,
                              System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                        case 2:
                            targetImage.Save(fs,
                              System.Drawing.Imaging.ImageFormat.Bmp);
                            break;

                        case 3:
                            targetImage.Save(fs,
                              System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                    }

                    fs.Close();

                }
                catch (System.Security.SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }

            }
        }

        public string getFileName()
        {
            return _openFileDialog.FileName;
        }

        public void setFileName(string FileName)
        {
            _openFileDialog.FileName = FileName;
        }

        public Bitmap getRawImage()
        {

            return raw_bitmap;
        }

        public Bitmap getConvertedBitmap()
        {

            return converted_bitmap;
        }


    }
}
