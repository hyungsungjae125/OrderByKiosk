using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatermarkTextbox
{
    public partial class WagermarkTextbox: TextBox
    {
        public WagermarkTextbox()
        {
            InitializeComponent();
        }

        private string _watermarktext;
        private bool _multiline = false;

        public string WatermarkText
        {
            get { return _watermarktext; }
            set
            {
                _watermarktext = value;
                GetSetWatermark();
            }
        }
        [Browsable(false)]
        public new bool Multiline
        {
            get { return _multiline; }
            set { _multiline = false; }
        }

        private void GetSetWatermark()
        {
            if ((this.Text == WatermarkText) || (this.Text == string.Empty))
            {
                this.ForeColor = Color.Gray;
                this.Text = WatermarkText;
            }
            else
            {
                this.ForeColor = Color.Black;
            }
        }

        private void WagermarkTextBos_Enter(object sender,EventArgs e)
        {
            if ((this.Text == WatermarkText) || (this.Text == string.Empty))
            {
                this.Text = string.Empty;
                this.ForeColor = Color.Black;
            }
        }

        private void WagermarkTextbox_Leave(object sender, EventArgs e)
        {
            GetSetWatermark();
        }
    }
}
