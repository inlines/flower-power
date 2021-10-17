using System;
using System.Collections.Generic;
using System.Linq;
using flower_power_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Data.SqlClient;

namespace flower_power_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _appDbContext;

        public HomeController(ILogger<HomeController> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _appDbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<Flower> Get()
        {
            return this._appDbContext.Flowers.ToList();
        }
    }
}