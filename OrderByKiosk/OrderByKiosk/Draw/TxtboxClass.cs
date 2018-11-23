using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderByKiosk.Draw
{
    class TxtboxClass
    {
        public TextBox Textbox(TxtboxSet txtboxSet)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(txtboxSet.PointX, txtboxSet.PointY);
            textBox.Size = new Size(txtboxSet.SizeX, txtboxSet.SizeY);
            textBox.Name = txtboxSet.Name;
            return textBox;
        }
    }
}
