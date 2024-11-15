using CaseStudyPart2.ViewRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Part2_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewController : ControllerBase
    {
        IView _view;
        public ViewController(IView view)
        {
            _view = view;
        }

        [HttpGet]
        public IActionResult GetViewData()
        {
            var result = _view.Getdata();
            return Ok(result);
        }
    }
}
