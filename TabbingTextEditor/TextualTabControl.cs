using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabbingTextEditor
{
    class TextualTabControl : TabControl
    {
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            e.Control.Controls.Add(CreateTextBox());
        }

        private TextBox CreateTextBox()
        {
            TextBox textBox = new TextBox();
            textBox.Multiline = true;
            textBox.Dock = DockStyle.Fill;
            // Add additional configurations here
            return textBox;
        }

        public string SelectedTextBoxText
        {
            get { return this.SelectedTab.Controls[0].Text; }
        }

        public bool IsSelectedTextBoxMultiline
        {
            get { return ((TextBox)this.SelectedTab.Controls[0]).Multiline; }
        }
    }
}
