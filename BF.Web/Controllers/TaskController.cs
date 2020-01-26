using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BF.Abstractions;
using BF.Core;

namespace BF.Web.Controllers
{
    [Authorize]
    public class TaskController : ApiController
    {
        private IUnitOfWork _unitOfWork;

        public TaskController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IHttpActionResult GetTasks()
        {
            return Ok(_unitOfWork.TaskRepository.GetAll());
        }

        public IHttpActionResult GetTask(int id)
        {
            return Ok(_unitOfWork.TaskRepository.GetById(id));
        }

        public IHttpActionResult PutTask(Tasks task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _unitOfWork.TaskRepository.Update(task);
            return Ok();
        }

        public IHttpActionResult PostTask(Tasks task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _unitOfWork.TaskRepository.Insert(task);
            return Ok();
        }

        public IHttpActionResult DeleteTask(int id)
        {
            _unitOfWork.TaskRepository.Delete(id);
            return Ok();
        }
    }
}
