using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
namespace Algorithm_Visualizer
{
    class BubbleSort
    {
        private Drawing drawing = new Drawing();
        private void Draw_String(Graphics g,string Text,Font font,Color TextColor,int x,int y)
        {
            SolidBrush brush = new SolidBrush(TextColor);
            g.DrawString(Text,
                font, brush,
              x, y);
        }
        public  void Draw_AlgorithmCode(int step,Graphics g,Rectangle Coodrs, Drawing DrawingHandle)
        {
            
            Bitmap backbuffer = new Bitmap(Coodrs.Width, Coodrs.Height);
            Graphics ImgGfx = Graphics.FromImage(backbuffer);
            ImgGfx.Clear(Color.White);
            ImgGfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            switch (step)
            {
                case 0: // means for loop pass
                    Draw_String(ImgGfx, "for(int pass=0;pass<n-1;pass++)",
                        drawing.TextFont, Color.Green, 0, 0);
                    Draw_String(ImgGfx, "for(int j=0;j<n-pass-1;j++)",
                       drawing.TextFont, Color.FromArgb(42,42,42), 0, 40);
                    Draw_String(ImgGfx, "if(a[j]>a[j+1]",
                      drawing.TextFont, Color.FromArgb(42, 42, 42), 0, 80);
                    Draw_String(ImgGfx, "swap(&a[j].&a[j+1]",
                      drawing.TextFont, Color.FromArgb(42, 42, 42), 0, 120);
                    break;
                case 1: // means for  j loop 
                    Draw_String(ImgGfx, "for(int pass=0;pass<n-1;pass++)",
                        drawing.TextFont, Color.FromArgb(42,42,42), 0, 0);
                    Draw_String(ImgGfx, "for(int j=0;j<n-pass-1;j++)",
                       drawing.TextFont, Color.Green, 0, 40);
                    Draw_String(ImgGfx, "if(a[j]>a[j+1]",
                      drawing.TextFont, Color.FromArgb(42, 42, 42), 0, 80);
                    Draw_String(ImgGfx, "swap(&a[j].&a[j+1]",
                      drawing.TextFont, Color.FromArgb(42, 42, 42), 0, 120);
                    break;
                case 2: // means comparsing
                    Draw_String(ImgGfx, "for(int pass=0;pass<n-1;pass++)",
                        drawing.TextFont, Color.FromArgb(42, 42, 42), 0, 0);
                    Draw_String(ImgGfx, "for(int j=0;j<n-pass-1;j++)",
                       drawing.TextFont, Color.FromArgb(42,42,42), 0, 40);
                    Draw_String(ImgGfx, "if(a[j]>a[j+1]",
                      drawing.TextFont, Color.Green, 0, 80);
                    Draw_String(ImgGfx, "swap(&a[j].&a[j+1]",
                      drawing.TextFont, Color.FromArgb(42, 42, 42), 0, 120);
                    break;
                case 3: // means swap 
                    Draw_String(ImgGfx, "for(int pass=0;pass<n-1;pass++)",
                        drawing.TextFont, Color.FromArgb(42, 42, 42), 0, 0);
                    Draw_String(ImgGfx, "for(int j=0;j<n-pass-1;j++)",
                       drawing.TextFont, Color.Green, 0, 40);
                    Draw_String(ImgGfx, "if(a[j]>a[j+1]",
                      drawing.TextFont, Color.FromArgb(42, 42, 42), 0, 80);
                    Draw_String(ImgGfx, "swap(&a[j].&a[j+1]",
                      drawing.TextFont, Color.Green, 0, 120);
                    break;
                default:
                    Draw_String(ImgGfx, "for(int pass=0;pass<n-1;pass++)",
                       drawing.TextFont, Color.FromArgb(42, 42, 42), 0, 0);
                    Draw_String(ImgGfx, "for(int j=0;j<n-pass-1;j++)",
                       drawing.TextFont, Color.FromArgb(42, 42, 42), 0, 40);
                    Draw_String(ImgGfx, "if(a[j]>a[j+1]",
                      drawing.TextFont, Color.FromArgb(42, 42, 42), 0, 80);
                    Draw_String(ImgGfx, "swap(&a[j].&a[j+1]",
                      drawing.TextFont, Color.FromArgb(42, 42, 42), 0, 120);
                    break;
            }
            g.DrawImage(backbuffer, Coodrs);
            backbuffer.Dispose();
            ImgGfx.Dispose();
        }
        public  void SortAlgorithm(Drawing DrawingHandle,Graphics g,Rectangle coords)
        {
             
            Pen RcColor = new Pen(Color.FromArgb(42, 42, 42));
           
           
            for (int pass=0;pass< DrawingHandle.Bars.Length;pass++)
            {
                Draw_AlgorithmCode(0, g, coords, DrawingHandle);
                Thread.Sleep(100);
                
                for (int j=0;j< DrawingHandle.Bars.Length-pass-1;j++)
                {
                    Draw_AlgorithmCode(1, g, coords, DrawingHandle);
                    Thread.Sleep(100);
                    
                    if (DrawingHandle.Bars[j].val> DrawingHandle.Bars[j+1].val)
                    {
                        Draw_AlgorithmCode(2, g, coords, DrawingHandle);
                        Thread.Sleep(100);
                       
                        //Swap Value
                        int tempValue = DrawingHandle.Bars[j].val;
                        DrawingHandle.Bars[j].val = DrawingHandle.Bars[j + 1].val;
                        DrawingHandle.Bars[j + 1].val = tempValue;
                        //Swap YCoordinate
                        int YCoordinate = DrawingHandle. Bars[j].coordinates.Y;
                        DrawingHandle.Bars[j].coordinates.Y = DrawingHandle. Bars[j + 1].coordinates.Y;
                        DrawingHandle.Bars[j + 1].coordinates.Y = YCoordinate;
                        //Swap Height
                        int TempHeight = DrawingHandle.Bars[j].coordinates.Height;
                        DrawingHandle.Bars[j].coordinates.Height = DrawingHandle.Bars[j + 1].coordinates.Height;
                        DrawingHandle.Bars[j + 1].coordinates.Height = TempHeight;
                        Draw_AlgorithmCode(3, g, coords, DrawingHandle);
                        Thread.Sleep(100);
                    }
                    Thread.Sleep(50);
                    DrawingHandle.Draw_Data(RcColor);
              
                }
            }
            Draw_AlgorithmCode(-1, g, coords, DrawingHandle);
            RcColor.Dispose();
        }

    }
}
