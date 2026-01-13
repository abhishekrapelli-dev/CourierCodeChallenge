using CourierCodeChallenge.Discount.Impl;
using CourierCodeChallenge.Discount.Impl.Abstraction;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierCodeChallenge.Discount
{
    public class DiscountCouponFactory
    {
        public static ICouponStrategy Create(string offerCode)
        {
            return offerCode switch
            {
                "OFR001" => new Coupon10(),
                "OFR002" => new Coupon7(),
                "OFR003" => new Coupon5(),
                _ => new InvalidOrNoCoupon()
            };
        }
    }
}
