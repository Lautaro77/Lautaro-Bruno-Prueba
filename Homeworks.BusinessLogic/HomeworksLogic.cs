using System;
using System.Collections.Generic;

using Homeworks.Domain;
using Homeworks.DataAccess;

namespace Homeworks.BusinessLogic
{
    public class HomeworksLogic : IHomeworkLogic
    {
        private HomeworksRepository homeworksRepository;

        public HomeworksLogic()
        {
            // 1
            HomeworksContext context = ContextFactory.GetNewContext();
            homeworksRepository = new HomeworksRepository(context);
        }

        public IEnumerable<Homework> GetHomeworks()
        {
            // 2
            return homeworksRepository.GetAll();
        }

        public Homework Create(Homework homework)
        {
            // 1
            homeworksRepository.Add(homework);
            homeworksRepository.Save();
            return homework;
        }

        public void Remove(Guid id)
        {
            // 2
            Homework homework = homeworksRepository.Get(id);
            if (homework == null)
            {
                throw new ArgumentException("Invalid guid");
            }
            homeworksRepository.Remove(homework);
            homeworksRepository.Save();
        }

        public Homework Update(Guid id, Homework homework)
        {
            // 3
            Homework homeworkToUpdate = homeworksRepository.Get(id);
            if (homeworkToUpdate == null)
            {
                throw new ArgumentException("Invalid guid");
            }
            homeworkToUpdate.Description = homework.Description;
            homeworkToUpdate.DueDate = homework.DueDate;
            homeworksRepository.Update(homeworkToUpdate);
            homeworksRepository.Save();
            return homeworkToUpdate;
        }

        public Homework Get(Guid id)
        {
            // 4
            return homeworksRepository.Get(id);
        }
    }
}