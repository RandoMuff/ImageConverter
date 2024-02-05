using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Drawing.Imaging;

namespace ImageConverter
{
    public partial class ImageViewer_Form : CustomForm
    {
        Image OriginalImage;
        public bool IsImageShowed { get; protected set; } = true;
        public ImageViewer_Form()
        {
            InitializeComponent();
            this.ResizeForm();
            this.exitButton_ImageViewer.BringToFront();
            this.Button_Min.BringToFront();
            this.ImageSizeChange_TrackBar.BringToFront();
            this.BackColor = Color.FromArgb(80, 84, 250);
            this.DoubleBuffered = true;

            IsImageShowed = false;

            this.MinimumSize = new Size(this.exitButton_ImageViewer.Width * 3, this.ImageSizeChange_TrackBar.Height * 2); //минимальный размер формы
        }

        #region --Нажатия на кнопки--
        private void exitButton_ImageViewer_Click(object sender, EventArgs e)
        {
            this.Hide();
            IsImageShowed = false;
            ImageSizeChange_TrackBar.Value = ImageSizeChange_TrackBar.Minimum;
        }
        
        #endregion

        #region --Действия с картинкой--

        Image ZoomPicture(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;
        }
        public void setImage(Bitmap bitmap)
        {
            this.ShowedImage_PctBox.Image = bitmap;
            this.OriginalImage = bitmap;
        }

        #endregion

        #region --Resize--

        private void ViewerForm_Size_Changed(object sender, EventArgs e)
        {
            this.ResizeForm();
        }
        private void ResizeForm()
        {
            this.exitButton_ImageViewer.Location = new Point(this.Size.Width - this.exitButton_ImageViewer.Size.Width, this.exitButton_ImageViewer.Location.Y);

            this.ButtonMax.Location = new Point(this.Size.Width - this.ButtonMax.Size.Width * 2 - 6, this.ButtonMax.Location.Y);

            this.Button_Min.Location = new Point(this.Size.Width - this.Button_Min.Size.Width * 3 - 12, this.Button_Min.Location.Y);


            this.panel1.Size = new Size(this.Size.Width - 10, this.Size.Height - this.MovableArea.Height - this.ImageSizeChange_TrackBar.Height);
            this.ShowedImage_PctBox.Location = new Point(0, 0);
            this.panel1.Location = new Point(5, this.MovableArea.Height);

            this.MovableArea.Location = new Point(0, 0);

            this.ImageSizeChange_TrackBar.Location = new Point(this.Lower_panel.Width / 2 - this.ImageSizeChange_TrackBar.Width, 0);
            ShowedImage_PctBox.Left = (ClientSize.Width - ShowedImage_PctBox.Width) / 2;
            ShowedImage_PctBox.Top = (panel1.Height - ShowedImage_PctBox.Height) / 2;
        }

        #endregion

        #region --События--
        private void ImageSizeChange_TrackBar_Scroll(object sender, EventArgs e)
        {
            if (ImageSizeChange_TrackBar.Value > 0)
            {
                ShowedImage_PctBox.Image = ZoomPicture(OriginalImage, new Size(ImageSizeChange_TrackBar.Value, ImageSizeChange_TrackBar.Value)); //делаем картинку больше, используя начальную картинку
                ShowedImage_PctBox.Left = (ClientSize.Width - ShowedImage_PctBox.Width) / 2; //выравниваем картинку на середину

                ShowedImage_PctBox.Top = (panel1.Height - ShowedImage_PctBox.Height) / 2;
            }

        }
       

        private void ImageShowed_Shown(object sender, EventArgs e)
        {
            this.IsImageShowed = true;
        }
        #endregion

    }

}



