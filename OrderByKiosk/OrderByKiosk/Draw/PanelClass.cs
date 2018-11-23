using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderByKiosk
{
    class PanelClass
    {
        public Panel Panel(PanelSet p)
        {
            Panel panel = new Panel();
            panel.Location = new Point(p.PointX, p.PointY);
            panel.Size = new Size(p.SizeX, p.SizeY);
            panel.Name = p.Name;
            panel.BackColor = p.Backcolor;
            return panel;
        }
    }
}
