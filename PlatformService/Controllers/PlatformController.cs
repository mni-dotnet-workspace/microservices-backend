using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Dtos;
using PlatformService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlatformService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        private readonly IPlatformRepo platFormRepo1;
        private readonly IMapper mapper1;

        public PlatformController(IPlatformRepo platformRepo, IMapper mapper)
        {
            platFormRepo1 = platformRepo;
            mapper1 = mapper;
        }

        public ActionResult<IEnumerable<PlatformReadDto>> GetPlatforms()
        {
            Console.WriteLine("----> Getting Platforms....");
            var platformItem = platFormRepo1.GetAllPlatforms();
            if (platformItem.Count<PlatformReadDto>(IEnumerable<PlatformReadDto>) > 0)
            {

            }
        }
    }
}
