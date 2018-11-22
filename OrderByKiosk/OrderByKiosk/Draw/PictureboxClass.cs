using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderByKiosk
{
    class PictureboxClass
    {
        public PictureBox pictureBox(PictureboxSet pictureboxSet)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = (Bitmap)OrderByKiosk.Properties.Resources.ResourceManager.GetObject(pictureboxSet.ImageRoute);
            pictureBox.Location = new Point(pictureboxSet.PointX, pictureboxSet.PointY);
            pictureBox.Size = new Size(pictureboxSet.SizeX, pictureboxSet.SizeY);

            return pictureBox;
        }
    }
}
