using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using N.Data;
using N.Models;

namespace N.Controllers
{
    public class WorksController : Controller
    {
        private readonly NisContext _context;

        public WorksController(NisContext context)
        {
            _context = context;
        }

        // GET: Works
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            
            ViewData["CurrentFilter"] = searchString;
            var works = from s in _context.Works
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                works = works.Where(w => w.DepName.Contains(searchString));
                
            }
            
            return View(await works.AsNoTracking().ToListAsync());
       
    }

        
    }
}
