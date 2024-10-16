using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternTestCode
{
    public class ButtonAdapter : IButton
    {
        private readonly WindowsButton windowsButton;

        public ButtonAdapter(WindowsButton windowsButton)
        {
            this.windowsButton = windowsButton;
        }

        public void Click()
        {
            windowsButton.ClickBUtton();
        }

        public void SetLabel(string label)
        {
            windowsButton.SetButtonLabel(label);
        }
    }
}
