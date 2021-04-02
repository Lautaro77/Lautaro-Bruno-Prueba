using Homeworks.BusinessLogic;
using Homeworks.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homeworks.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeworksController : ControllerBase
    {
        private IHomeworkLogic logic;

        public HomeworksController(IHomeworkLogic logic = null)
        {
            if (logic == null)
            {
                this.logic = new HomeworksLogic();
            }
            else
            {
                this.logic = logic;
            }
        }

        // GET api/homeworks
        [HttpGet]
        public ActionResult Get()
        {
            IEnumerable<Homework> homeworks = logic.GetHomeworks();
            return Ok(homeworks);
        }
        // GET api/homeworks/id
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(Guid id)
        {
            Homework homework = logic.Get(id);
            if (homework == null)
            {
                return NotFound();
            }
            return Ok(homework);
        }

        [HttpPost]
        public IActionResult Post([FromBody] HomeworkDTO homeworkDTO)
        {
            try
            {
                Homework homework = homeworkDTO.ToEntity();
                Homework createdHomework = logic.Create(homework);

                HomeworkDTO homeworkToReturn = new HomeworkDTO(createdHomework);
                return CreatedAtRoute("Get", new { id = homeworkToReturn.Id }, homeworkToReturn);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Homework homework)
        {
            try
            {
                Homework updatedHomework = logic.Update(id, homework);
                return CreatedAtRoute("Get", new { id = homework.Id }, updatedHomework);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            logic.Remove(id);
            return NoContent();
        }
    }
}
