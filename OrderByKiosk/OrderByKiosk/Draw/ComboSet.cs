using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderByKiosk
{
    class ComboSet
    {
        Form form;

        string text;
        int sizeX, sizeY, pointX, pointY;

        public ComboSet(Form form,string text,int sizeX,int sizeY,int pointX,int pointY)
        {
            this.form = form;
            this.text = text;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.pointX = pointX;
            this.pointY = pointY;
        }

        public Form Form { get => form; }
        public string Text { get => text; }
        public int SizeX { get => sizeX; }
        public int SizeY { get => sizeY; }
        public int PointX { get => pointX; }
        public int PointY { get => pointY; }
    }
}
