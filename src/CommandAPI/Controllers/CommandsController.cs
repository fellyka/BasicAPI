using System;
using System.Collections;
using AutoMapper;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CommandAPI.Data;
using CommandAPI.Models;
using CommandAPI.Dtos;

namespace CommandAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CommandsController : ControllerBase
	{
		private readonly ICommandAPIRepo _repository;
		private readonly IMapper _mapper;
		
		public CommandsController(ICommandAPIRepo repository, IMapper mapper)		
		{
			_repository = repository;
			_mapper = mapper;
		}
		
		[HttpGet]
		public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
		{
			var commandItems = _repository.GetAllCommands();
			return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
		}
		
		[HttpGet("{id}")]
		public ActionResult<CommandReadDto> GetCommandById(int id)
		{
			var commandItem = _repository.GetCommandById(id);
			if (commandItem == null)
				return NotFound();
			 return Ok(_mapper.Map<CommandReadDto>(commandItem));	
		}
		
	}
}