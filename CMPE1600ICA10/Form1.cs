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
        ColorDialog dialogColor = null;
        Size dialogSize = null;
        Color drawingColor;
        public MainForm()
        {
            InitializeComponent();
        }
        //Opens color dialog
        private void UI_CheckBox_ShowColorDialog_CheckedChanged(object sender, EventArgs e)
        {

            if (UI_CheckBox_ShowColorDialog.Checked)
            {
                if (dialogColor == null)
                {

                    dialogColor = new ColorDialog();
                    dialogColor._dColorChanged = new ColorDialog.delVoidIntIntInt(CallColor);
                }
                dialogColor.Show();
            }
            else
            {
                dialogColor.Hide();
            }
        }
        //Opens size dialog
        private void UI_CheckBox_ShowSizeDialog_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_CheckBox_ShowSizeDialog.Checked)
            {
                if (dialogSize == null)
                {
                    dialogSize = new Size();
                    dialogSize._dScrollBarChanged = new delVoidInt(CallSize);
                }
                dialogSize.Show();
            }

            else
            {
                dialogSize.Hide();
            }
        }
        ////////////////////////////////////////////////Methods\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        
        //Callback from delegate for the size of a circle
        public void CallSize(int i)
        {
            UI_Label_CircleSize0.Text = i.ToString();
        }
        //Callback for delegate of color variation
        public void CallColor(int R, int G, int B)
        {
            drawingColor = Color.FromArgb(R, G, B);
            UI_Label_ColorBox.BackColor = Color.FromArgb(R, G, B);
        }

    }
}
