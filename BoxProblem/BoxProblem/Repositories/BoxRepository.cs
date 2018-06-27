using BoxProblem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoxProblem.Repositories
{
    public class BoxRepository
    {
        private ApplicationDbContext dbContext;
        
        public BoxRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<BoxInventory> GetAllBoxes()
        {
            return dbContext.Boxes.ToList();
        }

        public void AddBox(BoxInventory toAdd)
        {
            dbContext.Boxes.Add(toAdd);
            dbContext.SaveChanges();
        }

        public void DeleteBox(BoxInventory toDelete)
        {
            dbContext.Boxes.Remove(toDelete);
            dbContext.SaveChanges();
        }

        public void SaveEdits(BoxInventory toSave)
        {
            dbContext.Entry(toSave).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
        public BoxInventory GetBoxById(int Id)
        {
            return dbContext.Boxes.Find(Id);
        }
        public List<BoxInventory> Search(int? weight, int? volume, bool? canHoldLiquid)
        {
            var results = dbContext.Boxes.Where(Boxes => 
                (Boxes.Weight <= weight || weight == null) 
                && 
                (Boxes.Volume <= volume || volume == null)
                &&
                (Boxes.CanHoldLiquid == canHoldLiquid || canHoldLiquid == null)
                &&
                ((Boxes.Cost - cost < 1 || cost - Boxes.Cost < 1) || cost == null) 
                ); 
            return results.ToList();       
        }
    }
}
