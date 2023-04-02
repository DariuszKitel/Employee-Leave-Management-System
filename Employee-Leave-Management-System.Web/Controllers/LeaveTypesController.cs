using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Employee_Leave_Management_System.Web.Data;
using Employee_Leave_Management_System.Web.Data.Entities;
using AutoMapper;
using Employee_Leave_Management_System.Web.Models.Dtos;

namespace Employee_Leave_Management_System.Web.Controllers
{
    public class LeaveTypesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public LeaveTypesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var modelDtos = _mapper.Map<List<LeaveTypeDto>>(await _context.LeaveTypes.AsNoTracking().ToListAsync());
            return View(modelDtos);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LeaveTypes == null)
            {
                return NotFound();
            }

            var leaveType =  await _context.LeaveTypes
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeDto = _mapper.Map<LeaveTypeDto>(leaveType);
            return View(leaveTypeDto);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypeDto leaveTypeDto)
        {
            if (ModelState.IsValid)
            {
                var leaveTypeEntity = _mapper.Map<LeaveType>(leaveTypeDto);
                _context.Add(leaveTypeEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeDto);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LeaveTypes == null)
            {
                return NotFound();
            }

            var leaveType = await _context.LeaveTypes.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeDto = _mapper.Map<LeaveTypeDto>(leaveType);
            return View(leaveTypeDto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypeDto leaveTypeDto)
        {
            if (id != leaveTypeDto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var leaveTypeEntity = _mapper.Map<LeaveType>(leaveTypeDto);
                    _context.Update(leaveTypeEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeaveTypeExists(leaveTypeDto.Id))
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
            return View(leaveTypeDto);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveType = await _context.LeaveTypes.AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveType == null)
            {
                return NotFound();
            }

            return View(leaveType);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var leaveType = await _context.LeaveTypes.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (leaveType != null)
            {
                _context.LeaveTypes.Remove(leaveType);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool LeaveTypeExists(int id)
        {
          return (_context.LeaveTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
