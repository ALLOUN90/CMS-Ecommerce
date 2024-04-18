using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CMS_Ecommerce.Infrastructure.Components
{
    public class MenuViewComponent(DataContext context) : ViewComponent
    {
        private readonly DataContext _context = context;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.Pages.Where(x => x.Slug != "home").ToListAsync());
        }
    }
}
