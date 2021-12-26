﻿using PlatformService.Models;
using System.Collections.Generic;

namespace PlatformService.Repositories
{
    public interface IPlatformRepo
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform plat);
    }
}
