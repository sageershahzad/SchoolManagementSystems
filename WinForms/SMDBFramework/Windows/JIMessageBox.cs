using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMDBFramework.Windows
{
    public class JIMessageBox
    {
        public static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowErrorMessage(string message, string title)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowSuccessMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
