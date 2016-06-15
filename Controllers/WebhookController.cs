using adRom.WebhookListener.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace adRom.WebhookListener.Controllers
{
    [RoutePrefix("Webhook")]
    public class WebhookController : ApiController
    {        
        [HttpPost]
        [Route("Bounce")]
        public IHttpActionResult Bounce(List<BounceHook> items)
        {            
            if (items == null || items.Count == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPost]
        [Route("FeedbackLoop")]
        public IHttpActionResult FeedbackLoop(List<FeedbackLoopHook> items)
        {
            if (items == null || items.Count == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPost]
        [Route("DeliveredDropped")]
        public IHttpActionResult DeliveredDropped(List<DeliveredDroppedHook> items)
        {
            if (items == null || items.Count == 0)
            {
                return BadRequest();
            }
                       
            return Ok();
        }
        
    }
}