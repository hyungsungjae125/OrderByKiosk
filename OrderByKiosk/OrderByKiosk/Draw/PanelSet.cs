using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OrderByKiosk
{
    class PanelSet
    {
        Form form;

        string name;
        int sizeX, sizeY, pointX, pointY;
        Color backcolor;

        public PanelSet(Form form, string name,  int sizeX, int sizeY, int pointX, int pointY,Color backcolor)
        {
            this.form = form;
            this.name = name;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.pointX = pointX;
            this.pointY = pointY;
            this.backcolor = backcolor;
        }

        public Form Form { get => form; }
        public string Name { get => name; }
        public int SizeX { get => sizeX; }
        public int SizeY { get => sizeY; }
        public int PointX { get => pointX; }
        public int PointY { get => pointY; }
        public Color Backcolor { get => backcolor; }
    }
}
