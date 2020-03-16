using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Algorithm_Visualizer
{
     
    public partial class Form1 : Form
    {
        BubbleSort bs = new BubbleSort();
        private List<int> Numbers = new List<int>() { 80, 70, 60, 50, 40,30,20,10,0 };
        private Drawing drawing;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics g = Algo_Data_panel.CreateGraphics();
            drawing = new Drawing(Numbers, Algo_Data_panel.ClientRectangle,g);


        }
        private void Algo_Data_panel_Paint(object sender, PaintEventArgs e)
        {
             
            Pen RcColor = new Pen(Color.FromArgb(42, 42, 42));
            drawing.Draw_Data(RcColor);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            Graphics g = Algo_Data_panel.CreateGraphics();
            bs.SortAlgorithm(drawing,Algo_Code_panel.CreateGraphics(),Algo_Code_panel.ClientRectangle);
            label1.ForeColor = Color.Green;
            label1.Text = "Sorted";
            g.Dispose();
        }

        private void Algo_Code_panel_Paint(object sender, PaintEventArgs e)
        {
            
            bs.Draw_AlgorithmCode(-1,e.Graphics,Algo_Code_panel.ClientRectangle,drawing);
        }
    }
}
