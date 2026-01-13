using CourierCodeChallenge.Discount.Impl.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierCodeChallenge.Discount.Impl
{
    public class InvalidOrNoCoupon : ICouponStrategy
    {
        public int GetDiscountRate(int distance, int weight)
        {
            return 0;
        }
    }
}
