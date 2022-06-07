namespace Vulcan
{
    partial class VulcanSettingsFrm
    {
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(12, 12);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(260, 237);
            this.propertyGrid1.TabIndex = 0;
            this.propertyGrid1.Click += new System.EventHandler(this.propertyGrid1_Click);
            // 
            // VulcanSettingsFrm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "VulcanSettingsFrm";
            this.Text = "Vulcan Settings";
            this.ResumeLayout(false);
        }
    
         private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}