using Refit;
using SysCepConsole.Refitt.IRefit;

namespace SysCepConsole.IRefit
{
    public interface IRefit
    {
        [Get("/ws/{cep}/json/")]
        Task<CepResponse> ConsultaCep(string cep);
    }
}
