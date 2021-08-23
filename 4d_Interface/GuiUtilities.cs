using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4d_Interface
{
    static class GuiUtilities
    {
        public delegate void UpdateTextCallback(string text);
        private delegate void UpdateTextEventHandler(Label label, string value);
        private delegate void UpdateButtonEventHandler(Button button, string value);

        public static void UpdateButton(Button button, string value)
        {
            if (button.InvokeRequired)
            {
                button.BeginInvoke(
                    new UpdateTextEventHandler(UpdateText),
                    new object[] { button, value });
            }
            else
            {
                button.Text = value;
            }
        }

        public static void UpdateText(Label label, string value)
        {
            if (label.InvokeRequired)
            {
                label.BeginInvoke(
                    new UpdateTextEventHandler(UpdateText),
                    new object[] { label, value });
            }
            else
            {
                label.Text = value;
            }
        }
    }
}
