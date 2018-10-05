using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;


namespace ElKalodia_Lab
{
    public partial class TaskPane1 : UserControl
    {
        public TaskPane1()
        {
            InitializeComponent();
        }

        private void Index_Changed(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = cmb.SelectedIndex;
            string selectedValue = (string)cmb.SelectedItem;
            var Inspector = Globals.ThisAddIn.Application.ActiveInspector();

            Outlook.MailItem mailItem = Inspector.CurrentItem as Outlook.MailItem;

            string itemto = "";

            if (selectedValue=="A")
            {
                itemto = "info@creative-ideas.gr";
            }
            else if (selectedValue == "B")
            {
                itemto = "support@creative-ideas.gr";

            }
            if (mailItem != null)
            {
                if (mailItem.EntryID == null)
                {

                    mailItem.To = itemto;
                }

            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            var Inspector = Globals.ThisAddIn.Application.ActiveInspector();

            Outlook.MailItem mailItem = Inspector.CurrentItem as Outlook.MailItem;

            if (mailItem != null)
            {
                if (mailItem.EntryID == null)
                {
                    mailItem.Body =textBox1.Text;
                }

            }
        }
    }
}
