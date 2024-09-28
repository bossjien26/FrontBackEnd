using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Model
{
    public class PayRequest
    {
        public int hour { get; set; }
    }

    public class Salary
    {
        public string Message { get; set; } = "";
        public double Pay { get; set; }
    }
}