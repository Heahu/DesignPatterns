using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternTestCode
{
    public interface IButton
    {
        void Click();
        void SetLabel(string label);
    }
}
