using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Aries_Card
{
    public partial class backScreen : Form
    {
        public backScreen()
        {
            InitializeComponent();
        }

        private void formatBack_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.White, 2);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            formGraphics.Clear(Color.Black);

            formGraphics.DrawPie(drawPen, 210, 335, 10, 10, 30, 360);
            formGraphics.FillPie(drawBrush, 210, 335, 10, 10, 30, 360);
            Thread.Sleep(500);

            formGraphics.DrawPie(drawPen, 210, 230, 10, 10, 30, 360);
            formGraphics.FillPie(drawBrush, 210, 230, 10, 10, 30, 360);
            Thread.Sleep(500);

            formGraphics.DrawPie(drawPen, 175, 150, 10, 10, 30, 360);
            formGraphics.FillPie(drawBrush, 175, 150, 10, 10, 30, 360);
            Thread.Sleep(500);

            formGraphics.DrawPie(drawPen, 245, 150, 10, 10, 30, 360);
            formGraphics.FillPie(drawBrush, 245, 150, 10, 10, 30, 360);
            Thread.Sleep(500);

            formGraphics.DrawPie(drawPen, 130, 80, 10, 10, 30, 360);
            formGraphics.FillPie(drawBrush, 130, 80, 10, 10, 30, 360);
            Thread.Sleep(500);

            formGraphics.DrawPie(drawPen, 290, 80, 10, 10, 30, 360);
            formGraphics.FillPie(drawBrush, 290, 80, 10, 10, 30, 360);
            Thread.Sleep(500);

            formGraphics.DrawPie(drawPen, 70, 70, 10, 10, 30, 360);
            formGraphics.FillPie(drawBrush, 70, 70, 10, 10, 30, 360);
            Thread.Sleep(500);

            formGraphics.DrawPie(drawPen, 360, 70, 10, 10, 30, 360);
            formGraphics.FillPie(drawBrush, 360, 70, 10, 10, 30, 360);
            Thread.Sleep(500);

            formGraphics.DrawPie(drawPen, 30, 110, 10, 10, 30, 360);
            formGraphics.FillPie(drawBrush, 30, 110, 10, 10, 30, 360);
            Thread.Sleep(500);

            formGraphics.DrawPie(drawPen, 400, 110, 10, 10, 30, 360);
            formGraphics.FillPie(drawBrush, 400, 110, 10, 10, 30, 360);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 215, 340, 215, 235);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 215, 235, 180, 155);
            formGraphics.DrawLine(drawPen, 215, 235, 250, 155);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 180, 155, 135, 85);
            formGraphics.DrawLine(drawPen, 250, 155, 295, 85);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 135, 85, 75, 75);
            formGraphics.DrawLine(drawPen, 295, 85, 365, 75);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 75, 75, 35, 115);
            formGraphics.DrawLine(drawPen, 365, 75, 405, 115);
            Thread.Sleep(500);

        }
    }
}
