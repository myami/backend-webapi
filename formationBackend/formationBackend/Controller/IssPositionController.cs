using formationBackend.Model;
using formationBackend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace formationBackend.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssPositionController : ControllerBase
    {
        private readonly IGetIssPosition _issposition;
        public IssPositionController(IGetIssPosition issposition)
        {
            _issposition = issposition;
        }
        [HttpGet]
        [Route("get/")]
        public ActionResult GetCurrentIssPosition()
        {
          var result =  new IssPosition();
            if (result.Equals(null))
                return NotFound();
            return Ok(result);
        }
        [HttpGet]
        [Route("get/all")]
        public ActionResult GetLastdayIssPosition() {
            return Ok(new List<IssPosition> { });
        }
    }
}
