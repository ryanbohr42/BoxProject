using BoxProblem.Data;
using BoxProblem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoxProblem.Services
{
    public class BoxService
    {
        private BoxRepository repository;

        public BoxService(ApplicationDbContext context)
        {
            repository = new BoxRepository(context);
        }

        public List<BoxInventory> GetAllBoxes()
        {
            return repository.GetAllBoxes();
        }

        public void AddBox(BoxInventory toAdd)
        {
            repository.AddBox(toAdd);
        }

        public void DeleteBox(BoxInventory toDelete)
        {
            repository.DeleteBox(toDelete);
        }

        public void EditBox(BoxInventory toSave)
        {
            repository.SaveEdits(toSave);
        }

        public BoxInventory GetBoxById(int id) {
            return repository.GetBoxById(id);
        }

        public List<BoxInventory> Search(int? weight, int? volume, bool canHoldLiquid)
        {
            return repository.Search(weight, volume, canHoldLiquid);
        }
    }
}
