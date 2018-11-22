using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderByKiosk
{
    class BtnSet
    {
        Form form;
        string name;
        string text;
        int sizeX;
        int sizeY;
        int pointX;
        int pointY;

        public EventHandler eventHandler;

        public BtnSet(Form form, string name, string text, int sizeX, int sizeY, int pointX, int pointY, EventHandler eventHandler)
        {
            this.form = form;
            this.name = name;
            this.text = text;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.pointX = pointX;
            this.pointY = pointY;
            this.eventHandler = eventHandler;
        }

        public Form Form
        {
            get
            {
                return form;
            }
        }
        public int SizeX
        {
            get
            {
                return sizeX;
            }
        }
        public int SizeY
        {
            get
            {
                return sizeY;
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

        public string Text { get => text; }
        public string Name { get => name; }
    }
}
