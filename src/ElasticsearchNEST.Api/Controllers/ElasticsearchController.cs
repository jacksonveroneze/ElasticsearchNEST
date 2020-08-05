using System.Collections.Generic;
using System.Net.Mime;
using ElasticsearchNEST.Domain.Entities;
using ElasticsearchNEST.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElasticsearchNEST.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ElasticsearchController : Controller
    {
        private readonly IRepository _repository;

        public ElasticsearchController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Post()
        {
            _repository.Add();

            return Ok();
        }

        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ICollection<IndexItem>), StatusCodes.Status200OK)]
        public ICollection<IndexItem> GetAll()
        {
            return _repository.FindAll();
        }
        
        [HttpGet("find-by-name/{name}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ICollection<IndexItem>), StatusCodes.Status200OK)]
        public ICollection<IndexItem> FindByName(string name)
        {
            return _repository.FindByName(name);
        }
        
        [HttpGet("find-by-description/{description}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ICollection<IndexItem>), StatusCodes.Status200OK)]
        public ICollection<IndexItem> FindByDescription(string description)
        {
            return _repository.FindByDescription(description);
        }
    }
}