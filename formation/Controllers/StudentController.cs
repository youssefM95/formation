using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using formation.Models;
using formation.Repository;
using formation.Services;
using Microsoft.AspNetCore.Mvc;

namespace formation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SchoolService _service;

        public StudentController(IUnitOfWork unit)
        {
            _service = new SchoolService(unit);
        }
        // GET api/values
        [HttpGet]
        public List<Student> Get()
        {
            return _service.getAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Student value)
        {
            _service.add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
