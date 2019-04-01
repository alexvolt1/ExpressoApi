using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressoApi.Data;
using ExpressoApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ExpressoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        ExpressoDbContext _expressoDbContext;

        public MenusController(ExpressoDbContext expressoDbContext)
        {
            _expressoDbContext = expressoDbContext;
        }

        [HttpGet]
        public IActionResult GetMenus()
        {
            var menus = _expressoDbContext.Menus.Include("SubMenus");

            return Ok(menus);
        }

        [HttpGet("{id}")]
        public IActionResult GetMenus(int id)
        {
            var menu = _expressoDbContext.Menus.Include("SubMenus").Where(m => m.Id == id);
            if (menu == null)
            {
                return NotFound();
            }

            return Ok(menu);
        }


        // POST: api/menus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Image")] Menu menu)
        {
            Menu model = new Menu()
            {
                Name = "test77",
                Image = "testUrl77"
            };

            if (ModelState.IsValid)
            {
                _expressoDbContext.Add(model);
                await _expressoDbContext.SaveChangesAsync();
                return Ok(menu);
            }
            return Ok(menu);
        }

    }
}