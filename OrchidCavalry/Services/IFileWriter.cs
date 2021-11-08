using System.Threading.Tasks;

namespace OrchidCavalry.Services
{
    public interface IFileWriter
    {
        Task<string> ReadFileAsync(string fileName);
        Task WriteFileAsync(string fileName, string contents);
    }
}