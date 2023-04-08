using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Employee_Leave_Management_System.Web.Data.Entities;
using AutoMapper;
using Employee_Leave_Management_System.Web.Models.Dtos;
using Employee_Leave_Management_System.Web.Contracts;

namespace Employee_Leave_Management_System.Web.Controllers
{
	public class LeaveTypesController : Controller
	{
		private readonly ILeaveTypeRepository _leaveTypeRepository;
		private readonly IMapper _mapper;

		public LeaveTypesController(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
		{
			_leaveTypeRepository = leaveTypeRepository;
			_mapper = mapper;
		}

		public async Task<IActionResult> Index()
		{
			var modelDtos = _mapper.Map<List<LeaveTypeDto>>(await _leaveTypeRepository.GetAllAsync());
			return View(modelDtos);
		}

		public async Task<IActionResult> Details(int? id)
		{
			var leaveType = await _leaveTypeRepository.GetAsync(id);
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
				await _leaveTypeRepository.AddAsync(leaveTypeEntity);
				return RedirectToAction(nameof(Index));
			}
			return View(leaveTypeDto);
		}

		public async Task<IActionResult> Edit(int? id)
		{
			var leaveType = await _leaveTypeRepository.GetAsync(id);
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
					await _leaveTypeRepository.AddAsync(leaveTypeEntity);
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!await _leaveTypeRepository.Exists(leaveTypeDto.Id))
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

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			await _leaveTypeRepository.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
