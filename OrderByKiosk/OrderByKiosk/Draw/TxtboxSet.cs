using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderByKiosk.Draw
{
    class TxtboxSet
    {
        Form form;

        string name;
        int sizeX, sizeY, pointX, pointY;

        public TxtboxSet(Form form, string name,  int sizeX, int sizeY, int pointX, int pointY)
        {
            this.form = form;
            this.name = name;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.pointX = pointX;
            this.pointY = pointY;
        }

        public Form Form { get => form; }
        public string Name { get => name; }
        public int SizeX { get => sizeX; }
        public int SizeY { get => sizeY; }
        public int PointX { get => pointX; }
        public int PointY { get => pointY; }
    }
}
