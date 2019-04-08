using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public static class SampleData
    {
        public static void InitData(EFDBContext context)
        {
            if (!context.Directory.Any())
            {
                context.Directory.Add(new Directory() { Title = "First Directory", Html = "<b> Directory content</b>" });
                context.Directory.Add(new Directory() { Title = "Second Directory", Html = "<b> Directory content</b>" });
                context.Directory.Add(new Directory() { Title = "Third Directory", Html = "<b> Directory content</b>" });

                context.SaveChanges();
            }

            else if (!context.Material.Any())
            {
                context.Material.Add(new Material() { Title = "First Material", Html = "<b> Material content</b>", DirectoryId = context.Directory.First().Id });
                context.Material.Add(new Material() { Title = "Second Material", Html = "<b> Material content</b>", DirectoryId = context.Directory.Last().Id });
                context.Material.Add(new Material() { Title = "Third Material", Html = "<b> Material content</b>", DirectoryId = context.Directory.Last().Id });

                context.SaveChanges();
            
            }
        }
    }
}
