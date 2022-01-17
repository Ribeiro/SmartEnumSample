using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnumExample
{
    public abstract class Subscriptions : SmartEnum<Subscriptions>
    {
        public static readonly Subscriptions Free = new FreeTier();
        public static readonly Subscriptions Premium = new PremiumTier();
        public abstract double Discount { get; }

        public Subscriptions(string name, int value) : base(name, value)
        {

        }

        private sealed class FreeTier : Subscriptions
        {
            public FreeTier() : base(nameof(Free), 1)
            {
            }

            public override double Discount => .0;
        }

        private sealed class PremiumTier : Subscriptions
        {
            public PremiumTier() : base(nameof(Premium), 2)
            {
            }
            public override double Discount => .25;
        }




    }
}
