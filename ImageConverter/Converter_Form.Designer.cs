
using System;
using System.Windows.Forms;

namespace ImageConverter
{
    partial class Converter_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter_Form));
            MovableArea = new Panel();
            AppName_label = new Label();
            Button_Min = new Button();
            exitButton = new Button();
            ButtonMax = new Button();
            Time_Label = new Label();
            StartConverting_Button = new Button();
            PixSize_numericUpDown = new CustomNumericUpDown();
            label1 = new Label();
            down_panel = new Panel();
            label3 = new Label();
            left_panel = new Panel();
            menuExit_button = new RButton();
            download_groupBox = new GroupBox();
            download_roundedButton = new RButton();
            showPicture_rButton = new RButton();
            OpenFile_Button = new Button();
            useConvertedImg_label = new Label();
            toggle_groupBox = new GroupBox();
            toggleSwitch = new Toggle_Switch();
            Pixels_tabControl = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            pixLevel_label = new Label();
            pixLvl_comboBox = new ComboBox();
            dragControl = new DragControl();
            Choose_Image_groupBox = new GroupBox();
            FileName_Label = new Label();
            panel1 = new Panel();
            MovableArea.SuspendLayout();
            down_panel.SuspendLayout();
            left_panel.SuspendLayout();
            download_groupBox.SuspendLayout();
            toggle_groupBox.SuspendLayout();
            Pixels_tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            Choose_Image_groupBox.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MovableArea
            // 
            MovableArea.BackColor = System.Drawing.Color.LightSlateGray;
            MovableArea.Controls.Add(AppName_label);
            MovableArea.Controls.Add(Button_Min);
            MovableArea.Controls.Add(exitButton);
            MovableArea.Controls.Add(ButtonMax);
            MovableArea.Dock = DockStyle.Top;
            MovableArea.Location = new System.Drawing.Point(3, 3);
            MovableArea.Name = "MovableArea";
            MovableArea.Size = new System.Drawing.Size(920, 36);
            MovableArea.TabIndex = 4;
            // 
            // AppName_label
            // 
            AppName_label.AutoSize = true;
            AppName_label.BackColor = System.Drawing.Color.Transparent;
            AppName_label.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AppName_label.Location = new System.Drawing.Point(0, 0);
            AppName_label.Name = "AppName_label";
            AppName_label.Size = new System.Drawing.Size(197, 33);
            AppName_label.TabIndex = 18;
            AppName_label.Text = "Image Converter";
            // 
            // Button_Min
            // 
            Button_Min.BackColor = System.Drawing.SystemColors.InactiveCaption;
            Button_Min.Cursor = Cursors.Hand;
            Button_Min.FlatStyle = FlatStyle.Flat;
            Button_Min.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Button_Min.Location = new System.Drawing.Point(764, 0);
            Button_Min.Name = "Button_Min";
            Button_Min.Size = new System.Drawing.Size(48, 36);
            Button_Min.TabIndex = 5;
            Button_Min.Text = "‒";
            Button_Min.UseVisualStyleBackColor = false;
            Button_Min.Click += Button_Min_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            exitButton.Location = new System.Drawing.Point(872, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new System.Drawing.Size(48, 36);
            exitButton.TabIndex = 1;
            exitButton.Text = "×";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // ButtonMax
            // 
            ButtonMax.BackColor = System.Drawing.SystemColors.InactiveCaption;
            ButtonMax.Cursor = Cursors.Hand;
            ButtonMax.FlatStyle = FlatStyle.Flat;
            ButtonMax.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ButtonMax.Location = new System.Drawing.Point(818, 0);
            ButtonMax.Name = "ButtonMax";
            ButtonMax.Size = new System.Drawing.Size(48, 36);
            ButtonMax.TabIndex = 4;
            ButtonMax.Text = "❐";
            ButtonMax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            ButtonMax.UseVisualStyleBackColor = false;
            ButtonMax.Click += ButtonMax_Click;
            // 
            // Time_Label
            // 
            Time_Label.AutoSize = true;
            Time_Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Time_Label.Location = new System.Drawing.Point(85, 0);
            Time_Label.Name = "Time_Label";
            Time_Label.Size = new System.Drawing.Size(0, 32);
            Time_Label.TabIndex = 8;
            // 
            // StartConverting_Button
            // 
            StartConverting_Button.BackColor = System.Drawing.Color.SteelBlue;
            StartConverting_Button.Cursor = Cursors.Hand;
            StartConverting_Button.FlatStyle = FlatStyle.Flat;
            StartConverting_Button.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            StartConverting_Button.Location = new System.Drawing.Point(6, 26);
            StartConverting_Button.Name = "StartConverting_Button";
            StartConverting_Button.Size = new System.Drawing.Size(189, 86);
            StartConverting_Button.TabIndex = 8;
            StartConverting_Button.Text = "Начать конвертацию";
            StartConverting_Button.UseVisualStyleBackColor = false;
            StartConverting_Button.Click += StartConverting_Button_Click;
            // 
            // PixSize_numericUpDown
            // 
            PixSize_numericUpDown.BackColor = System.Drawing.Color.LightGray;
            PixSize_numericUpDown.ButtonColor = System.Drawing.Color.Black;
            PixSize_numericUpDown.ButtonUpDownWidth = 40;
            PixSize_numericUpDown.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PixSize_numericUpDown.Location = new System.Drawing.Point(17, 98);
            PixSize_numericUpDown.MaximumValue = 2000D;
            PixSize_numericUpDown.MiminumValue = 1D;
            PixSize_numericUpDown.Name = "PixSize_numericUpDown";
            PixSize_numericUpDown.Size = new System.Drawing.Size(176, 60);
            PixSize_numericUpDown.Step = 1D;
            PixSize_numericUpDown.TabIndex = 12;
            PixSize_numericUpDown.Value = 2D;
            PixSize_numericUpDown.ValueChanged += PixSize_numericUpDown_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(2, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(191, 66);
            label1.TabIndex = 13;
            label1.Text = "Размер одного \r\nпикселя";
            // 
            // down_panel
            // 
            down_panel.BackColor = System.Drawing.Color.LightSlateGray;
            down_panel.Controls.Add(label3);
            down_panel.Controls.Add(Time_Label);
            down_panel.Dock = DockStyle.Bottom;
            down_panel.Location = new System.Drawing.Point(82, 608);
            down_panel.Name = "down_panel";
            down_panel.Size = new System.Drawing.Size(841, 53);
            down_panel.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(200, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(0, 41);
            label3.TabIndex = 8;
            // 
            // left_panel
            // 
            left_panel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            left_panel.Controls.Add(menuExit_button);
            left_panel.Dock = DockStyle.Left;
            left_panel.Location = new System.Drawing.Point(3, 39);
            left_panel.Name = "left_panel";
            left_panel.Size = new System.Drawing.Size(79, 622);
            left_panel.TabIndex = 17;
            // 
            // menuExit_button
            // 
            menuExit_button.BackColor = System.Drawing.Color.Transparent;
            menuExit_button.BackgroundColor = System.Drawing.Color.Transparent;
            menuExit_button.BorderColor = System.Drawing.Color.DarkSlateBlue;
            menuExit_button.BorderRadius = 20;
            menuExit_button.BorderSize = 0;
            menuExit_button.FlatStyle = FlatStyle.Flat;
            menuExit_button.ForeColor = System.Drawing.Color.White;
            menuExit_button.Image = (System.Drawing.Image)resources.GetObject("menuExit_button.Image");
            menuExit_button.Location = new System.Drawing.Point(3, 480);
            menuExit_button.Name = "menuExit_button";
            menuExit_button.Size = new System.Drawing.Size(76, 78);
            menuExit_button.TabIndex = 26;
            menuExit_button.TextColor = System.Drawing.Color.White;
            menuExit_button.UseVisualStyleBackColor = false;
            menuExit_button.Click += menuExit_button_Click;
            // 
            // download_groupBox
            // 
            download_groupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            download_groupBox.Controls.Add(showPicture_rButton);
            download_groupBox.Controls.Add(StartConverting_Button);
            download_groupBox.Controls.Add(download_roundedButton);
            download_groupBox.FlatStyle = FlatStyle.Popup;
            download_groupBox.Location = new System.Drawing.Point(13, 419);
            download_groupBox.Name = "download_groupBox";
            download_groupBox.Size = new System.Drawing.Size(496, 133);
            download_groupBox.TabIndex = 21;
            download_groupBox.TabStop = false;
            // 
            // download_roundedButton
            // 
            download_roundedButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            download_roundedButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            download_roundedButton.BorderColor = System.Drawing.Color.DarkSlateBlue;
            download_roundedButton.BorderRadius = 20;
            download_roundedButton.BorderSize = 1;
            download_roundedButton.Enabled = false;
            download_roundedButton.FlatStyle = FlatStyle.Flat;
            download_roundedButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            download_roundedButton.ForeColor = System.Drawing.Color.White;
            download_roundedButton.Location = new System.Drawing.Point(222, 26);
            download_roundedButton.Name = "download_roundedButton";
            download_roundedButton.Size = new System.Drawing.Size(129, 86);
            download_roundedButton.TabIndex = 26;
            download_roundedButton.Text = "Скачать";
            download_roundedButton.TextColor = System.Drawing.Color.White;
            download_roundedButton.UseVisualStyleBackColor = false;
            download_roundedButton.Click += download_roundedButton_Click;
            // 
            // showPicture_rButton
            // 
            showPicture_rButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            showPicture_rButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            showPicture_rButton.BorderColor = System.Drawing.Color.DarkSlateBlue;
            showPicture_rButton.BorderRadius = 20;
            showPicture_rButton.BorderSize = 1;
            showPicture_rButton.Enabled = false;
            showPicture_rButton.FlatStyle = FlatStyle.Flat;
            showPicture_rButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            showPicture_rButton.ForeColor = System.Drawing.Color.White;
            showPicture_rButton.Location = new System.Drawing.Point(360, 26);
            showPicture_rButton.Name = "showPicture_rButton";
            showPicture_rButton.Size = new System.Drawing.Size(136, 86);
            showPicture_rButton.TabIndex = 27;
            showPicture_rButton.Text = "Просмо\r\nтреть";
            showPicture_rButton.TextColor = System.Drawing.Color.White;
            showPicture_rButton.UseVisualStyleBackColor = false;
            showPicture_rButton.Click += showPicture_rButton_Click;
            // 
            // OpenFile_Button
            // 
            OpenFile_Button.BackColor = System.Drawing.Color.MediumSeaGreen;
            OpenFile_Button.Cursor = Cursors.Hand;
            OpenFile_Button.FlatStyle = FlatStyle.Flat;
            OpenFile_Button.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            OpenFile_Button.Location = new System.Drawing.Point(6, 26);
            OpenFile_Button.Name = "OpenFile_Button";
            OpenFile_Button.Size = new System.Drawing.Size(185, 79);
            OpenFile_Button.TabIndex = 7;
            OpenFile_Button.Text = "Выбрать файл";
            OpenFile_Button.UseVisualStyleBackColor = false;
            OpenFile_Button.Click += OpenFile_Button_Click;
            // 
            // useConvertedImg_label
            // 
            useConvertedImg_label.AutoSize = true;
            useConvertedImg_label.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            useConvertedImg_label.Location = new System.Drawing.Point(6, 23);
            useConvertedImg_label.Name = "useConvertedImg_label";
            useConvertedImg_label.Size = new System.Drawing.Size(371, 58);
            useConvertedImg_label.TabIndex = 23;
            useConvertedImg_label.Text = "Использовать конвертированное \r\nизображение";
            // 
            // toggle_groupBox
            // 
            toggle_groupBox.BackColor = System.Drawing.Color.Lavender;
            toggle_groupBox.Controls.Add(useConvertedImg_label);
            toggle_groupBox.Controls.Add(toggleSwitch);
            toggle_groupBox.FlatStyle = FlatStyle.Popup;
            toggle_groupBox.Location = new System.Drawing.Point(302, 205);
            toggle_groupBox.Name = "toggle_groupBox";
            toggle_groupBox.Size = new System.Drawing.Size(371, 173);
            toggle_groupBox.TabIndex = 24;
            toggle_groupBox.TabStop = false;
            // 
            // toggleSwitch
            // 
            toggleSwitch.AnimationSpeed = 11;
            toggleSwitch.BackColor = System.Drawing.Color.White;
            toggleSwitch.BackColorOFF = System.Drawing.Color.RosyBrown;
            toggleSwitch.BackColorON = System.Drawing.Color.Firebrick;
            toggleSwitch.BackColorUnenabled = System.Drawing.SystemColors.ActiveBorder;
            toggleSwitch.Checked = false;
            toggleSwitch.Cursor = Cursors.Hand;
            toggleSwitch.Enabled = false;
            toggleSwitch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toggleSwitch.Location = new System.Drawing.Point(0, 116);
            toggleSwitch.Name = "toggleSwitch";
            toggleSwitch.Size = new System.Drawing.Size(157, 51);
            toggleSwitch.TabIndex = 28;
            toggleSwitch.CheckedChanged += toggleSwitch_CheckChanged;
            // 
            // Pixels_tabControl
            // 
            Pixels_tabControl.Appearance = TabAppearance.FlatButtons;
            Pixels_tabControl.Controls.Add(tabPage1);
            Pixels_tabControl.Controls.Add(tabPage2);
            Pixels_tabControl.Cursor = Cursors.Hand;
            Pixels_tabControl.Location = new System.Drawing.Point(19, 169);
            Pixels_tabControl.Name = "Pixels_tabControl";
            Pixels_tabControl.SelectedIndex = 0;
            Pixels_tabControl.Size = new System.Drawing.Size(267, 222);
            Pixels_tabControl.TabIndex = 25;
            Pixels_tabControl.SelectedIndexChanged += Pixels_tabControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.PaleGoldenrod;
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(PixSize_numericUpDown);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tabPage1.Location = new System.Drawing.Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new System.Drawing.Size(259, 186);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Кастом";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = System.Drawing.Color.Thistle;
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(pixLevel_label);
            tabPage2.Controls.Add(pixLvl_comboBox);
            tabPage2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tabPage2.Location = new System.Drawing.Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new System.Drawing.Size(259, 186);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Авто";
            // 
            // pixLevel_label
            // 
            pixLevel_label.AutoSize = true;
            pixLevel_label.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pixLevel_label.Location = new System.Drawing.Point(2, 3);
            pixLevel_label.Name = "pixLevel_label";
            pixLevel_label.Size = new System.Drawing.Size(179, 66);
            pixLevel_label.TabIndex = 14;
            pixLevel_label.Text = "Уровень\r\nпикселизации";
            // 
            // pixLvl_comboBox
            // 
            pixLvl_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            pixLvl_comboBox.BackColor = System.Drawing.Color.Gainsboro;
            pixLvl_comboBox.Cursor = Cursors.Hand;
            pixLvl_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            pixLvl_comboBox.FlatStyle = FlatStyle.Popup;
            pixLvl_comboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pixLvl_comboBox.ForeColor = System.Drawing.Color.Black;
            pixLvl_comboBox.Items.AddRange(new object[] { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" });
            pixLvl_comboBox.Location = new System.Drawing.Point(12, 76);
            pixLvl_comboBox.MinimumSize = new System.Drawing.Size(10, 0);
            pixLvl_comboBox.Name = "pixLvl_comboBox";
            pixLvl_comboBox.Size = new System.Drawing.Size(180, 40);
            pixLvl_comboBox.TabIndex = 29;
            pixLvl_comboBox.SelectedIndexChanged += pixLvl_comboBox_SelectedIndexChanged;
            pixLvl_comboBox.TextChanged += pixLvl_comboBox_TextChanged;
            // 
            // dragControl
            // 
            dragControl.SelectControl = MovableArea;
            // 
            // Choose_Image_groupBox
            // 
            Choose_Image_groupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            Choose_Image_groupBox.Controls.Add(FileName_Label);
            Choose_Image_groupBox.Controls.Add(OpenFile_Button);
            Choose_Image_groupBox.FlatStyle = FlatStyle.Popup;
            Choose_Image_groupBox.Location = new System.Drawing.Point(13, 18);
            Choose_Image_groupBox.Name = "Choose_Image_groupBox";
            Choose_Image_groupBox.Size = new System.Drawing.Size(496, 133);
            Choose_Image_groupBox.TabIndex = 26;
            Choose_Image_groupBox.TabStop = false;
            // 
            // FileName_Label
            // 
            FileName_Label.AutoSize = true;
            FileName_Label.Location = new System.Drawing.Point(217, 32);
            FileName_Label.Name = "FileName_Label";
            FileName_Label.Size = new System.Drawing.Size(72, 20);
            FileName_Label.TabIndex = 8;
            FileName_Label.Text = "FileName";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Honeydew;
            panel1.Controls.Add(Choose_Image_groupBox);
            panel1.Controls.Add(Pixels_tabControl);
            panel1.Controls.Add(download_groupBox);
            panel1.Controls.Add(toggle_groupBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(82, 39);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(841, 569);
            panel1.TabIndex = 27;
            // 
            // Converter_Form
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = System.Drawing.Color.Honeydew;
            ClientSize = new System.Drawing.Size(926, 664);
            Controls.Add(panel1);
            Controls.Add(down_panel);
            Controls.Add(left_panel);
            Controls.Add(MovableArea);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Converter_Form";
            Padding = new Padding(3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            SizeChanged += Form_Size_Changed;
            MovableArea.ResumeLayout(false);
            MovableArea.PerformLayout();
            down_panel.ResumeLayout(false);
            down_panel.PerformLayout();
            left_panel.ResumeLayout(false);
            download_groupBox.ResumeLayout(false);
            toggle_groupBox.ResumeLayout(false);
            toggle_groupBox.PerformLayout();
            Pixels_tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            Choose_Image_groupBox.ResumeLayout(false);
            Choose_Image_groupBox.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private System.Windows.Forms.Panel MovableArea;
        private System.Windows.Forms.Label Time_Label;
        private System.Windows.Forms.Button Button_Min;
        private System.Windows.Forms.Button ButtonMax;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button StartConverting_Button;
        private ImageConverter.CustomNumericUpDown PixSize_numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel down_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel left_panel;
        private System.Windows.Forms.Label AppName_label;
        private RButton download_roundedButton;
        private RButton showPicture_rButton;
        private System.Windows.Forms.GroupBox download_groupBox;
        private System.Windows.Forms.Button OpenFile_Button;
        private ImageConverter.DragControl dragControl;
        private ImageConverter.Toggle_Switch toggleSwitch;
        private System.Windows.Forms.Label useConvertedImg_label;
        private System.Windows.Forms.GroupBox toggle_groupBox;
        private System.Windows.Forms.TabControl Pixels_tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label pixLevel_label;
        private System.Windows.Forms.ComboBox pixLvl_comboBox;
        private ImageConverter.RButton menuExit_button;
        private GroupBox Choose_Image_groupBox;
        private Panel panel1;
        private Label FileName_Label;
    }
}

