using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Security;
using System.Diagnostics;

namespace ImageConverter
{
    public partial class Converter_Form : CustomForm
    {
        Pixelator pixelisator;
        ImageViewer_Form ShowedImage;

        private int LeftIndent, TopIndent; //отступы по бокам 

        public Converter_Form()
        {
            InitializeComponent();
            pixelisator = new Pixelator();
            pixelisator.PixelSize = (int)PixSize_numericUpDown.Value; //Размер пикселя равен минимальному 
            pixLvl_comboBox.SelectedIndex = pixLvl_comboBox.SelectionStart; //Комбобокс показывает свой первый элемент
            pixelisator.PixelationLevel = int.Parse(pixLvl_comboBox.Text); //Уровень пикселизации равен первому элементу

            this.BackColor = Color.FromArgb(128, 128, 220);
            ShowedImage = new ImageViewer_Form();

            this.MinimumSize = new Size(exitButton.Width * 6, exitButton.Height + menuExit_button.Height);

            LeftIndent = 30; TopIndent = 20;
        }

        #region --Нажатия на кнопки--
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenFile_Button_Click(object sender, EventArgs e)
        {
            pixelisator.openFile();

            if (pixelisator.getFileName() != "") //Если картинка не пустая
            {
                showPicture_rButton.Enabled = true; //Разрешить ее просмотреть
                FileName_Label.Text = pixelisator.getFileName(); //Показываем название файла на форме
                Time_Label.Text = ""; //Сбрасываем время выполнения
                if (!pixelisator.IsImgConverted) //Если картинка не конвертирована
                {
                    StartConverting_Button.Enabled = true;
                    download_roundedButton.Enabled = false; //Не разрешаем скачивать неконвертированную картинку
                    toggleSwitch.Checked = false; //Новая картинка не была конвертирована, поэтому сбрасываем свитч "Использовать конвертированную картинку
                    toggleSwitch.Enabled = false;

                }

            }
        }

        private async void StartConverting_Button_Click(object sender, EventArgs e)
        {
            if (pixelisator.IsImgConverted)//Если изображение конвертированно или это первая конвертация
            {
                MessageBox.Show("Изображение уже конвертировано", "Ошибка"); //Выдаем ошибку
            }
            else
            {
                var timer = new Stopwatch(); //Считаем время выполнения конвертации
                timer.Start();

                if (Pixels_tabControl.SelectedTab == tabPage1)  //если выбран кастом пиксель
                {
                    await Task.Run(() => pixelisator.Convert());
                }
                else //Если выбран уровень пикселизации
                {
                    await Task.Run(() => pixelisator.ConvertWithPixLevel());
                }

                timer.Stop();

                Time_Label.Text = $"Время конвертации:  {timer.ElapsedMilliseconds} мс"; //Показываем время конвертации на форме

                download_roundedButton.Enabled = true; //Разрешаем скачивание
                toggleSwitch.Enabled = true; //Разрешаем использовать конвертированное изображение 

                if (!toggleSwitch.Checked)
                {
                    toggleSwitch.Checked = true;
                }

            }
        }

        private void menuExit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void download_roundedButton_Click(object sender, EventArgs e)
        {
            pixelisator.saveFile();
        }

        private void showPicture_rButton_Click(object sender, EventArgs e)
        {
            if (!ShowedImage.IsImageShowed) //Если окно с картинкой еще не открыто
            {
                ShowedImage.setImage(pixelisator.targetImage);
                ShowedImage.Show();
                //ShowedImage.Resize_Image();
            }
            else //Если открыто, то просто показываем его. Чтобы не открывать несколько одинаковых окон
            {
                ShowedImage.BringToFront();
            }

        }
        #endregion

        #region --События--
        private void PixSize_numericUpDown_ValueChanged(object sender, MyEventArgs e)
        {
            pixelisator.PixelSize = (int)PixSize_numericUpDown.Value;

        }
        private void toggleSwitch_CheckChanged(object sender)
        {
            if (this.toggleSwitch.Checked)
            {
                pixelisator.targetImage = pixelisator.getConvertedBitmap();
            }
            else
            {
                pixelisator.targetImage = pixelisator.getRawImage();
            }
        }

        private void pixLvl_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pixLvl_comboBox.SelectedIndex != -1)
            {
                pixelisator.PixelationLevel = int.Parse(pixLvl_comboBox.Text);
            }

        }
        private void pixLvl_comboBox_TextChanged(object sender, EventArgs e)
        {
            if (pixLvl_comboBox.Text != "")
            {
                pixelisator.PixelationLevel = int.Parse(pixLvl_comboBox.Text);
            }

        }

        private void Form_Size_Changed(object sender, EventArgs e)
        {
            ResizeForm();
        }

        #endregion

        private void ResizeForm()
        {
            MovableArea.Size = new Size(this.Width, MovableArea.Height);

            down_panel.Size = new Size(this.Width, down_panel.Height);
            down_panel.Location = new Point(down_panel.Location.X, this.Height - down_panel.Height);

            left_panel.Size = new Size(left_panel.Width, this.Height - down_panel.Height * 2);

            menuExit_button.Location = new Point(menuExit_button.Location.X, left_panel.Height - menuExit_button.Height);

            exitButton.Location = new Point(this.Width - exitButton.Width, exitButton.Location.Y);

            ButtonMax.Location = new Point(this.Width - ButtonMax.Width * 2 - 6, ButtonMax.Location.Y);

            Button_Min.Location = new Point(this.Width - Button_Min.Width * 3 - 12, Button_Min.Location.Y);

            Choose_Image_groupBox.Location = new Point(LeftIndent, TopIndent);

            download_groupBox.Location = new Point(LeftIndent, left_panel.Height - TopIndent - download_groupBox.Height - down_panel.Height);

            Pixels_tabControl.Location = new Point(LeftIndent, download_groupBox.Location.Y / 2 - TopIndent * 2);
            toggle_groupBox.Location = new Point(Pixels_tabControl.Location.X + Pixels_tabControl.Width, Pixels_tabControl.Location.Y);

        }
    }
}

