using PubQuiz.Requests.Auth;
using PubQuiz.Responses;
using PubQuiz.Shared.Pagination;
using System.Threading.Tasks;

namespace PubQuiz.Services.Contracts
{
    public interface IAuthService : IAppService
    {
        Task<string> SignInAsync(string email, string password);
        Task<string> RegisterAsync(string email, string password);


    }
}