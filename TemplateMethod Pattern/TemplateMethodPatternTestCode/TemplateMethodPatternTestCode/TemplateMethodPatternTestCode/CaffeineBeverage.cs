using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPatternTestCode
{
    public abstract class CaffeineBeverage
    {
        protected abstract void Brew();
        protected abstract void AddCondiments();

        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected void BoilWater()
        {
            Console.WriteLine("물 끓이는 중");
        }

        protected void PourInCup()
        {
            Console.WriteLine("컵에 따르는 중");
        }
    }
}
