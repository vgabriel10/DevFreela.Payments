using DevFreela.Payments.API.Models;

namespace DevFreela.Payments.API.Services.Interfaces
{
    public interface IPayamentService
    {
        Task<bool> Process(PaymentInfoInputModel payamentInfoInputModel);
    }
}
