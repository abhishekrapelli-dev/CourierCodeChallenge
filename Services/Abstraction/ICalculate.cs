using CourierCodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierCodeChallenge.Services.Abstraction
{
    public interface IEstimate
    {
        void Calculate(List<Package> packages);

        void DisplayResult(List<Package> packages);
    }
}
