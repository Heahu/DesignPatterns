using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPatternTestCode
{
    public class Coffee : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("커피 내리는 중");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("설탕과 우유 추가 중");
        }
    }
}
