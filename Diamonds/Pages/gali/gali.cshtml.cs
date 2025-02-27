using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diamonds.Pages;

public class GaliModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public GaliModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}   