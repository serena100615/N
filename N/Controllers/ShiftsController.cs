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
    public class ShiftsController : Controller
    {
        private readonly NisContext _context;

        public ShiftsController(NisContext context)
        {
            _context = context;
        }

        // GET: Shifts
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;

            var shifts = from s in _context.Shifts
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                shifts = shifts.Where(s => s.ClassDate.ToString().Contains(searchString)
                || s.DepName.Contains(searchString));
            }          
            return View(await shifts.AsNoTracking().ToListAsync());
        }      
    }
}
