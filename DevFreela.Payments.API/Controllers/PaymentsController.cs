using DevFreela.Payments.API.Models;
using DevFreela.Payments.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Payments.API.Controllers
{
    [ApiController]
    [Route("api/payments")]
    public class PaymentsController : ControllerBase
    {
        private readonly IPayamentService _payamentService;

        public PaymentsController(IPayamentService payamentService)
        {
            _payamentService = payamentService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PaymentInfoInputModel paymentInfoInputModel)
        {
            var result = await _payamentService.Process(paymentInfoInputModel);

            if (!result)
                return BadRequest();

            return NoContent();
        }
    }
}
