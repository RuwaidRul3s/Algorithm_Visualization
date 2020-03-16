using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
namespace Algorithm_Visualizer
{
    class Drawing
    {
        private Graphics gfx;
        public  DataBar[] Bars = new DataBar[9];
        private   Rectangle CanvasRectangle;
        private StringFormat sf = new StringFormat();
        public SolidBrush TextColor = new SolidBrush(Color.FromArgb(42, 42, 42));
        public Font TextFont = new Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Pixel);
        public  struct DataBar
        {
            public Rectangle coordinates;
            public int val;
        }
        public  void Draw_Data(Pen RectangleColor)
        {

            Bitmap backbuffer = new Bitmap(CanvasRectangle.Width, CanvasRectangle.Height);
            Graphics backbufferG = Graphics.FromImage(backbuffer);
            backbufferG.TextRenderingHint = TextRenderingHint.AntiAlias;
            backbufferG.Clear(Color.White);
            foreach (DataBar item in Bars)
            {
                backbufferG.DrawRectangle(RectangleColor, item.coordinates);
                backbufferG.DrawString(item.val.ToString(), TextFont, TextColor,
                    item.coordinates, sf);
            }
            gfx.DrawImage(backbuffer, CanvasRectangle);
            backbuffer.Dispose();
            backbufferG.Dispose();
        }
       
        public Drawing(List<int>Numbers, Rectangle CanvasRc,Graphics g)
        {
            gfx = g;
            CanvasRectangle = new Rectangle(CanvasRc.X, CanvasRc.Y,
                CanvasRc.Width, CanvasRc.Height);
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            int Xpos = 20;
            for (int index = 0;index<Numbers.Count;index++)
            {
                Rectangle rc = new Rectangle(Xpos, (CanvasRectangle.Height / 2) -Numbers[index],
                    40, Numbers[index] + 120);
                DataBar bar = new DataBar();
                bar.val = Numbers[index];
                bar.coordinates = rc;
                Bars[index] = bar;
                Xpos += 45;
            }
        }
        public Drawing()
        {

        }
    }
}
