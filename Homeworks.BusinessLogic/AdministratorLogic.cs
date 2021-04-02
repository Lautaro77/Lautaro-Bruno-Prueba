using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworks.DataAccess;
using Homeworks.Domain;

namespace Homeworks.BusinessLogic
{
    public class AdministratorLogic
    {

        HomeworksContext context = ContextFactory.GetNewContext();

        //private AdministratorRepository administratorRepository;
        //public AdministratorLogic() 
        //{
        //    HomeworksContext context = ContextFactory.GetNewContext();
        //    administratorRepository = new AdministratorRepository(context);
        //}

        private IAdministratorRepository repo;

        public AdministratorLogic(IAdministratorRepository repo = null)
        {
            if (repo == null)
            {
                this.repo = new AdministratorRepository(context);
            }
            else
            {
                this.repo = repo;
            }
        }

        public Administrator Create(Administrator a)
        {
            repo.Add(a);
            repo.Save();
            return a;
        }


    }
}
