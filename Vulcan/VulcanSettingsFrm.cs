using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vulcan
{
    public partial class VulcanSettingsFrm : Form
    {
        public VulcanSettingsFrm()
        {
            InitializeComponent();
            propertyGrid1.SelectedObject = VulcanSettings.Instance;
            propertyGrid1.Update();
        }

        private void VulcanSettingsFrm_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = VulcanSettings.Instance;
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}