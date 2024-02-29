using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectOrganizer.Data;
using ProjectOrganizer.Models;

namespace ProjectOrganizer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProjectOrganizerDbContext _context;

        public IndexModel(ProjectOrganizerDbContext context)
        {
            _context = context;
        }

        public IList<Project> Project { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Project = await _context.Projects.ToListAsync();
        }
    }
}
