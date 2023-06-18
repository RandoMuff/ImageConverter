using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DesignUI;
using System.Media;

namespace ImageConverter
{
    public delegate void Change(object sender, MyEventArgs e);  // delegate
    public class MyEventArgs : EventArgs
    {
        private string EventInfo;
        public MyEventArgs(string Text)
        {
            EventInfo = Text;
        }
        public string GetInfo()
        {
            return EventInfo;
        }
    }
    class CustomNumericUpDown : Control
    {
        private Button buttonUp = new Button();
        private Button buttonDown = new Button();
        private TextBox textBox = new TextBox();
        private double value;
        private Color buttonColor;
        private bool dec;
        private Timer timer;
        private double step;
        private double minValue;
        private double maxValue;

        public event Change ValueChanged;

        //Конструктор по умолчанию
        public CustomNumericUpDown()
        {
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint |
                ControlStyles.SupportsTransparentBackColor | ControlStyles.ResizeRedraw |
                ControlStyles.UserPaint, true);
            base.Width = 150;
            base.Height = 20;
            this.buttonColor = Color.Black;
            this.value = 0;
            this.step = 1;
            this.minValue = 0;
            this.maxValue = 100;
            this.textBox.Text = this.value.ToString();
            this.dec = false;
            this.buttonDown.Width = this.buttonUp.Width = 40;
            this.buttonDown.Parent = this.buttonUp.Parent = this;
            this.buttonDown.Paint += new PaintEventHandler(this.buttonDown_Paint);
            this.buttonDown.Click += new EventHandler(this.buttonDown_Click);
            this.buttonDown.MouseDown += new MouseEventHandler(this.buttonDown_Mouse_Down);
            this.buttonDown.MouseUp += new MouseEventHandler(this.buttonDown_MouseUp);

            this.buttonUp.Paint += new PaintEventHandler(this.buttonUp_Paint);
            this.buttonUp.Click += new EventHandler(this.buttonUp_Click);
            this.buttonUp.MouseDown += new MouseEventHandler(this.buttonUp_Mouse_Down);
            this.buttonUp.MouseUp += new MouseEventHandler(this.buttonUp_MouseUp);
           

            this.textBox.KeyDown += new KeyEventHandler(this.textBox_KeyDown);
            this.textBox.TextChanged += new EventHandler(this.textBox_TextChanged);
            
            this.textBox.Parent = this;
            this.textBox.Location = new Point(3, 3);
            this.buttonDown.Top = 0;
            this.textBox.BorderStyle = BorderStyle.None;
            this.textBox.MaxLength = 4;
            this.buttonUp.FlatAppearance.BorderSize = this.buttonDown.FlatAppearance.BorderSize = 1;
            this.buttonUp.FlatStyle = this.buttonDown.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Century Gothic", 12f);
            base.Invalidate();
            Timer timer = new Timer
            {
                Interval = 400
            };
            this.timer = timer;
            this.timer.Tick += new EventHandler(this.timer_Tick);


        }

       

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Можно вводить только положительные числа");
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                if(textBox.Text.Length==0)
                {
                    this.textBox.Text = "0";
                }
            }
            else if(this.textBox.Text.Length!=0)
            {
                if (double.Parse(this.textBox.Text) > this.maxValue) 
                {
                    MessageBox.Show("Слишком большое число","Недопустимое число");
                    this.textBox.Text = this.maxValue.ToString();
                    this.Value = this.maxValue;
                    
                }
                if (double.Parse(this.textBox.Text) < this.minValue)
                {
                    MessageBox.Show("Слишком маленькое число", "Недопустимое число");
                    this.textBox.Text = this.minValue.ToString();
                    this.Value = this.minValue;

                }

                this.Value = double.Parse(this.textBox.Text);

            }
               
        }
        private bool CheckValue(double value)
        {
            if(value>this.maxValue||value<this.minValue)
            {
                return false;
            }
            return true;
        }

        #region --События--
        private void timer_Tick(object sender, EventArgs e)
        {
            this.Value = this.dec ? (this.Value - 1.0) : (this.Value + 1.0);
            this.textBox.Text = this.Value.ToString();
            if (this.timer.Interval >= 50)
            {
                this.timer.Interval /= 2;
            }
        }
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                e.SuppressKeyPress = true;
                SystemSounds.Asterisk.Play();
            }
        }
        #endregion

        #region --Кнопки--
        private void buttonUp_MouseUp(object sender, MouseEventArgs e)
        {
            this.timer.Interval = 400;
            this.timer.Stop();
            this.dec = false;
        }

        private void buttonUp_Mouse_Down(object sender, MouseEventArgs e)
        {
            this.buttonUp.Focus();
            this.dec = false;
            this.Value = double.Parse(this.textBox.Text);
            this.timer.Start();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            this.Value += step;
            this.textBox.Text = this.Value.ToString();


        }

        private void buttonUp_Paint(object sender, PaintEventArgs e)
        {
            if (base.Height > 0)
            {
                this.textBox.Font = new Font("Century Gothic", base.Height * 0.5f);
                this.textBox.Location = new Point(3, (base.Height / 2) - (this.textBox.Height / 2));
            }
            e.Graphics.SmoothingMode = (SmoothingMode)SmoothingMode.HighQuality;
            float x = (this.buttonUp.Width / 2) - 1;
            float num2 = this.buttonUp.Height / 3;
            PointF tf = new PointF((x / 2f) - 2f, num2 * 1.5f);
            PointF tf2 = new PointF(((3f * x) / 2f) + 2f, num2 * 1.5f);
            PointF tf3 = new PointF(x, num2 - 2f);
            PointF tf4 = new PointF(x, (2f * num2) + 2f);

            using (Pen pen = new Pen(this.buttonColor, 3f))
            {
                e.Graphics.DrawLine(pen, tf, tf2);
                e.Graphics.DrawLine(pen, tf3, tf4);

            }
        }

        private void buttonDown_MouseUp(object sender, MouseEventArgs e)
        {
            this.timer.Interval = 400;
            this.timer.Stop();
            this.dec = false;
        }

        private void buttonDown_Mouse_Down(object sender, MouseEventArgs e)
        {
            this.buttonDown.Focus();
            this.dec = true;
            this.Value = double.Parse(this.textBox.Text);
            this.timer.Start();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            this.Value -= step;
            this.textBox.Text = this.Value.ToString();
        }

        private void buttonDown_Paint(object sender, PaintEventArgs e)
        {
            float num = this.buttonUp.Width / 3;
            float num2 = this.buttonUp.Height / 3;
            PointF tf = new PointF((this.buttonDown.Width / 2) - (num / 2f), num2 * 1.5f);
            PointF tf2 = new PointF(tf.X + num, num2 * 1.5f);
            using (Pen pen = new Pen(this.buttonColor, 3f))
            {
                e.Graphics.DrawLine(pen, tf, tf2);
            }

        }
        #endregion

        #region --Методы--
        protected override void OnFontChanged(EventArgs e)
        {
            this.textBox.Font = this.Font;
            base.Height = this.Font.Height * 2;
            base.OnFontChanged(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.buttonUp.Left = (base.Width - (this.buttonUp.Width * 2)) + 1;
            this.buttonDown.Left = base.Width - this.buttonDown.Width;
            this.buttonDown.Top = 0;
            this.buttonUp.Height = this.buttonDown.Height = base.Height - 1;
            e.Graphics.FillRectangle(Brushes.White, 0, 0, base.Width, base.Height);
            e.Graphics.DrawRectangle(Pens.Gray, 0, 0, base.Width - 1, base.Height - 1);
            this.textBox.Width = (base.Width - (2 * this.buttonDown.Width)) - 4;

            using (Pen pen = new Pen(Color.Black, 2f))
            {
                base.OnPaint(e);
            }

        }
      
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        #endregion

        #region --Свойства--
        public Color ButtonColor
        {
            get => this.buttonColor;
            set
            {
                this.buttonColor = value;
                base.Invalidate();

            }
        }
        public double Value
        {
            get => this.value;
            set
            {
                if(this.CheckValue(value))
                { 
                    this.value = value;
                    ValueChanged?.Invoke(this, new MyEventArgs("You've entered " +
                      value.ToString()));
                }
             
                this.textBox.Text = this.value.ToString();
                base.Invalidate();
            }
        }

        public int ButtonUpDownWidth
        {
            get => this.buttonDown.Width = this.buttonUp.Width;
            set
            {
                this.buttonDown.Width = this.buttonUp.Width = value;
                Invalidate();
            }
        }
        public double Step
        {
            get => this.step;
            set
            {
                this.step = value;
            }
        }
        public double MiminumValue
        {
            get => this.minValue;
            set
            {
                this.minValue = value;
            }
        }
        public double MaximumValue
        {
            get => this.maxValue;
            set
            {
                this.maxValue = value;
            }
        }
        #endregion
    }
}
