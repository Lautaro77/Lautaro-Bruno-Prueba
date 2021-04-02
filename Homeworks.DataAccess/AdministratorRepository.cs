using Homeworks.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks.DataAccess
{
    public class AdministratorRepository : IAdministratorRepository
    {
        protected DbContext Context { get; set; }

        public AdministratorRepository(DbContext context)
        {
            Context = context;
        }

        public void Add(Administrator entity)
        {
            Context.Set<Administrator>().Add(entity);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

    }
}
