using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderByKiosk
{
    class BtnClass
    {
        public Button button(BtnSet btnSet)
        {
            Button button = new Button();
            button.DialogResult = DialogResult.OK;
            button.Size = new Size(btnSet.SizeX, btnSet.SizeY);
            button.Location = new Point(btnSet.PointX, btnSet.PointY);
            button.BackColor = Color.Gainsboro;
            button.Text = btnSet.Text;

            button.Click += btnSet.eventHandler;

            return button;
        }
    }
}
