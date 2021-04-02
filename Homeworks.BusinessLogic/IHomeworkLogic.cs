using Homeworks.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks.BusinessLogic
{
    public interface IHomeworkLogic
    {
        Homework Create(Homework homework);

        IEnumerable<Homework> GetHomeworks();

        void Remove(Guid id);

        Homework Update(Guid id, Homework homework);

        Homework Get(Guid id);
    }
}
