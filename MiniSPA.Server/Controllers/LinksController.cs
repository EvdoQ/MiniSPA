using Microsoft.AspNetCore.Mvc;
using MiniSPA.Server.Models;
using MiniSPA.Server.Services.Interfaces;

namespace MiniSPA.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinksController : ControllerBase
    {
        private ILinkService _linkService;
        public LinksController(ILinkService linkService)
        {
            _linkService = linkService;
        }
        [HttpPost]
        public LinkModel Create(LinkModel model)
        {
            return _linkService.Create(model);
        }
        [HttpGet("{id}")]
        public LinkModel Get(int id)
        {
            return _linkService.Get(id);
        }

        [HttpGet]
        public List<LinkModel> Get()
        {
            return _linkService.Get();
        }
        [HttpPatch]
        public LinkModel Update(LinkModel model)
        {
            return _linkService.Update(model);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _linkService.Delete(id);
            return Ok();
        }
    }
}
