﻿using App.Data.Entity;
using App.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientService _service;

        public PatientsController(IPatientService service)
        {
            _service = service;
        }

        // GET: api/<PatientsController>
        [HttpGet]
        public async Task<IEnumerable<Patient>> Get()
        {
            return await _service.GetAllPatientsByIncludeAsync();
        }

        // GET api/<PatientsController>/5
        [HttpGet("{id}")]
        public async Task<Patient> Get(int id)
        {
            return await _service.GetPatientByIncludeAsync(id);
        }

        // POST api/<PatientsController>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] Patient value)
        {
            await _service.AddAsync(value);
            var response = await _service.SaveAsync();
            if (response >0)
            {
                return Ok();
            }
            return Problem();

        }

        // PUT api/<PatientsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Patient value)
        {
            Patient mainPatient =  await _service.GetPatientByIncludeAsync(id);

            if (mainPatient!= null)
            {
                mainPatient = value;

                _service.Update(value);
                var response = await _service.SaveAsync();
                if (response > 0)
                {
                    return Ok();
                }
            }

            return Problem();
        }

        // DELETE api/<PatientsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            Patient mainPatient = await _service.GetPatientByIncludeAsync(id);

            if (mainPatient != null)
            {
                

                _service.Delete(mainPatient);
                var response = await _service.SaveAsync();
                if (response > 0)
                {
                    return Ok();
                }
            }

            return Problem();
        }
    }
}
