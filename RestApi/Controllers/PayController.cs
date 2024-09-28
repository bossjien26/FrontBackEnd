using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApi.Model;
using RestApi.Services;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PayController : ControllerBase
    {
        private PayServices _payServices = new PayServices();

        [HttpPost, Route("TodayPay")]
        public IActionResult TodayPay(PayRequest payRequest)
        {
            Salary pay = _payServices.TodayPayment(payRequest.hour);
            return Ok(pay);
        }
    }
}