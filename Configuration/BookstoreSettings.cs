
namespace BookStoreLite.Configuration;

public class BookstoreSettings
{
    public required string StoreTitle { get; set; }
    public int MaxBooksDisplayed { get; set; }
    public required string BookstoreAdminApiKey { get; set; }
}
