using DevFreela.Payments.API.Models;
using DevFreela.Payments.API.Services.Interfaces;

namespace DevFreela.Payments.API.Services
{
    public class PayamentService : IPayamentService
    {
        public Task<bool> Process(PaymentInfoInputModel payamentInfoInputModel)
        {
            return Task.FromResult(true);
        }
    }
}
