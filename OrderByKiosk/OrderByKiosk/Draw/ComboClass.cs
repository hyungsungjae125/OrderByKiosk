using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderByKiosk
{
    class ComboClass
    {
        public ComboBox Combo(ComboSet combo)
        {
            ComboBox cb = new ComboBox();
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.FormattingEnabled = true;
            cb.Location = new Point(combo.PointX,combo.PointY);
            cb.Size = new Size(combo.SizeX, combo.SizeY);
            return cb;
        }

    }
}
