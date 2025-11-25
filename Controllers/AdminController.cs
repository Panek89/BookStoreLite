using BookStoreLite.Configuration;
using BookStoreLite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BookStoreLite.Controllers
{
    public class AdminController : Controller
    {
        private readonly BookstoreSettings _settings;

        public AdminController(IOptions<BookstoreSettings> options)
        {
            _settings = options.Value ?? throw new ArgumentNullException(nameof(options));
        }

        public ActionResult Index()
        {
            var bookstoreAdminApiKey = _settings.BookstoreAdminApiKey;
            var model = new AdminViewModel { BookstoreAdminApiKey = bookstoreAdminApiKey };
            
            return View(model);
        }

    }
}
