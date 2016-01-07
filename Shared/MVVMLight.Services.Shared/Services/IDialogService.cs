using System.Threading.Tasks;

namespace MVVMLight.Services.Shared.Services
{
    public interface IDialogService
    {
        Task ShowDialogAsync(string message);
    }
}
