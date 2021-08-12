using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie27.Models;
using System.Threading.Tasks;

namespace RazorPagesMovie27.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMovie27.Data.RazorPagesMovie27Context _context;

        public CreateModel(RazorPagesMovie27.Data.RazorPagesMovie27Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
