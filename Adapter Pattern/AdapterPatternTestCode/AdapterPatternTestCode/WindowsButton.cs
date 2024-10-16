using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternTestCode
{
    public class WindowsButton
    {
        public void ClickBUtton()
        {
            MessageBox.Show("버튼 클릭");
        }

        public void SetButtonLabel(String label)
        {

        }
    }
}
