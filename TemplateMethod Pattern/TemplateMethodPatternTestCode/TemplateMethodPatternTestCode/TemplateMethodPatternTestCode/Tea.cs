using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPatternTestCode
{
    public class Tea : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("찻잎을 우려내는 중");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("레몬 추가 중");
        }
    }
}
