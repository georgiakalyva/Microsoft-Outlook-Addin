namespace ElKalodia_Lab
{
    partial class CustomForms : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public CustomForms()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomForms));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.toggleButton3 = this.Factory.CreateRibbonToggleButton();
            this.toggleButton4 = this.Factory.CreateRibbonToggleButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabNewMailMessage";
            this.tab1.Groups.Add(this.group1);
            resources.ApplyResources(this.tab1, "tab1");
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.toggleButton3);
            this.group1.Items.Add(this.toggleButton4);
            resources.ApplyResources(this.group1, "group1");
            this.group1.Name = "group1";
            // 
            // toggleButton3
            // 
            resources.ApplyResources(this.toggleButton3, "toggleButton3");
            this.toggleButton3.Name = "toggleButton3";
            this.toggleButton3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.toggleButton3_Click);
            // 
            // toggleButton4
            // 
            resources.ApplyResources(this.toggleButton4, "toggleButton4");
            this.toggleButton4.Name = "toggleButton4";
            this.toggleButton4.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.toggleButton4_Click);
            // 
            // CustomForms
            // 
            this.Name = "CustomForms";
            this.RibbonType = "Microsoft.Outlook.Mail.Compose, Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.CustomForms_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();

        }

        #endregion

      
        public Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButton3;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButton4;
    }

    partial class ThisRibbonCollection
    {
        internal CustomForms CustomForms
        {
            get { return this.GetRibbon<CustomForms>(); }
        }
    }
}
