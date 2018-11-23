using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderByKiosk.Draw
{
    class CheckBoxClass
    {
        public CheckBox button(CheckBoxSet checkBoxSet)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.Location = new Point(checkBoxSet.PointX, checkBoxSet.PointY);
            checkBox.Name = checkBoxSet.Name;
            checkBox.TabIndex = checkBoxSet.Tabindex;

            return checkBox;
        }
    }
}
