using PlatformService.Data;
using PlatformService.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlatformService.Repositories.impl
{
    public class PlatformRepoImpl : IPlatformRepo
    {
        private readonly AppDbContext appDbContext;
        public PlatformRepoImpl(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public void CreatePlatform(Platform plat)
        {
            if(plat == null)
            {
                throw new ArgumentNullException(nameof(plat));
            }

            appDbContext.Platforms.Add(plat);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return appDbContext.Platforms.ToList();
        }

        public Platform GetPlatformById(int id)
        {
            return appDbContext.Platforms.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (appDbContext.SaveChanges() > 0);
        }
    }
}
