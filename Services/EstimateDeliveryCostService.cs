using CourierCodeChallenge.Discount;
using CourierCodeChallenge.Models;
using CourierCodeChallenge.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierCodeChallenge.Services
{
    public class EstimateDeliveryCostService : IEstimate
    {
        public double _basePrice { get; }

        public EstimateDeliveryCostService(double basePrice)
        {
            _basePrice = basePrice;
        }

        public virtual void Calculate(List<Package> packages)
        {
            foreach (var package in packages)
            {
                var couponStrategy = DiscountCouponFactory.Create(package.OfferCode.ToUpper());
                var discountInPercent = couponStrategy.GetDiscountRate(package.Distance, package.Weight);

                var deliveryCost = GetDeliveryCostPackageWise(_basePrice, package);
                var discountCost = deliveryCost * (Convert.ToDouble(discountInPercent) / 100);

                package.DeliveryCost = deliveryCost - discountCost;
                package.DiscountPrice = discountCost;
            }
        }

        public virtual void DisplayResult(List<Package> packages)
        {
            foreach (var package in packages)
            {
                Console.WriteLine($"{package.Id} {package.DiscountPrice.ToString("F0")} {package.DeliveryCost.ToString("F0")}");
            }
        }

        private double GetDeliveryCostPackageWise(double basePrice, Package package)
        {
            return basePrice + package.Weight * 10 + package.Distance * 5;
        }
    }
}
