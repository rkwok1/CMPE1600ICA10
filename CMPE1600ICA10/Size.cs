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
    public delegate void delVoidInt(int i);
    public partial class Size : Form
    {
        //Global Variables
    int sizeCircle = 0;

        
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
            //is the dialo being closed by the user?
            if(e.CloseReason == CloseReason.UserClosing)
            {
                //CheckBox to ensure that the delegate reference has been initialized
                if (null != _dWindowHidden)
                {
                    _dWindowHidden();
                }
            }
            //stop close from happening and hidesa it instead
            e.Cancel = true;
            Hide();
        }
    }
}
