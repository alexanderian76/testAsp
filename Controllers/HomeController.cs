using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using TestAsp.Models;

namespace TestAsp.Controllers;

public class HomeController : Controller
{
	private readonly IPhoneService _service;

    public HomeController(IPhoneService service)
	{
		_service = service;
    }

	public IActionResult Index()
	{
		return View();
	}

	public IActionResult Privacy()
	{
		return View();
	}


    [HttpGet]
	public async Task<IActionResult> GetPhones()
	{
		var response = await _service.GetAll();
		return Ok(response);
	}

	[HttpGet]
	public async Task<IActionResult> GetPhoneById(int id)
	{
		var response = await _service.GetById(id);
		return Ok(response);
	}

	[HttpPost]
	public async Task<IActionResult> CreatePhones([FromBody] IEnumerable<Phone> phones)
	{
        var response = await _service.CreatePhones(phones.OrderBy(e => e.Code));
		return Ok(response);
	}


	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error()
	{
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}

