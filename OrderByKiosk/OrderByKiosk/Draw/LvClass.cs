using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderByKiosk
{
    class LvClass
    {
        public ListView Lv(LvSet lvSet)
        {
            ListView lv = new ListView();
            lv.View = View.Details;
            lv.GridLines = true;
            lv.Location = new Point(lvSet.PointX, lvSet.PointY);
            lv.Size = new Size(lvSet.SizeX, lvSet.SizeY);
            lv.TabIndex = 0;
            return lv;
        }
    }
}
