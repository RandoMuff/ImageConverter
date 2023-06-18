
using System;
using System.Windows.Forms;

namespace ImageConverter
{
    partial class ImageViewer_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dragControl = new DragControl();
            MovableArea = new Panel();
            exitButton_ImageViewer = new Button();
            Button_Min = new Button();
            ButtonMax = new Button();
            ShowedImage_PctBox = new DraggablePictureBox(components);
            panel1 = new Panel();
            ImageSizeChange_TrackBar = new TrackBar();
            Lower_panel = new Panel();
            TrackBar_Plus = new RButton();
            TrackBar_Minus = new RButton();
            MovableArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShowedImage_PctBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageSizeChange_TrackBar).BeginInit();
            Lower_panel.SuspendLayout();
            SuspendLayout();
            // 
            // dragControl
            // 
            dragControl.SelectControl = MovableArea;
            // 
            // MovableArea
            // 
            MovableArea.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MovableArea.BackColor = System.Drawing.Color.LightSlateGray;
            MovableArea.Controls.Add(exitButton_ImageViewer);
            MovableArea.Controls.Add(Button_Min);
            MovableArea.Controls.Add(ButtonMax);
            MovableArea.Dock = DockStyle.Top;
            MovableArea.Location = new System.Drawing.Point(3, 3);
            MovableArea.Name = "MovableArea";
            MovableArea.Size = new System.Drawing.Size(1020, 36);
            MovableArea.TabIndex = 11;
            // 
            // exitButton_ImageViewer
            // 
            exitButton_ImageViewer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitButton_ImageViewer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            exitButton_ImageViewer.Cursor = Cursors.Hand;
            exitButton_ImageViewer.FlatStyle = FlatStyle.Popup;
            exitButton_ImageViewer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            exitButton_ImageViewer.Location = new System.Drawing.Point(972, 0);
            exitButton_ImageViewer.Margin = new Padding(3, 4, 3, 4);
            exitButton_ImageViewer.Name = "exitButton_ImageViewer";
            exitButton_ImageViewer.Size = new System.Drawing.Size(48, 36);
            exitButton_ImageViewer.TabIndex = 1;
            exitButton_ImageViewer.Text = "×";
            exitButton_ImageViewer.UseVisualStyleBackColor = false;
            exitButton_ImageViewer.Click += exitButton_ImageViewer_Click;
            // 
            // Button_Min
            // 
            Button_Min.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button_Min.BackColor = System.Drawing.SystemColors.InactiveCaption;
            Button_Min.Cursor = Cursors.Hand;
            Button_Min.FlatStyle = FlatStyle.Popup;
            Button_Min.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Button_Min.Location = new System.Drawing.Point(863, 0);
            Button_Min.Margin = new Padding(3, 4, 3, 4);
            Button_Min.Name = "Button_Min";
            Button_Min.Size = new System.Drawing.Size(48, 36);
            Button_Min.TabIndex = 5;
            Button_Min.Text = " ‒";
            Button_Min.UseVisualStyleBackColor = false;
            Button_Min.Click += Button_Min_Click;
            // 
            // ButtonMax
            // 
            ButtonMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonMax.BackColor = System.Drawing.SystemColors.InactiveCaption;
            ButtonMax.Cursor = Cursors.Hand;
            ButtonMax.FlatStyle = FlatStyle.Flat;
            ButtonMax.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ButtonMax.Location = new System.Drawing.Point(918, 0);
            ButtonMax.Margin = new Padding(3, 4, 3, 4);
            ButtonMax.Name = "ButtonMax";
            ButtonMax.Size = new System.Drawing.Size(48, 36);
            ButtonMax.TabIndex = 7;
            ButtonMax.Text = "❐";
            ButtonMax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            ButtonMax.UseVisualStyleBackColor = false;
            ButtonMax.Click += ButtonMax_Click;
            // 
            // ShowedImage_PctBox
            // 
            ShowedImage_PctBox.Cursor = Cursors.SizeAll;
            ShowedImage_PctBox.Location = new System.Drawing.Point(19, 39);
            ShowedImage_PctBox.Margin = new Padding(3, 4, 3, 4);
            ShowedImage_PctBox.Name = "ShowedImage_PctBox";
            ShowedImage_PctBox.Size = new System.Drawing.Size(790, 384);
            ShowedImage_PctBox.SizeMode = PictureBoxSizeMode.AutoSize;
            ShowedImage_PctBox.TabIndex = 6;
            ShowedImage_PctBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            panel1.Controls.Add(ShowedImage_PctBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1020, 683);
            panel1.TabIndex = 8;
            // 
            // ImageSizeChange_TrackBar
            // 
            ImageSizeChange_TrackBar.LargeChange = 1;
            ImageSizeChange_TrackBar.Location = new System.Drawing.Point(313, -4);
            ImageSizeChange_TrackBar.Margin = new Padding(3, 4, 3, 4);
            ImageSizeChange_TrackBar.Maximum = 200;
            ImageSizeChange_TrackBar.Minimum = 1;
            ImageSizeChange_TrackBar.Name = "ImageSizeChange_TrackBar";
            ImageSizeChange_TrackBar.Size = new System.Drawing.Size(303, 56);
            ImageSizeChange_TrackBar.SmallChange = 10;
            ImageSizeChange_TrackBar.TabIndex = 10;
            ImageSizeChange_TrackBar.TickFrequency = 10;
            ImageSizeChange_TrackBar.Value = 1;
            ImageSizeChange_TrackBar.Scroll += ImageSizeChange_TrackBar_Scroll;
            // 
            // Lower_panel
            // 
            Lower_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            Lower_panel.Controls.Add(ImageSizeChange_TrackBar);
            Lower_panel.Dock = DockStyle.Bottom;
            Lower_panel.Location = new System.Drawing.Point(3, 630);
            Lower_panel.Name = "Lower_panel";
            Lower_panel.Size = new System.Drawing.Size(1020, 56);
            Lower_panel.TabIndex = 12;
            // 
            // TrackBar_Plus
            // 
            TrackBar_Plus.BackColor = System.Drawing.Color.MediumSlateBlue;
            TrackBar_Plus.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            TrackBar_Plus.BorderColor = System.Drawing.Color.PaleVioletRed;
            TrackBar_Plus.BorderRadius = 20;
            TrackBar_Plus.BorderSize = 0;
            TrackBar_Plus.FlatStyle = FlatStyle.Flat;
            TrackBar_Plus.ForeColor = System.Drawing.Color.White;
            TrackBar_Plus.Location = new System.Drawing.Point(0, 0);
            TrackBar_Plus.Name = "TrackBar_Plus";
            TrackBar_Plus.Size = new System.Drawing.Size(20, 20);
            TrackBar_Plus.TabIndex = 13;
            TrackBar_Plus.TextColor = System.Drawing.Color.White;
            TrackBar_Plus.UseVisualStyleBackColor = false;
            // 
            // TrackBar_Minus
            // 
            TrackBar_Minus.BackColor = System.Drawing.SystemColors.ControlDark;
            TrackBar_Minus.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            TrackBar_Minus.BorderColor = System.Drawing.Color.PaleVioletRed;
            TrackBar_Minus.BorderRadius = 20;
            TrackBar_Minus.BorderSize = 0;
            TrackBar_Minus.FlatStyle = FlatStyle.Flat;
            TrackBar_Minus.ForeColor = System.Drawing.Color.White;
            TrackBar_Minus.Location = new System.Drawing.Point(100, 100);
            TrackBar_Minus.Name = "TrackBar_Minus";
            TrackBar_Minus.Size = new System.Drawing.Size(20, 20);
            TrackBar_Minus.TabIndex = 14;
            TrackBar_Minus.TextColor = System.Drawing.Color.White;
            TrackBar_Minus.UseVisualStyleBackColor = false;
            // 
            // ImageViewer_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonFace;
            ClientSize = new System.Drawing.Size(1026, 689);
            Controls.Add(Lower_panel);
            Controls.Add(MovableArea);
            Controls.Add(panel1);
            Controls.Add(TrackBar_Plus);
            Controls.Add(TrackBar_Minus);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new System.Drawing.Size(60, 60);
            Name = "ImageViewer_Form";
            Padding = new Padding(3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ImageViewer";
            Shown += ImageShowed_Shown;
            SizeChanged += ViewerForm_Size_Changed;
            MovableArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ShowedImage_PctBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImageSizeChange_TrackBar).EndInit();
            Lower_panel.ResumeLayout(false);
            Lower_panel.PerformLayout();
            ResumeLayout(false);
        }



        #endregion
        private ImageConverter.DragControl dragControl;
        private System.Windows.Forms.Button exitButton_ImageViewer;
        private System.Windows.Forms.Button Button_Min;
        private ImageConverter.DraggablePictureBox ShowedImage_PctBox;
        private System.Windows.Forms.Button ButtonMax;
        private System.Windows.Forms.Panel panel1;
        private Panel MovableArea;
        private TrackBar ImageSizeChange_TrackBar;
        private Panel Lower_panel;
        private ImageConverter.RButton TrackBar_Plus;
        private ImageConverter.RButton TrackBar_Minus;

    }
}