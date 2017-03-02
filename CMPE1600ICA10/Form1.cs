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
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void UI_CheckBox_ShowColorDialog_CheckedChanged(object sender, EventArgs e)
        {
            Color dialogColor = new Color();
            dialogColor.Show();
        }

        private void UI_CheckBox_ShowSizeDialog_CheckedChanged(object sender, EventArgs e)
        {
            Size dialogSize = new Size();
            dialogSize.Show();

        }
    }
}
