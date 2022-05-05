using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class BasicAccessories : CarAccessoriesDecorator
    {
        public BasicAccessories(ICar aCar)
        : base(aCar)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + ",Basic Accessories Package";

        }

        public override double GetCost()
        {
            return base.GetCost() + 2000.0;
        }
    }

    /// <summary>   
    /// Concrete Decorator   
    /// </summary>   
    public class AdvancedAccessories : CarAccessoriesDecorator
    {
        public AdvancedAccessories(ICar aCar)
        : base(aCar)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + ",Advanced Accessories Package";
        }

        public override double GetCost()
        {
            return base.GetCost() + 10000.0;
        }
    }

    /// <summary>   
    /// Concrete Decorator   
    /// </summary>   
    public class SportsAccessories : CarAccessoriesDecorator
    {
        public SportsAccessories(ICar aCar)
        : base(aCar)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + ",Sports Accessories Package";
        }

        public override double GetCost()
        {
            return base.GetCost() + 15000.0;
        }
    }
}
