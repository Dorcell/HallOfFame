using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Implementations
{
    class EFDirectoryRepository : IDirectoryRepository
    {
        private EFDBContext context;

        public EFDirectoryRepository(EFDBContext context)
        {
            this.context = context;
        }        

        public IEnumerable<Directory> GetAllDirectories(bool includeMaterials = false)
        {
            if (includeMaterials)
                return context.Set<Directory>().Include(x => x.Materials).AsNoTracking().ToList();
            else
                return context.Directory.ToList();
            
            //throw new NotImplementedException();
        }

        public Directory GetDirectoryById(int directoryId, bool IncludeMaterials = false)
        {
            if (IncludeMaterials)
                return context.Set<Directory>().Include(x => x.Materials).AsNoTracking().FirstOrDefault(x => x.Id == directoryId);
            else
                return context.Directory.FirstOrDefault(x => x.Id == directoryId);
            
            //throw new NotImplementedException();
        }

        public void SaveDirectory(Directory directory)
        {
            if (directory.Id == 0)
                context.Directory.Add(directory);
            else
                context.Entry(directory).State = EntityState.Modified;
            
            //throw new NotImplementedException();
        }

        public void DeleteDirectory(Directory directory)
        {
            context.Directory.Remove(directory);
            context.SaveChanges();
            // throw new NotImplementedException();
        }
    }
}
