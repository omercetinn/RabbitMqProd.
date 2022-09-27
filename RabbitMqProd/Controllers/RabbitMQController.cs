using Microsoft.AspNetCore.Mvc;
using RabbitMqProd_.Services;

namespace RabbitMqProd_.Controllers
{
   
        [ApiController]
        [Route("[controller]")]
        public class RabbitMQProducerController : ControllerBase
        {
            private readonly IRabbitMQService _rabbitMQService;

            public RabbitMQProducerController(IRabbitMQService rabbitMQService)
            {
                _rabbitMQService = rabbitMQService;
            }

            [HttpGet]
            public IActionResult Get(string name)
            {
                _rabbitMQService.SendNameToQueue(name);
                return Ok("Success");
            }
        }
    
}