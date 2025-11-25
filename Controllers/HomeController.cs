using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookStoreLite.Models;
using Microsoft.FeatureManagement;
using BookStoreLite.Configuration;
using Microsoft.Extensions.Options;

namespace BookStoreLite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly BookstoreSettings _settings;
    private readonly IOptionsMonitor<BookstoreSettings> _optionsMonitor;

    public HomeController(ILogger<HomeController> logger, IOptions<BookstoreSettings> options, IOptionsMonitor<BookstoreSettings> optionsMonitor)
    {
        _logger = logger;
        _settings = options.Value;
        _optionsMonitor = optionsMonitor;
    }

    public async Task<IActionResult> Index([FromServices] IFeatureManager featureManager)
    {
        ViewBag.MyFeatureEnabled = await featureManager.IsEnabledAsync("EnableRareBooks");
        var storeTitle = _settings.StoreTitle;
        var storeTitleMonitor = _optionsMonitor.CurrentValue.StoreTitle;
        var model = new HomeViewModel { StoreTitle = storeTitle, StoreTitleMonitor = storeTitleMonitor };

        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
