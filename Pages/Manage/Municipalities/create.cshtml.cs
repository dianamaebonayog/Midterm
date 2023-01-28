using BonayogDianaMae.Midterm.Infrastructure.Domain;
using BonayogDianaMae.Midterm.Infrastructure.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using BonayogDianaMae.Midterm.Infrastructure.Domain;

namespace BonayogDianaMae.Midterm.Pages.Manage.Roles
{
    public class Create : PageModel
    {
        private ILogger<Index> _logger;
        private DefaultDbContext _context;

        [BindProperty]
        public ViewModel View { get; set; }

        public Create(DefaultDbContext context, ILogger<Index> logger)
        {
            _logger = logger;
            _context = context;
            View = View ?? new ViewModel();
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(View.Name))
            {
                ModelState.AddModelError("", "Role name cannot be blank.");
                return Page();
            }

            if (string.IsNullOrEmpty(View.Description))
            {
                ModelState.AddModelError("", "Description name cannot be blank.");
                return Page();
            }

            Municipalities municipalities = new Municipalities)
            {
                Id = Guid.NewGuid(),
                Name = View.Name,
                Description = View.Description,
                Abbreviation = View.Abbreviation
            };

            _context?.Municipalities?.Add(municipalities);
            _context?.SaveChanges();

            return RedirectPermanent("~/manage/roles");
        }

        public class ViewModel : Municipalities

        }
    }
}