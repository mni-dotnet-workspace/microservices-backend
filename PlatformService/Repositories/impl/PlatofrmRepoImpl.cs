using PlatformService.Data;
using PlatformService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Repositories.impl
{
    public class PlatofrmRepoImpl : IPlatformRepo
    {
        private readonly AppDbContext appDbContext;
        public PlatofrmRepoImpl(AppDbContext appDbContext)
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
