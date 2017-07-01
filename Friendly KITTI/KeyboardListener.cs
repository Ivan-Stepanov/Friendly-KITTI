using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Friendly_KITTI
{
    public partial class Form1 : Form
    {
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // keyboard buttons 1-0 will select Object Classes according to their index in the list
            if (e.KeyChar == "1"[0] && currentObjectClassList.Count > 0) currentObjectClassList[0].radioButton.Checked = true ;
            if (e.KeyChar == "2"[0] && currentObjectClassList.Count > 1) currentObjectClassList[1].radioButton.Checked = true;
            if (e.KeyChar == "3"[0] && currentObjectClassList.Count > 2) currentObjectClassList[2].radioButton.Checked = true;
            if (e.KeyChar == "4"[0] && currentObjectClassList.Count > 3) currentObjectClassList[3].radioButton.Checked = true;
            if (e.KeyChar == "5"[0] && currentObjectClassList.Count > 4) currentObjectClassList[4].radioButton.Checked = true;
            if (e.KeyChar == "6"[0] && currentObjectClassList.Count > 5) currentObjectClassList[5].radioButton.Checked = true;
            if (e.KeyChar == "7"[0] && currentObjectClassList.Count > 6) currentObjectClassList[6].radioButton.Checked = true;
            if (e.KeyChar == "8"[0] && currentObjectClassList.Count > 7) currentObjectClassList[7].radioButton.Checked = true;
            if (e.KeyChar == "9"[0] && currentObjectClassList.Count > 8) currentObjectClassList[8].radioButton.Checked = true;
            if (e.KeyChar == "0"[0] && currentObjectClassList.Count > 9) currentObjectClassList[9].radioButton.Checked = true;

            if (e.KeyChar == " "[0]) NextImage();
            if (e.KeyChar == "d"[0]) buttonDeleteSelectedRectangle_Click(null, null);
        }        
    }
}
