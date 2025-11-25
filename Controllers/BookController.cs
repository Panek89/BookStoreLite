using BookStoreLite.Configuration;
using BookStoreLite.DataAccess;
using BookStoreLite.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.FeatureManagement;

namespace BookStoreLite.Controllers;

public class BookController : Controller
{
    private readonly AppDbContext _context;
    private readonly IOptionsMonitor<BookstoreSettings> _settingsMonitor;

    public BookController(AppDbContext context, IOptionsMonitor<BookstoreSettings> optionsMonitor)
    {
        _context = context;
        _settingsMonitor = optionsMonitor;
    }

    public async Task<IActionResult> Index([FromServices] IFeatureManager featureManager)
    {
        var maxBooksDisplayed = _settingsMonitor.CurrentValue.MaxBooksDisplayed;
        var enableRareBooks = await featureManager.IsEnabledAsync("EnableRareBooks");
        ViewBag.EnableRareBooks = enableRareBooks;
        ViewBag.MaxBooksDisplayed = maxBooksDisplayed;

        var query = _context.Books as IQueryable<Book>;
        if (enableRareBooks is false)
        {
            query = query.Where(x => !x.IsRare);   
        }
        

        return View(await query.Take(maxBooksDisplayed).ToListAsync());
    }

    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Book book)
    {
        if (ModelState.IsValid)
        {
            _context.Add(book);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(book);
    }

}
