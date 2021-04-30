using AulaAp.Application;
using AulaAp.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaAp.Service.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderAplication orderApplication;
        private readonly ILogger<OrderController> logger;

        public OrderController(ILogger<OrderController> logger, IOrderAplication orderApplication)
        {
            this.logger = logger;
            this.orderApplication = orderApplication;
        }

        [HttpPost]
        public async Task<IActionResult> Post(OrderCreateViewModel orderCreateViewModel)
        {
            try
            {
                logger.LogInformation("Iniciando criação do pedido: {0}",orderCreateViewModel);
                await orderApplication.AddOrder(orderCreateViewModel);
                return Ok();
            }
            catch (Exception ex )
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
