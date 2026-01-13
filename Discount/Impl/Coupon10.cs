using CourierCodeChallenge.Discount.Impl.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierCodeChallenge.Discount.Impl
{
    public class Coupon10 : ICouponStrategy
    {
        public int GetDiscountRate(int distance, int weight)
        {
            if (distance < 200 && weight >= 70 && weight <= 200)
                return 10;

            return 0;
        }
    }
}
