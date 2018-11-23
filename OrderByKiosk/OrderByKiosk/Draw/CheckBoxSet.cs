using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderByKiosk.Draw
{
    class CheckBoxSet
    {
        Form form;
        string name;
        int pointX;
        int pointY;
        int tabindex;

        public CheckBoxSet(Form form, string name, int pointX, int pointY, int tabindex)
        {
            this.form = form;
            this.name = name;
            this.pointX = pointX;
            this.pointY = pointY;
            this.tabindex = tabindex;
        }

        public Form Form
        {
            get
            {
                return form;
            }
        }
        public int PointX
        {
            get
            {
                return pointX;
            }
        }
        public int PointY
        {
            get
            {
                return pointY;
            }
        }
        public string Name { get => name; }
        public int Tabindex { get => tabindex; }
    }
}
