﻿using CronCraftInterfaces;
using CronCraftService.BLL;
using Microsoft.AspNetCore.Mvc;
using ModelService.Hypercare;

namespace CronCraftAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CronCraftController : ControllerBase
    {
        private readonly ILogger _logger = (new LoggerFactory()).CreateLogger<CronCraftController>();
        private static ICronCraftService _cronCraftService => new CronCraft();

        [HttpGet]
        public async Task<IList<HyperCareScheduler>> GetCronCraft()
        {
            _logger.LogInformation("GetCronCraft called");
            return await _cronCraftService.GetCronCraft();
        }

        [HttpGet]
        public async Task<IList<HyperCareScheduler>> GetCronCraftById(int scheduleId)
        {
            _logger.LogInformation("GetCronCraftById called");
            return await _cronCraftService.GetCronCraftById(scheduleId);
        }

        [HttpPost]
        public async Task<bool> AddCronCraft(HyperCareScheduler taskSchedulerMap)
        {
            _logger.LogInformation("AddCronCraft called");
            return await _cronCraftService.AddCronCraft(taskSchedulerMap);
        }

        [HttpPut]
        public async Task<bool> UpdateCronCraft(HyperCareScheduler taskSchedulerMap)
        {
            _logger.LogInformation("UpdateCronCraft called");
            return await _cronCraftService.UpdateCronCraft(taskSchedulerMap);
        }
    }
}
