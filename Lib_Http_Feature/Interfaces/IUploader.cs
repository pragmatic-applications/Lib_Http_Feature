using System.Net.Http;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IUploader
    {
        Task<string> UploadImageAsync(MultipartFormDataContent content);
    }
}
