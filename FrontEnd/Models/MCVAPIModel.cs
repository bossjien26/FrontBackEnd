using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public class APIRequestModel
    {
        public int hour { get; set; }
    }

    public class SalaryModel
    {
        public string Message { get; set; } = "";
        public double Pay { get; set; }
    }
}