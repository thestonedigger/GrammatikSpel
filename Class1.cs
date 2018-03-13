using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frågesport
{
    class PopUp
    {
        public string message;
        public string caption;
        public MessageBoxButtons buttons;
        public MessageBoxIcon icon;
        public MessageBoxDefaultButton defaultButtons;
        public DialogResult result;
    }
    static class SlidePanel
    {
      static public bool hidden = false;
      static public int width = 0;
    }
    static class LayoutPanelHandling
    {
       static public FlowLayoutPanel currentLayoutPanel;
    }
}
