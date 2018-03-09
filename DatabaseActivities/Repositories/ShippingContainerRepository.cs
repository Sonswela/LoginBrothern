using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Repositories
{
    public class ShippingContainerRepository
    {
        private ApplicationDbContext context;

        public ShippingContainerRepository()
        {
            context = new ApplicationDbContext();
        }
        public List<ShippingContainer> GetAllShippingContainers()
        {
            return context.ShippingContainers.ToList();
        }
        public void AddPackage(ShippingContainer toAdd)
        {
            context.ShippingContainers.Add(toAdd);
            context.SaveChanges();
        }
        public void EditPackage(ShippingContainer toSave)
        {
            context.Entry(toSave).State = EntityState.Modified;
            context.SaveChanges();
        }
        public ShippingContainer GetShippingContainerByID(int id)
        {
            return context.ShippingContainers.Find(id);

        }
        public void DeleteShippingContainer(ShippingContainer toDelete)
        {
            context.ShippingContainers.Remove(toDelete);
            context.SaveChanges();

        }

    }
}