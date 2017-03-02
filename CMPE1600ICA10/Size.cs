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
    //Defining delegate type with void return and arguments
    public delegate void delVoidVoid();
    public delegate int delVoidInt(int i);
    public partial class Size : Form
    {//Global Variables
    int sizeCircle;

        //
        public delVoidVoid _dWindowHidden = null;
        public delVoidInt _dScrollBarChanged = null;
        public Size()
        {
            InitializeComponent();
        }

        private void UI_TrackBar_Size_MaxMin_Scroll(object sender, EventArgs e)
        {
            if (_dScrollBarChanged != null)
            {
                sizeCircle = UI_TrackBar_Size_MaxMin.Value;
                _dScrollBarChanged.Invoke(sizeCircle);
            }
        }

        private void Size_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_dWindowHidden != null)
            {
                _dWindowHidden();
            }
        }
    }
}
