using Homeworks.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks.DataAccess
{
    public interface IAdministratorRepository
    {
        public void Add(Administrator entity);


        public void Save();


    }
}
