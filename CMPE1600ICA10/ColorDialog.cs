using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE1600ICA10
{
    public partial class ColorDialog : Form
    {
        public delegate void delVoidIntIntInt(int R, int G, int B);
        public delegate void delVoidVoid();
        //Global Variables
        public delVoidIntIntInt _dColorChanged = null;
        public delVoidVoid _dFormClosing = null;
        int colorValueRed = 0;
        int colorValueGreen = 0;
        int colorValueBlue = 0;
        public ColorDialog()
        {
            InitializeComponent();
        }
        //red scroll bar value
        private void UI_TrackBar_Color_Red_Scroll(object sender, EventArgs e)
        {
            if (_dColorChanged != null)
            {
                colorValueRed = UI_TrackBar_Color_Red.Value;
                UI_Label_Color_ColorBox.BackColor = System.Drawing.Color.FromArgb(colorValueRed, colorValueGreen, colorValueBlue);
                _dColorChanged.Invoke(colorValueRed, colorValueGreen, colorValueBlue);
            }
        }
        //Green scroll bar value
        private void UI_TrackBar_Color_Green_Scroll(object sender, EventArgs e)
        {
            if (_dColorChanged != null)
            {
                colorValueGreen = UI_TrackBar_Color_Green.Value;
                UI_Label_Color_ColorBox.BackColor = System.Drawing.Color.FromArgb(colorValueRed, colorValueGreen, colorValueBlue);
                _dColorChanged.Invoke(colorValueRed, colorValueGreen, colorValueBlue);
            }
        }
        //Blue Scroll value
        private void UI_TrackBar_Color_Blue_Scroll(object sender, EventArgs e)
        {
            if (_dColorChanged != null)
            {
                colorValueBlue = UI_TrackBar_Color_Blue.Value;
                UI_Label_Color_ColorBox.BackColor = System.Drawing.Color.FromArgb(colorValueRed, colorValueGreen, colorValueBlue);
                _dColorChanged.Invoke(colorValueRed, colorValueGreen, colorValueBlue);
            }
        }
        //Form is closing
        private void ColorDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_dFormClosing != null)
            {
                _dFormClosing();
            }
        }
    }
}
