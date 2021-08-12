using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie27.Models;
using System.Threading.Tasks;

namespace RazorPagesMovie27.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovie27.Data.RazorPagesMovie27Context _context;

        public DetailsModel(RazorPagesMovie27.Data.RazorPagesMovie27Context context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
