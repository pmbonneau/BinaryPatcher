using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryPatcherUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPatchFile_Click(object sender, EventArgs e)
        {
            BinaryPatcherLib.BinaryPatcher Patcher = new BinaryPatcherLib.BinaryPatcher("Sample.xml","testfile.bin");
            Patcher.ApplyPatchToFile("Sample Patch");
        }
    }
}
