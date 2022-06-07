using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetainerVentures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            propertyGrid1.SelectedObject = RetainerVentures.RetainerVentureSettings;
            propertyGrid1.Update();
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}