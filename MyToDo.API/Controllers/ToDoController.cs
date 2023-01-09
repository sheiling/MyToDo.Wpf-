﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyToDo.API.Context;
using MyToDo.API.Services;
using MyToDo.Shared.Dtos;
using MyToDo.Shared.Parameters;

namespace MyToDo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ToDoController : Controller
    {
        private readonly IToDoService _service;

        public ToDoController(IToDoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ApiResponse> Get(int id) => await _service.GetSingleAsync(id);

        [HttpGet]
        public async Task<ApiResponse> GetAll([FromQuery] ToDoParameter parameter) => await _service.GetAllAsync(parameter);

        [HttpGet]
        public async Task<ApiResponse> GetSummary() => await _service.GetSummaryAsync();

        [HttpPost]
        public async Task<ApiResponse> Add([FromBody] ToDoDto model) => await _service.AddAsync(model);

        [HttpPost]
        public async Task<ApiResponse> Update([FromBody] ToDoDto model) => await _service.UpdateAsync(model);

        [HttpDelete]
        public async Task<ApiResponse> Delete(int id) => await _service.DeleteAsync(id);
    }
}
