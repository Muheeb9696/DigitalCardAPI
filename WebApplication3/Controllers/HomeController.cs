using DigitalCard.IReporsitory;
using Microsoft.AspNetCore.Mvc;
using DigitalCard.Application.Services;
namespace DigitalCard.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private Inevigation _nevigationService;

        private readonly INevigation _repository;
        public HomeController(Inevigation nevigationService)
        {
            _nevigationService = nevigationService;
        }

        //[HttpGet("GetMovieInformation")]
        //public IActionResult GetMovieInformation(string Keyname)
        //{ 

        //    if(Keyname == null)
        //    {
        //        return BadRequest();
        //    }
        //    if(Keyname.Contains(";"))
        //    {
        //      string[]type=  Keyname.Split(";");
        //        if(Keyname.Length > 0 )
        //        {
        //            if(type[0].ToLower().Contains("mov"))
        //            {
        //            var moviewList = Services.GetMoview(type[1]);
        //                return Ok(moviewList);
        //            }
        //            if (type[0].ToLower().Contains("act"))
        //            {
        //                var actorlist = Services.GetActor(type[1]);
        //                return Ok(actorlist);
        //            }
        //            if (type[0].ToLower().Contains("dir"))
        //            {
        //                var actorlist = Services.GetDirector(type[1]);
        //                return Ok(actorlist);
        //            }

        //        }


        //    }
        //    else
        //    {
        //        if (Keyname.ToLower().Contains("mov"))
        //        {
        //            var moviewList = Services.GetMoview();
        //            return Ok(moviewList);
        //        }
        //        if (Keyname.ToLower().Contains("act"))
        //        {
        //            var actorlist = Services.GetActor();
        //            return Ok(actorlist);
        //        }
        //        if (Keyname.ToLower().Contains("dir"))
        //        {
        //            var dirlist = Services.GetDirector();
        //            return Ok(dirlist);
        //        }
        //    }
        //    return BadRequest("No Data Found");
        //}

        [HttpGet("gettopnevigation")]
        public async Task<IActionResult> Getnavigation()
        {
            var result = await _nevigationService.GetAllNevigationAsync();

            return Ok(result);
        }
    }
}
