using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Tools;
using Microsoft.Office.Interop.Outlook;


namespace ElKalodia_Lab
{
    public class InspectorWrapper
    {
        private Inspector inspector;
        private CustomTaskPane taskPane1;
        private CustomTaskPane taskPane2;

        public InspectorWrapper(Inspector Inspector)
        {
            inspector = Inspector;
            ((InspectorEvents_Event)inspector).Close +=
                new InspectorEvents_CloseEventHandler(InspectorWrapper_Close);

            taskPane1 = Globals.ThisAddIn.CustomTaskPanes.Add(
                new TaskPane1(), "My task pane 1", inspector);
            taskPane1.VisibleChanged += new EventHandler(TaskPane_VisibleChanged1);
            taskPane2 = Globals.ThisAddIn.CustomTaskPanes.Add(
                new TaskPane2(), "My task pane 2", inspector);
            taskPane2.VisibleChanged += new EventHandler(TaskPane_VisibleChanged2);
        }
        void TaskPane_VisibleChanged1(object sender, EventArgs e)
        {
            Globals.Ribbons[inspector].CustomForms.toggleButton3.Checked =
                taskPane1.Visible;
        }
        void TaskPane_VisibleChanged2(object sender, EventArgs e)
        {

            Globals.Ribbons[inspector].CustomForms.toggleButton4.Checked =
                taskPane2.Visible;
        }
        void InspectorWrapper_Close()
        {
            if (taskPane1 != null)
            {
                Globals.ThisAddIn.CustomTaskPanes.Remove(taskPane1);
            }

            taskPane1 = null;
            if (taskPane2 != null)
            {
                Globals.ThisAddIn.CustomTaskPanes.Remove(taskPane2);
            }

            taskPane2 = null;
            Globals.ThisAddIn.InspectorWrappers.Remove(inspector);
            ((InspectorEvents_Event)inspector).Close -=
                new InspectorEvents_CloseEventHandler(InspectorWrapper_Close);

            
            inspector = null;
        }

        public CustomTaskPane CustomTaskPane1
        {
            get
            {
                return taskPane1;
            }
        }
        public CustomTaskPane CustomTaskPane2
        {
            get
            {
                return taskPane2;
            }
        }
    }
}
