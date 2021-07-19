using BlogApp.Business.Tools.FacadeTool;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        private readonly IFacade _facade;
        public ErrorController(IFacade facade)
        {
            _facade = facade;
        }
        [HttpGet]
        public IActionResult Error()
        {
            var errorInfo = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            _facade.CustomLogger.LogError($"\nHatanın oluştuğu yer:{errorInfo.Path}\n Hata Mesajı:{errorInfo.Error.Message} \n Stack Trace:{errorInfo.Error.StackTrace}");
            return Problem(detail: "bir hata oluştu en kısa zamanda fixlenecek");
        }
    }
}
