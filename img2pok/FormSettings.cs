using img2pok.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace img2pok
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            cbGroupDataByLine.Checked = Settings.Default.GroupDataInLine;
            cbShowDataHex.Checked = Settings.Default.ShowDataHexOutput;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Settings.Default.GroupDataInLine = cbGroupDataByLine.Checked;
            Settings.Default.ShowDataHexOutput = cbShowDataHex.Checked;
            Settings.Default.Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
