using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameDbTest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GameDbTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GamesController : ControllerBase
    {
        private readonly ILogger<GamesController> _logger;

        public GamesController(ILogger<GamesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<GameInCatalogModel> Get()
        {
            const string url = @"https://thumbs.dreamstime.com/b/happy-cat-portrait-funny-smile-tongue-young-closeup-cardboard-135604814.jpg";

            return new[]
            {
                new GameInCatalogModel(1, "test game", url, 9, new[] {"test1", "test2"})
            };
        }
    }
}