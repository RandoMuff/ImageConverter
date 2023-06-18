using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DesignUI;
using System.Diagnostics;

namespace ImageConverter
{
    [DefaultEvent("CheckedChanged")]
    class Toggle_Switch : Control
    {
        #region -- Свойства --

        public bool Checked
        {
            get => _checked;
            set
            {
                _checked = value;

                SwitchToggle();     
            }
        }
        public int AnimationSpeed
        {
            get => ToggleAnim.StepDivider;
            set { ToggleAnim.StepDivider = value; }
        }

        private bool _checked = false;
        public Color BackColorON { get; set; } = Color.DarkGreen;
        public Color BackColorOFF { get; set; } = Color.Red;

        public Color BackColorUnenabled { get; set; } = Color.Red;

        #endregion

        #region -- Переменные --

        private Rectangle rectToggleHolder;

        private int TogglePosX_ON;
        private int TogglePosX_OFF;

        private Animation ToggleAnim = new Animation();

        #endregion

        #region -- События --

        [Description("Возникает при каждом изменении свойства Checked")]
        public event OnCheckedChangedHandler CheckedChanged;
        public delegate void OnCheckedChangedHandler(object sender);

        #endregion

        public Toggle_Switch()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Font = new Font("Verdana", 9F, FontStyle.Regular);
            BackColor = Color.White;

            Cursor = Cursors.Hand;

            Size = new Size(40, 15);

            rectToggleHolder = new Rectangle(1, 1, Width - 5, Height - 5);

            TogglePosX_OFF = rectToggleHolder.X;
            TogglePosX_ON = rectToggleHolder.Right - rectToggleHolder.Height;

            ToggleAnim.StepDivider = 8 ;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            ToggleAnim.Value = Checked == true ? TogglePosX_ON : TogglePosX_OFF;

            TogglePosX_OFF = rectToggleHolder.X;
            TogglePosX_ON = rectToggleHolder.Right - rectToggleHolder.Height;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
           
            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);

            Pen penToggleHolder = new Pen(Color.DarkGray, 3);
            Pen penToggle = new Pen(Color.DarkGray, 3);

            GraphicsPath gpathToggle = Drawer.RoundedRectangle(rectToggleHolder, rectToggleHolder.Height);
            Rectangle rectToggle = new Rectangle((int)ToggleAnim.Value, rectToggleHolder.Y, rectToggleHolder.Height, rectToggleHolder.Height);

            graph.DrawPath(penToggleHolder, gpathToggle);

            if (Checked == true)
            {
                if (Animator.IsWork == false)
                    rectToggle.Location = new Point(TogglePosX_ON, rectToggleHolder.Y);

                graph.FillPath(new SolidBrush(BackColorON), gpathToggle);
            }
            else
            {
                if (Animator.IsWork == false)
                {
                    rectToggle.Location = new Point(TogglePosX_OFF, rectToggleHolder.Y);
                }
                if (this.Enabled) //Если кнопку можно использовать
                {
                    graph.FillPath(new SolidBrush(BackColorOFF), gpathToggle);
                }
                else
                {
                    graph.FillPath(new SolidBrush(BackColorUnenabled), gpathToggle);
                }
            }

            graph.DrawEllipse(penToggle, rectToggle);
            graph.FillEllipse(new SolidBrush(BackColor), rectToggle);

           

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            Checked = !Checked;

        }

        private void SwitchToggle()
        {
         
            if (Checked == true)
            {
                ToggleAnim = new Animation("Toggle_" + Handle, Invalidate, ToggleAnim.Value, TogglePosX_ON);
            }
            else
            {
                ToggleAnim = new Animation("Toggle_" + Handle, Invalidate, ToggleAnim.Value, TogglePosX_OFF);
            }
           
            
            Animator.Request(ToggleAnim, true);
            Animator.Start();
            CheckedChanged?.Invoke(this);

         //   Invalidate();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            rectToggleHolder = new Rectangle(1, 1, Width - 5, Height - 5);


            TogglePosX_OFF = rectToggleHolder.X;
            TogglePosX_ON = rectToggleHolder.Right - rectToggleHolder.Height;
        }
    }
}
