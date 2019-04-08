using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IMaterialsRepository
    {
        IEnumerable<Material> GetAllMaterials(bool includeDirectory = false);

        Material GetMaterialById(int materialId, bool IncludeDirectory = false);

        void SaveMaterial(Material achieve);

        void DeleteMaterial(Material achieve);
    }
}
