using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            formGraphics.Clear(Color.Black);
            formGraphics.DrawPie(drawPen, 20, 20, 20, 20, 30, 360);
        }
    }
}
