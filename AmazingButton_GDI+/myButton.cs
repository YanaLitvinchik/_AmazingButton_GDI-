using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AmazingButton_GDI_
{
    class myButton : Button
    {
        protected override void OnClick(EventArgs e)
        {
          //  base.OnClick(e);
            MessageBox.Show("Hello!");
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath gp = new GraphicsPath();
            //Создаем новый прямоуголник с размерами кнопки
            Rectangle rect = this.ClientRectangle;
            //уменьшаем размеры прямоуголника
            rect.Inflate(-3, -3);
            //создаем эллипс
            gp.AddEllipse(rect);
            Region rr = new System.Drawing.Region(gp);
            
    //        rr.Exclude(new Rectangle(0, 0, 100, 100));
            this.Region = rr;
            pevent.Graphics.FillEllipse(Brushes.Purple, rect);
            //рисуем рамку для овальной кнопки
           pevent.Graphics.DrawEllipse(new Pen(Color.Black, 3),rect);


        }
    }
}
