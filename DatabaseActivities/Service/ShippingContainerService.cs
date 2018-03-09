using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Service
{
    public class ShippingContainerService
    {
        private ShippingContainerRepository repository;

        public ShippingContainerService ()
        {
            repository = new ShippingContainerRepository();
        }
        public List<ShippingContainer> GetAllShippingContainers()
        {
            return repository.GetAllShippingContainers();
        }
        public void AddPackage(ShippingContainer toAdd)
        {
            repository.AddPackage(toAdd);
        }
        public void EditPackage(ShippingContainer toSave)
        {
            repository.EditPackage(toSave);
        }
        public ShippingContainer GetShippingContainerByID(int id)
        {
            return repository.GetShippingContainerByID(id);
        }
        public void DeleteShippingContainer(ShippingContainer toDelete)
        {
            repository.DeleteShippingContainer(toDelete);
        }
        public List<ShippingContainer> WeightCompare(int userWeight)
        {
            List<ShippingContainer> list = repository.GetAllShippingContainers();
            for(int i = list.Count-1; i >= 0; i--)
            {
                if(list[i].weight < userWeight)
                {
                    list.Remove(list[i]);
                }
            }
            return list;
        }
    }
}