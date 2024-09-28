using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FrontEnd.Models;
using FrontEnd.Services;

namespace FrontEnd.Controllers;

public class MVCAPIController : Controller
{
    private readonly ILogger<MVCAPIController> _logger;

    private SalaryService salaryService = new SalaryService();

    public MVCAPIController(ILogger<MVCAPIController> logger)
    {
        _logger = logger;
    }

    [HttpPost, ActionName("testapi")]
    public IActionResult Test(APIRequestModel aPIRequestModel)
    {
        SalaryModel res = salaryService.TodayPayment(aPIRequestModel.hour);
        return Ok(res);
    }

    [HttpGet, ActionName("test")]
    public IActionResult Testapi()
    {
        return Ok("test");
    }
}
