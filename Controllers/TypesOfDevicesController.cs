using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using test.Data;
using test.Models;

namespace test.Controllers
{
    public class TypesOfDevicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TypesOfDevicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TypesOfDevices
        public async Task<IActionResult> Index()
        {
            return View(await _context.TypesOfDevice.ToListAsync());
        }

        // GET: TypesOfDevices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typesOfDevice = await _context.TypesOfDevice
                .FirstOrDefaultAsync(m => m.ID == id);
            if (typesOfDevice == null)
            {
                return NotFound();
            }

            return View(typesOfDevice);
        }

        // GET: TypesOfDevices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypesOfDevices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TypeName")] TypesOfDevice typesOfDevice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typesOfDevice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typesOfDevice);
        }

        // GET: TypesOfDevices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typesOfDevice = await _context.TypesOfDevice.FindAsync(id);
            if (typesOfDevice == null)
            {
                return NotFound();
            }
            return View(typesOfDevice);
        }

        // POST: TypesOfDevices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TypeName")] TypesOfDevice typesOfDevice)
        {
            if (id != typesOfDevice.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typesOfDevice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypesOfDeviceExists(typesOfDevice.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(typesOfDevice);
        }

        // GET: TypesOfDevices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typesOfDevice = await _context.TypesOfDevice
                .FirstOrDefaultAsync(m => m.ID == id);
            if (typesOfDevice == null)
            {
                return NotFound();
            }

            return View(typesOfDevice);
        }

        // POST: TypesOfDevices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typesOfDevice = await _context.TypesOfDevice.FindAsync(id);
            if (typesOfDevice != null)
            {
                _context.TypesOfDevice.Remove(typesOfDevice);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypesOfDeviceExists(int id)
        {
            return _context.TypesOfDevice.Any(e => e.ID == id);
        }
    }
}
