using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools;
using Office = Microsoft.Office.Core; 

namespace ElKalodia_Lab
{
    public partial class CustomForms
    {
        private Microsoft.Office.Interop.Outlook.Inspector inspector;
        private CustomTaskPane taskPane1;
        private CustomTaskPane taskPane2;

        //public object GetFormRegionStorage(string FormRegionName,   object Item, 
        //int LCID,
        //Outlook.OlFormRegionMode FormRegionMode, 
        //Outlook.OlFormRegionSize FormRegionSize) 
        //    public void BeforeFormRegionShow(object Item, Outlook.FormRegion FormRegion) 
       
        private void CustomForms_Load(object sender, RibbonUIEventArgs e)
        {
            
        }
        private void toggleButton3_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Inspector inspector = (Outlook.Inspector)e.Control.Context;
            InspectorWrapper inspectorWrapper = Globals.ThisAddIn.InspectorWrappers[inspector];
            CustomTaskPane taskPane = inspectorWrapper.CustomTaskPane1;
            if (taskPane != null)
            {
                taskPane.Visible = ((RibbonToggleButton)sender).Checked;
            }
        }
        private void toggleButton4_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.Inspector inspector = (Outlook.Inspector)e.Control.Context;
            InspectorWrapper inspectorWrapper = Globals.ThisAddIn.InspectorWrappers[inspector];
            CustomTaskPane taskPane = inspectorWrapper.CustomTaskPane2;
            if (taskPane != null)
            {
                taskPane.Visible = ((RibbonToggleButton)sender).Checked;
            }
        }
    }
}
