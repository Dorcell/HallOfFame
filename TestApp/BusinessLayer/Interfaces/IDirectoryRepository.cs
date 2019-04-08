using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IDirectoryRepository
    {
        IEnumerable<Directory> GetAllDirectories(bool includeMaterials = false);

        Directory GetDirectoryById(int directoryId, bool IncludeMaterials = false);

        void SaveDirectory(Directory achieve);

        void DeleteDirectory(Directory achieve);
    }
}
