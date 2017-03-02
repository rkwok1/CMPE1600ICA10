using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace CMPE1600ICA10
{
    public partial class MainForm : Form
    {
        CDrawer drawSpace = new CDrawer();
        Color dialogColor = null;
        Size dialogSize = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void UI_CheckBox_ShowColorDialog_CheckedChanged(object sender, EventArgs e)
        {

            if (UI_CheckBox_ShowColorDialog.Checked)
            {
                if (dialogColor == null)
                {
                    dialogColor = new Color();
                    //Requires assigning a callback method
                }
                dialogColor.Show();
            }
            else
            {
                dialogColor.Hide();
            }
        }

        private void UI_CheckBox_ShowSizeDialog_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_CheckBox_ShowSizeDialog.Checked)
            {
                if (dialogSize == null)
                {
                    dialogSize = new Size();
                    //callback required
                }
                dialogSize.Show();
            }

            else
            {
                dialogSize.Hide();
            }
        }
        ////////////////////////////////////////////////Methods\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        public void CallSize(int i)
        {
            UI_Label_CircleSize0.Text = i.ToString();
        }

    }
}
