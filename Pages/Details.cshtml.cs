using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectOrganizer.Data;
using ProjectOrganizer.Models;

namespace ProjectOrganizer.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly ProjectOrganizerDbContext _context;

        public DetailsModel(ProjectOrganizerDbContext context)
        {
            _context = context;
        }

        public Project Project { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Projects.FirstOrDefaultAsync(m => m.Id == id);
            if (project == null)
            {
                return NotFound();
            }
            else
            {
                Project = project;
            }
            return Page();
        }
    }
}
